﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Servicii
{
    public class Pachet
    {
        [Key]
        public int PachetId { get; set; }
        public string PachetDenumire { get; set; }
        public decimal DurataInOre { get; set; }
        public decimal Pret { get; set; }

        [Column(TypeName = "ntext")]
        public string Descriere { get; set; }

        public SalaDegustare SalaDegustare { get; set; }

        public override string ToString()
        {
            return PachetId+" "+PachetDenumire;
        }

    }
}
