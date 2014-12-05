using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    public class ServiceComptable
    {
        private List<ISalarie> lesSalaries;

        public ServiceComptable()
        {
            lesSalaries = new List<ISalarie>();
        }

        public void ajouteSalarie(ISalarie s)
        {
            lesSalaries.Add(s);
        }

        public ISalarie getSalarie(int i)
        {
            return lesSalaries[i];
        }
    }
}
