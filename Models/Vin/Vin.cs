using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class Vin
    {
        [Key]
        public int VinId { set; get; }
        public string VinDenumire { set; get; }
        public int Cantitate { set; get; }

        [Column(TypeName = "ntext")]
        public string Descriere { set; get; }

        public ClasificareVin ClasificareVin{get;set;}

        public DateOnly DataProducerii { get; set; }





    }
}
