using System.Collections.Generic;
using System.Linq;
using VarsWebApi.Models;

namespace VarsWebApi
{
    public class CalculateWaterUsage
    {
        public double CalcWaterUsage(WaterUsageRate waterUsageRate)
        {
            var waterUsage = waterUsageRate.Unit.WaterUsage;
            var buildingType = waterUsageRate.BuildingType;
            var waterServices = waterUsageRate.WaterServices;
            var sum = CalcPlumping(waterUsage?.Plumbing, buildingType, waterServices)
            + CalcGroundWater(waterUsage?.GroundWater, buildingType)
            + CalcPool(waterUsage?.Pool)
            + CalcRiver(waterUsage?.River)
            + CalcIrrigation(waterUsage?.Irrigation)
            + CalcRain(waterUsage?.Rain)
            + CalcBuying(waterUsage?.Buying);
            return sum;
        }

        public double CalcPlumping(Plumbing plumbing, BuildingType buildingType, List<DetailOrgWaterSupply> waterServices)
        {
            var sum = CalcMWA(plumbing, buildingType) + CalcPWA(plumbing, buildingType) + CalcOther(plumbing, waterServices);
            return sum;
        }

        public double CalcMWA(Plumbing plumbing, BuildingType buildingType)
        {
            if (plumbing?.MWA?.Doing == true)
            {
                if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.MWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityMWA.Drink * 12 / 100.0;
                }
                else if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    return plumbing.MWA.PlumbingUsage.WaterBill.Value / WaterPricePlumping(buildingType, "MWA");
                }
                return 0;
            }
            return 0;
        }

        public double CalcPWA(Plumbing plumbing, BuildingType buildingType)
        {
            if (plumbing?.PWA?.Doing == true)
            {
                if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.PWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityPWA.Drink * 12 / 100.0;
                }
                else if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    return plumbing.PWA.PlumbingUsage.WaterBill.Value / WaterPricePlumping(buildingType, "PWA");
                }
                return 0;
            }
            return 0;
        }

        public double CalcOther(Plumbing plumbing, List<DetailOrgWaterSupply> waterServices)
        {
            if (plumbing?.Other?.Doing == true)
            {
                if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                {
                    return plumbing.Other.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityOther.Drink * 12 / 100.0;
                }
                else if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                {
                    return (plumbing.Other.PlumbingUsage.WaterBill.Value - waterServices.Average(it => it.MeterRentalFee.Value)) / waterServices.Average(it => it.PlumbingPrice.Value);
                }
                return 0;
            }
            return 0;
        }

        public double CalcGroundWater(GroundWater groundWater, BuildingType buildingType)
        {
            var sum = CalcPrivate(groundWater?.PrivateGroundWater, buildingType) + CalcPublic(groundWater?.PublicGroundWater);
            return sum;
        }

        public double CalcPrivate(PrivateGroundWater privateGroundWater, BuildingType buildingType)
        {
            if (privateGroundWater?.Doing == true)
            {
                return privateGroundWater.WaterResourceCount > 0 ? privateGroundWater.WaterResources.Sum(it =>
                   {
                       if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.CubicMeterPerMonth)
                       {
                           return it.UsageType.UsageCubicMeters.Value * it.WaterActivities.Drink * 12 / 100.0;
                       }
                       else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.WaterBill)
                       {
                           return it.UsageType.WaterBill.Value / WaterPrice(it.Location, buildingType);
                       }
                       else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.Unknown && it.HasPump.Value)
                       {
                           return CalcPumps(it.Pumps, true);
                       }
                       return 0;
                   }) : 0;
            }
            return 0;
        }

        public double CalcPublic(PublicGroundWater publicGroundWater)
        {
            if (publicGroundWater?.Doing == true)
            {
                return publicGroundWater.WaterResourceCount > 0 ? publicGroundWater.WaterResources.Sum(it =>
                   {
                       if (it.HasCubicMeterPerMonth == true)
                       {
                           return it.CubicMeterPerMonth.Value * it.WaterActivities.Drink * 12 / 100.0;
                       }
                       else if (it.HasPump == true)
                       {
                           return CalcPumps(it.Pumps, true);
                       }
                       return 0;
                   }) : 0;
            }
            return 0;
        }

        public double CalcRiver(River river)
        {
            return (river?.HasPump == true && river?.PumpCount > 0) ? CalcPumps(river.Pumps, false) : 0;
        }

        public double CalcPool(Pool pool)
        {
            if (pool?.Doing == true)
            {
                return pool.WaterResourceCount > 0 ? pool.WaterResources.Sum(it =>
                   {
                       if (it.HasCubicMeterPerMonth == true)
                       {
                           return it.CubicMeterPerMonth.Value * it.WaterActivities.Drink * 12 / 100.0;
                       }
                       else if (it.HasPump == true)
                       {
                           return CalcPumps(it.Pumps, false);
                       }
                       return 0;
                   }) : 0;
            }
            return 0;
        }

        public double CalcIrrigation(Irrigation irrigation)
        {
            if (irrigation?.HasCubicMeterPerMonth == true)
            {
                return irrigation.CubicMeterPerMonth.Value * irrigation.WaterActivities.Drink * 12 / 100.0;
            }
            else if (irrigation?.HasPump == true)
            {
                return CalcPumps(irrigation.Pumps, false);
            }
            return 0;
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

        public double CalcPumps(List<Pump> pumps, bool isGround)
        {
            return pumps.Sum(it =>
            {
                return (it.PumpAuto.Value == false) ? it.HoursPerPump.Value * it.NumberOfPumpsPerYear.Value * CalcPumpRate(it, isGround) / 12 : 0;
            });
        }

        public double CalcPumpRate(Pump pump, bool isGround)
        {
            if (pump.HasPumpRate == true)
            {
                return pump.PumpRate.Value;
            }
            else
            {
                var pumpcal = new PumpCal();
                var listPump = isGround ? pumpcal.listPumpGroundWater : pumpcal.listSurfaceWater;
                var pumpRate = listPump.FirstOrDefault(it => it.EnergyFromPump == pump.EnergySource
                    && it.PumpType == pump.PumpType && it.Power == pump.HorsePower
                    && it.SuctionPipeSize == pump.SuctionPipeSize && it.PipelineSize == pump.PipelineSize).PumpRate;
                return pumpRate;
            }
        }

        public double WaterPricePlumping(BuildingType buildingType, string type)
        {
            switch (type)
            {
                case "MWA": return isInBuildingType(buildingType) ? 10.5 : 13;
                case "PWA": return isInBuildingType(buildingType) ? 16.6 : 26;
                default: return 0;
            }
        }

        public double WaterPrice(Location location, BuildingType buildingType)
        {
            return isIn7Areas(location) ? isInBuildingType(buildingType) ? 8.5 : 13 : 3.5;
        }

        public bool isIn7Areas(Location location)
        {
            var areas = new List<string>
            {
                "กรุงเทพมหานคร", "พระนครศรีอยุธยา", "ปทุมธานี", "สมุทรสาคร", "สมุทรปราการ", "นนทบุรี", "นครปฐม"
            };
            return areas.Any(it => it == location.Province);
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
    }
}