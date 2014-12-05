using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommerciaux
{
    class EnumereCommerciaux : IEnumerator
    {
        private ServiceCommercial leService;
        private int index;

        public EnumereCommerciaux(ServiceCommercial leService)
        {
            this.leService = leService;
            this.index = -1;
        }
        object IEnumerator.Current
        {
            get { return this.leService.getCommercial(this.index); }
        }

        bool IEnumerator.MoveNext()
        {
            this.index++;
            return this.index < this.leService.nbCommerciaux();
        }

        void IEnumerator.Reset()
        {
            index = -1;
        }
    }
}
