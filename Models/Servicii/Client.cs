﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManagementVinarie.Models.Servicii
{
    public class Client
    {
        [Key]
        public int ClientId { set; get; }
        public string Nume { set; get; }
        public string Prenume { set; get; }

        public DateOnly DataNasterii { set; get;}

        public string Gen { set; get; }
        public string Telefon { set; get; }

        public string Email { set; get; }
    }
}
