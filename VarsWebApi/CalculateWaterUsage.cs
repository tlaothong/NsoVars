using System.Linq;
using VarsWebApi.Models;

namespace VarsWebApi
{
    public class CalculateWaterUsage
    {
        public double CalcPlumping(Plumbing plumbing)
        {
            var sum = (((plumbing?.MWA?.Doing ?? false) && (plumbing?.MWA?.PlumbingUsage?.WaterQuantity == WaterQuantity.CubicMeterPerMonth) ?
            ((plumbing?.MWA?.PlumbingUsage?.CubicMeterPerMonth ?? 0) * (plumbing?.WaterActivityMWA?.Drink ?? 0)) : 0)
            + ((plumbing?.PWA?.Doing ?? false) && (plumbing?.PWA?.PlumbingUsage?.WaterQuantity == WaterQuantity.CubicMeterPerMonth) ?
            ((plumbing?.PWA?.PlumbingUsage?.CubicMeterPerMonth ?? 0) * (plumbing?.WaterActivityPWA?.Drink ?? 0)) : 0)
            + ((plumbing?.Other?.Doing ?? false) && (plumbing?.Other?.PlumbingUsage?.WaterQuantity == WaterQuantity.CubicMeterPerMonth) ?
            ((plumbing?.Other?.PlumbingUsage?.CubicMeterPerMonth ?? 0) * (plumbing?.WaterActivityOther?.Drink ?? 0)) : 0))
            * 12 / 100.0;
            return sum;
        }

        public double CalcGroundWater(GroundWater groundWater)
        {
            var sum = (((groundWater?.PrivateGroundWater?.Doing ?? false) ?
            (groundWater?.PrivateGroundWater?.WaterResources?.Sum(it => (it.UsageType?.GroundWaterQuantity == GroundWaterQuantity.CubicMeterPerMonth) ? (it.UsageType?.UsageCubicMeters ?? 0) * (it?.WaterActivities?.Drink ?? 0) : 0) ?? 0) : 0)
            + ((groundWater?.PublicGroundWater?.Doing ?? false) ?
            (groundWater?.PublicGroundWater?.WaterResources?.Sum(it => (it.HasCubicMeterPerMonth ?? false) ? (it.CubicMeterPerMonth ?? 0) * (it.WaterActivities?.Drink ?? 0) : 0) ?? 0) : 0))
            * 12 / 100.0;
            return sum;
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