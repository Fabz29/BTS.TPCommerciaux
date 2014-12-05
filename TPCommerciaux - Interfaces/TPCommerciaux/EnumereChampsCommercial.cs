using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCommerciaux;

namespace TPCommerciaux
{
     class EnumereChampsCommercial : IEnumerator
    {
        public EnumereChampsCommercial(Commercial leCommercial)
        {
            this.leCommercial = leCommercial;
            this.index = -1;
        }
        public object Current
        {
            get {
                object o=null ;
                switch (this.index)
                {
                    case 0:
                        {
                            o = this.leCommercial.Nom; break;
                        }
                    case 1:
                        {
                            o = this.leCommercial.Prenom; break;
                        }
                    case 2 :
                        {
                            o = this.leCommercial.Categorie; break;
                        }
                    case 3:
                        {
                            o = this.leCommercial.PuissanceVoiture; break;
                        }
                    case 4:
                        {
                            o = this.leCommercial.NumSecu; break;
                        }
                    case 5:
                        {
                            o = this.leCommercial.Anciennete; break;
                        }
                }
                return o;
              }
        }
        public bool MoveNext()
        {
            this.index++;
            return this.index<6;
        }
        public void Reset()
        {
            this.index = -1;
        }
        private Commercial leCommercial;
        private int index;
    }

}
