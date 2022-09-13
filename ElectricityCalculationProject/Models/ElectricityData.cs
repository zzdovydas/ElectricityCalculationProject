using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricityCalculationProject.Models
{
    public class ElectricityData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string OBJ_NUMERIS { get; set; }
        public string TINKLAS { get; set; }
        public string OBT_PAVADINIMAS { get; set; }
        public string OBJ_GV_TIPAS { get; set; }
        public string PL_T { get; set; }
        public decimal? P_plus { get; set; }
        public decimal? P_minus { get; set; }
        public decimal? P_Diff { get { return P_minus - P_plus; } set => P_Diff = value; }
    }
}
