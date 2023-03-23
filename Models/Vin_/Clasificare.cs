using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin_
{
    public class Clasificare
    {
        [Key]
        public int ClasificareId { set; get; }

        public Culoare Culoare { set; get; }
        public CalitateStruguri CalitateStruguri{set;get;}
    
        public CantitateZahar CantitateZahar { set; get; }

        public ContinutAlcool ContinutAlcool { set; get; }

        public override string ToString()
        {
            return ClasificareId.ToString();
        }
    }

}
