using ElectricityCalculationProject.Models;

namespace ElectricityCalculationProject.Interfaces
{
    public interface IElectricityDataHandlerService
    {
        public Task<List<ElectricityData>> DownloadElectricityData(List<ElectricityDataUri> uriList);
        public Task<List<ElectricityData>> FormatElectricityData(byte[] unformattedData);
    }
}
