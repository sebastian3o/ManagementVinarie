using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Servicii
{
    public class Rezervare
    {
        [Key]
        public int RezervareId { set; get; }

        public DateTime DataOraRezervare { set; get; }

        public Pachet Pachet { set; get; }

        public Client Client { set; get; }



    }
}
