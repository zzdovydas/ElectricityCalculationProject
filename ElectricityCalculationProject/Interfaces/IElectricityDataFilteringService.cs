using ElectricityCalculationProject.Models;

namespace ElectricityCalculationProject.Interfaces
{
    public interface IElectricityDataFilteringService
    {
        public Task<List<ElectricityData>> FilterByBuildingType(List<ElectricityData> data, string buildingType);
        public Task<List<ElectricityData>> FilterByElectricityConsumptionLess(List<ElectricityData> data, decimal buildingType);
    }
}
