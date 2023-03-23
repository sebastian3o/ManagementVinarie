using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Servicii
{
    public class SalaDegustare
    {
        [Key]
        public int SalaDegustareId { get; set; }

        public string SalaDegustareDenumire{ get; set; }

        [Column(TypeName = "ntext")]
        public string SalaDegustareDescriere{ get; set; }

        public byte[] Foto { get; set; }

        public override string ToString()
        {
            return SalaDegustareId+" "+SalaDegustareDenumire;
        }



    }
}
