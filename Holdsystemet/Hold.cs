using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Holdsystemet
{
    public class Hold
    {
        private string type;
        private string lokation;
        private string betegnelse;
        private int optagelsesår;
        private bool vinteroptagelse;

        public string Type { get; set; }
        public string Lokation { get; set; }
        public string Betegnelse { get; set; }
        public int Optagelsesår { get; set; }
        public bool Vinteroptagelse { get; set; }


        Dictionary<int, Studerende> _studerende = new Dictionary<int, Studerende>();

        Studerende studerende = new Studerende();
        int studerendeId = 01;

        public void AddStuderende(Studerende studerende)
        {
            _studerende.Add(studerende.Id, studerende);
        }

        public void SletStuderende(int id)
        {
            _studerende.Remove(id);  
        }




        public override string ToString()
        {
            return $"Type: {Type}, Lokation: {Lokation}, Betegnelse: {Betegnelse}, Optagelsesår: {optagelsesår}, Vinteroptagelse: {Vinteroptagelse}";
        }
    }
}
