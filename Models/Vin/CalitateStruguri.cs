using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class CalitateStruguri
    {
        [Key]
        public int CalitateStruguriId { set; get; }
        public string CalitateStruguriNume { set; get; }

    }
}
