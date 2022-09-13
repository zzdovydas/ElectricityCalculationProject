using ElectricityCalculationProject.Models;

namespace ElectricityCalculationProject.Helpers
{
    public static class ElectricityDataUrlHelper
    {
        public static List<ElectricityDataUri> GetUrls()
        {
            List<ElectricityDataUri> uriList = new List<ElectricityDataUri>();
            uriList.Add(new ElectricityDataUri() { Date = "2022-05", Uri = "http://data.gov.lt/dataset/1975/download/10766/2022-05.csv" });
            uriList.Add(new ElectricityDataUri() { Date = "2022-04", Uri = "http://data.gov.lt/dataset/1975/download/10765/2022-04.csv" });
            return uriList;
        }
    }
}
