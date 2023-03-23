using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin_
{
    public class CantitateZahar
    {
        [Key]
        public int CantitateZaharId { set; get; }
       public string CantitateZaharDenumire { set; get; }

        public override string ToString()
        {
            return CantitateZaharId + " " + CantitateZaharDenumire;
        }



    }
}
