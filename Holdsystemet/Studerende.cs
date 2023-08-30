using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holdsystemet
{
    public class Studerende
    {
        private int id;
        private string navn;
        private string adresse;
        private string cprnummer;

        public int Id {
            get { return id; }
            set {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    //Console.WriteLine("ID skal være større end 0");
                    
                    throw new Exception("ID skal være større end 0");
                }


            } 
        }
        

        public string Navn {
            get { return navn; }
            set {
                if ( value.Length > 1)
                {
                    navn = value;
                }
                else
                {
                    // Console.WriteLine("Navn skal være mindst 2 tegn langt");

                    throw new Exception("Navn skal være mindst 2 tegn langt");
                }
            }
        }
        public string Adresse { get; set;}


        public string CPRNummer {
            get { return adresse; }
            set
            {
                if (value.Length == 10)
                {
                    adresse = value;
                }
                else
                {
                    //Console.WriteLine("CPRNummer skal være præcis 10 tegn langt");

                    throw new Exception("CPRNummer skal være præcis 10 tegn langt");
                }

                
            }  
        }


        public override string ToString()
        {
            return $"Studerendes: {Id}, Studerendes: {Navn}, Studerendes: {Adresse}, Studerendes: {CPRNummer}";
        }

       
    }
}
