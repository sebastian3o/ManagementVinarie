using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class Culoare
    {
        [Key]
        public int CuloareId { set; get; }
        public string CuloareDenumire { set; get; }

    }
}
