using ElectricityCalculationProject.Interfaces;
using ElectricityCalculationProject.Helpers;
using ElectricityCalculationProject.Models;
using ElectricityCalculationProject.Maps;
using System.Globalization;

namespace ElectricityCalculationProject.Services
{
    public class ElectricityDataFilteringService : IElectricityDataFilteringService
    {
        public async Task<List<ElectricityData>> FilterByBuildingType(List<ElectricityData> data, string buildingType)
        {
            return data.Where(x => x.OBT_PAVADINIMAS == buildingType).ToList();
        }
        public async Task<List<ElectricityData>> FilterByElectricityConsumptionLess(List<ElectricityData> data, decimal consumption)
        {
            return data.Where(x => x.P_plus < consumption).ToList();
        }
    }
}
