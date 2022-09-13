using ElectricityCalculationProject.Helpers;
using ElectricityCalculationProject.Models;
using ElectricityCalculationProject.Maps;
using System.Globalization;
using ElectricityCalculationProject.Interfaces;
using CsvHelper;

namespace ElectricityCalculationProject.Services
{
    public class ElectricityDataHandlerService : IElectricityDataHandlerService
    {
        public async Task<List<ElectricityData>> DownloadElectricityData(List<ElectricityDataUri> uriList)
        {
            List<ElectricityData> downloadedData = new();
            foreach (ElectricityDataUri uri in uriList)
            {
                downloadedData.AddRange(await FormatElectricityData(await FileDownloadHelper.DownloadFile(uri.Uri)));
            }

            return downloadedData;
        }

        public async Task<List<ElectricityData>> FormatElectricityData(byte[] unformattedData)
        {
            using (StreamReader stream = new StreamReader(new MemoryStream(unformattedData)))
            {
                using (var csv = new CsvReader(stream, System.Globalization.CultureInfo.CurrentCulture))
                {
                    csv.Context.RegisterClassMap<ElectricityDataMap>();
                    List<ElectricityData> records = csv.GetRecords<ElectricityData>().ToList();
                    return records;
                }
            }
        }
    }
}
