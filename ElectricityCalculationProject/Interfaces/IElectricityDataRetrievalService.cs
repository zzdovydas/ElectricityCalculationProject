using ElectricityCalculationProject.Models;

namespace ElectricityCalculationProject.Interfaces
{
    public interface IElectricityDataRetrievalService
    {
        public Task<List<ElectricityData>> GetElectricityData(IElectricityDataHandlerService dataHandler);
    }
}
