using ElectricityCalculationProject.Helpers;
using ElectricityCalculationProject.Interfaces;
using ElectricityCalculationProject.Models;
using ElectricityCalculationProject.Helpers;
using System.Reflection.Metadata.Ecma335;

namespace ElectricityCalculationProject.Services
{
    public class ElectricityDataRetrievalService : IElectricityDataRetrievalService
    {
        public async Task<List<ElectricityData>> GetElectricityData(IElectricityDataHandlerService dataHandler)
        {
            List<ElectricityData> data = await dataHandler.DownloadElectricityData(ElectricityDataUrlHelper.GetUrls());

            return data;
        }
    }
}
