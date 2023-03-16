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
        public int SalaDegustareId;
        public string SalaDegustareDenumire;

        [Column(TypeName = "ntext")]
        public string SalaDegustareDescriere;

        public byte[] Foto;

        

    }
}
