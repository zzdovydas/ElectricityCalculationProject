using ElectricityCalculationProject.Models;
using CsvHelper.Configuration;

namespace ElectricityCalculationProject.Maps
{
    public class ElectricityDataMap : ClassMap<ElectricityData>
    {
        public ElectricityDataMap()
        {
            Map(m => m.OBT_PAVADINIMAS);
            Map(m => m.OBJ_GV_TIPAS);
            Map(m => m.OBJ_NUMERIS);
            Map(m => m.TINKLAS);
            Map(m => m.PL_T);
            Map(m => m.P_minus).Name("P-");
            Map(m => m.P_plus).Name("P+");
        }
    }
}
