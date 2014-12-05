using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommerciaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial c;
            c = new Commercial("Dupond", "Jean", 'A', 8);
            NoteFrais f = new NoteTransport(new DateTime(2014, 11, 12), c, 250);
            NoteFrais f1 = new NoteRepas(new DateTime(2014, 11, 15), c, 35);
            NoteFrais f2 = new NoteNuitee(new DateTime(2014, 11, 17), c, 46, 2);
            Console.WriteLine(f2.ToString());
      
            Console.ReadLine();
            


            // test des constructeurs des classes dérivées (voir question n°6)
            NoteNuitee nn1 = new NoteNuitee(new DateTime(2014, 11, 12), c, 12, 6);
            NoteRepas nr1 = new NoteRepas(new DateTime(2014, 11, 12), c, 18);
            NoteTransport nt1 = new NoteTransport(new DateTime(2014, 11, 12), c, 189);


        }
    }
}
