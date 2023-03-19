using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class ContinutAlcool
    {
        [Key]
        public int ContinutAlcoolId { get; set; }  

        public string ContinutAlcoolDenumire { get; set; }


    }
}
