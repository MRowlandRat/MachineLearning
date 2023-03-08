using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace MachineLearning.Models
{
    public class D2Guns
    {

      public string Gun_name { get; set; }
        public string Gun_archtype { get; set; }
        public string Source { get; set; }
        public string Element { get; set; }
        public float Gun_Rof { get; set; }
        public string Weapon_type { get; set; }


        public D2Guns(string Gun_name, string Gun_archtype, string Source, string Element, float Gun_Rof, string Weapon_type )
        {
            Gun_name = Gun_name;
            Gun_archtype = Gun_archtype;
            Source = Source;
            Element = Element;
            Gun_Rof = Gun_Rof;
            Weapon_type = Weapon_type;
        }
       public D2Guns(){ 
        }
    }
}
