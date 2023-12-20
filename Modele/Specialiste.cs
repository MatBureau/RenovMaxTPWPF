using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenovMaxTP.Modele
{
    public class Specialiste
    {
        public int ID { get; set; }
        public string NumeroSiret { get; set; }
        public string RaisonSociale { get; set; }
        public int AnneeFondation { get; set; }
        public bool EstAutoEntrepreneur { get; set; }
        public Metier Metier { get; set; }

        public Specialiste() { }
    }
}
