using LompogaLibrary.Historisable;
using System;
using System.Collections.Generic;
using System.Text;

namespace LompogaLibrary.Administation
{
    public class Droits : Horodatage
    {
        public int ID_droit { get; set; }
        public string LibelleDroit { get; set; }

        public bool EtatDroit { get; set; } = false;

        public ICollection<Habilitations> habilitations { get; set; }
    }
}
