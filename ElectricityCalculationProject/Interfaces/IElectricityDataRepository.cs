using ElectricityCalculationProject.Models;

namespace ElectricityCalculationProject.Interfaces
{
    public interface IElectricityDataRepository
    {
        public bool WriteMultipleToDatabase(List<ElectricityData> electricityDataList);
    }
}
