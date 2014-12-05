using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public interface ISalarie
    {
        int Anciennete { get; }

        string NumSecu { get; }

        string Nom { get; }

        string Prenom { get; }
    }
}
