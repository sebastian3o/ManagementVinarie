using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementVinarie.Models.Vin
{
    public class ClasificareVin
    {
        public int ClasificareVinId { set; get; }

        public Culoare Culoare { set; get; }
        public MaturitateStruguri MaturitateStruguri{set;get;}
    
        public CantitateZahar CantitateZahar { set; get; }

        public TimpInvechere TimpInvechere { set; get; }
    }

}
