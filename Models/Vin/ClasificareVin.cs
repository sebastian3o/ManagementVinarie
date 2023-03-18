using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class ClasificareVin
    {
        [Key]
        public int ClasificareVinId { set; get; }

        public Culoare Culoare { set; get; }
        public CalitateStruguri CalitateStruguri{set;get;}
    
        public CantitateZahar CantitateZahar { set; get; }

        public ContinutAlcool ContinutAlcool { set; get; }
    }

}
