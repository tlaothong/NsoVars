using System.Collections.Generic;
using System.Linq;
using VarsWebApi.Models;

namespace VarsWebApi
{
    public class CalculateWaterUsage
    {
        public double CalcPlumping(Plumbing plumbing)
        {
            var sum = CalcMWA(plumbing) + CalcPWA(plumbing) + CalcOther(plumbing);
            return sum;
        }

        public double CalcMWA(Plumbing plumbing)
        {
            if (plumbing?.MWA?.Doing == true)
            {
                if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.MWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityMWA.Drink * 12 / 100.0;
                }
                else if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    // buildingType
                    return plumbing.MWA.PlumbingUsage.WaterBill.Value;
                }
                return 0;
            }
            return 0;
        }

        public double CalcPWA(Plumbing plumbing)
        {
            if (plumbing?.PWA?.Doing == true)
            {
                if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.PWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityPWA.Drink * 12 / 100.0;
                }
                else if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    // buildingType
                    return plumbing.PWA.PlumbingUsage.WaterBill.Value;
                }
                return 0;
            }
            return 0;
        }

        public double CalcOther(Plumbing plumbing)
        {
            if (plumbing?.Other?.Doing == true)
            {
                if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.Other.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityOther.Drink * 12 / 100.0;
                }
                else if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    // waterServices
                    return plumbing.Other.PlumbingUsage.WaterBill.Value;
                }
                return 0;
            }
            return 0;
        }

        public double CalcGroundWater(GroundWater groundWater)
        {
            var sum = CalcPrivate(groundWater?.PrivateGroundWater) + CalcPublic(groundWater?.PublicGroundWater);
            return sum;
        }

        public double CalcPrivate(PrivateGroundWater privateGroundWater)
        {
            if (privateGroundWater?.Doing == true)
            {
                return privateGroundWater.WaterResources.Sum(it =>
                {
                    if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.CubicMeterPerMonth)
                    {
                        return it.UsageType.UsageCubicMeters.Value * it.WaterActivities.Drink * 12 / 100.0;
                    }
                    else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.WaterBill)
                    {
                        // buildingType
                        return it.UsageType.WaterBill.Value / WaterBill(it.Location, BuildingType.SingleHouse);
                    }
                    else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.Unknown && it.HasPump.Value)
                    {
                        return CalcPumps(it.Pumps);
                    }
                    return 0;
                });
            }
            return 0;
        }

        public double CalcPublic(PublicGroundWater publicGroundWater)
        {
            if (publicGroundWater?.Doing == true)
            {
                return publicGroundWater.WaterResources.Sum(it =>
                {
                    if (it.HasCubicMeterPerMonth == true)
                    {
                        return it.CubicMeterPerMonth.Value * it.WaterActivities.Drink * 12 / 100.0;
                    }
                    else if (it.HasPump.Value)
                    {
                        return CalcPumps(it.Pumps);
                    }
                    return 0;
                });
            }
            return 0;
        }

        public double CalcPumps(List<Pump> pumps)
        {
            return pumps.Sum(it =>
            {
                return (it.PumpAuto.Value == false) ? it.HoursPerPump.Value * it.NumberOfPumpsPerYear.Value * CalcPumpRate(it) / 12 : 0;
            });
        }

        public double CalcPumpRate(Pump pump)
        {
            if (pump.HasPumpRate == true)
            {
                return pump.PumpRate.Value;
            }
            // EnergySource
            return 0;
        }

        public double WaterBill(Location location, BuildingType buildingType)
        {
            return isIn7Areas(location) ? isInBuildingType(buildingType) ? 8.5 : 13 : 3.5;
        }

        public bool isInBuildingType(BuildingType buildingType)
        {
            var types = new List<BuildingType>
            {
                BuildingType.SingleHouse, BuildingType.TownHouse,
                BuildingType.ShopHouse, BuildingType.Apartment,
                BuildingType.Religious, BuildingType.GreenHouse
            };
            return types.Any(it => it == buildingType);
        }

        public bool isIn7Areas(Location location)
        {
            var areas = new List<string>
            {
                "กรุงเทพมหานคร", "พระนครศรีอยุธยา", "ปทุมธานี", "สมุทรสาคร", "สมุทรปราการ", "นนทบุรี", "นครปฐม"
            };
            return areas.Any(it => it == location.Province);
        }

        public double CalcPool(Pool pool)
        {
            var sum = ((pool?.Doing ?? false) ? (pool?.WaterResources?.Sum(it => (it.HasCubicMeterPerMonth ?? false) ? (it.CubicMeterPerMonth ?? 0) * (it.WaterActivities?.Drink ?? 0) : 0) ?? 0) : 0) * 12 / 100.0;
            return sum;
        }

        public double CalcIrrigation(Irrigation irrigation)
        {
            var sum = ((irrigation?.HasCubicMeterPerMonth ?? false) ? (irrigation?.CubicMeterPerMonth ?? 0) * (irrigation?.WaterActivities?.Drink ?? 0) : 0) * 12 / 100.0;
            return sum;
        }

        public double CalcRain(Rain rain)
        {
            var sum = (rain?.RainContainers?.Sum(it => (it.Size?.Replace(",", "").Split(" - ").Select(i => int.Parse(i)).Average() ?? 0) * (it.Count ?? 0)) ?? 0)
            * (rain?.WaterActivities?.Drink ?? 0) / 100.0;
            return sum;
        }

        public double CalcBuying(Buying buying)
        {
            var sum = ((buying?.Package?.Sum(it => (it.Size ?? 0) * (it.Drink ?? 0) / ((it.Name == "ขวด") ? 1000 : 1))) ?? 0) * 12 / 100.0;
            return sum;
        }

        public double CalcWaterUsage(WaterUsage waterUsage)
        {
            var sum = CalcPlumping(waterUsage?.Plumbing)
            + CalcGroundWater(waterUsage?.GroundWater)
            + CalcPool(waterUsage?.Pool)
            + CalcIrrigation(waterUsage?.Irrigation)
            + CalcRain(waterUsage?.Rain)
            + CalcBuying(waterUsage?.Buying);
            return sum;
        }
    }
}