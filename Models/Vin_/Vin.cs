using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin_
{
    public class Vin
    {
        [Key]
        public int VinId { set; get; }
        public string VinDenumire { set; get; }
        public int Cantitate { set; get; }

        
        public byte[] ImagineVin { set; get; }

        public Clasificare Clasificare{get;set;}

        public DateOnly DataProducerii { get; set; }





    }
}
