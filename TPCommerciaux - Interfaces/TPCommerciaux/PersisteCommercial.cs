using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TPCommerciaux
{
    class PersisteCommercial
    {

        //public static void sauve(object objet, String chemin)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    FileStream flux = null;
        //    try
        //    {
        //        flux = new FileStream(chemin, FileMode.Create, FileAccess.Write);
        //        formatter.Serialize(flux, objet);
        //        flux.Flush();
        //    }
        //    catch { }
        //    finally
        //    {
        //        if (flux != null)
        //            flux.Close();
        //    }
        //}
        public void sauve(ServiceCommercial unS, string unNom)
        {
            FileStream fichier = new FileStream(unNom, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fichier, unS);
            fichier.Close();
        }


        //public static Service charge(String chemin)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    FileStream flux = null;
        //    try
        //    {
        //        flux = new FileStream(chemin, FileMode.Open, FileAccess.Read);

        //        return (Service)formatter.Deserialize(flux);
        //    }
        //    catch
        //    {
        //        return default(Service);
        //    }
        //    finally
        //    {
        //        if (flux != null)
        //            flux.Close();
        //    }
        //}
        public static ServiceCommercial charge(string unNom)
        {
            FileStream fichier = new FileStream(unNom, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            return (ServiceCommercial)bf.Deserialize(fichier);
            fichier.Close();
        } 
    }
}
