using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class TimpInvechire
    {
        [Key]
        public int TimpInvechireId { get; set; }  

        public string TimpInvechireDenumire { get; set; }


    }
}
