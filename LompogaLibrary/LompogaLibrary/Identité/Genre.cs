using System;
using System.Collections.Generic;
using System.Text;

namespace LompogaLibrary.Identité
{
    [Flags]
    public enum Civilité
    {
        Monsieur =1,
        Madame = 2,
        Mademoiselle =3
    }
    [Flags]
    public enum EtapeTaxe
    {
        Recouvrement= 1,
        Recouvré = 2
    }
    [Flags]
    public enum SituationContribuable
    {
        A_jour=1,
        En_retard=2,
        En_Arrêt = 3
    }
}
