using ElectricityCalculationProject.Contexts;
using ElectricityCalculationProject.Interfaces;
using ElectricityCalculationProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ElectricityCalculationProject.Repositories
{
    public class ElectricityDataRepository : IElectricityDataRepository
    {
        private readonly DataContext _dataContext;
        public ElectricityDataRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool WriteMultipleToDatabase(List<ElectricityData> electricityDataList)
        {
            _dataContext.ElectricityData.AddRange(electricityDataList);
            _dataContext.SaveChanges();

            return true;
        }
    }
}
