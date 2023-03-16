using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class MaturitateStruguri
    {
        [Key]
        public int MaturitateStruguriId { set; get; }
        public string MaturitateStruguriNume { set; get; }

    }
}
