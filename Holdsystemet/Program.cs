namespace Holdsystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //opgave 1

            Studerende studerende = new Studerende() { Id = 1 , Navn = "Songül" , Adresse = "Taastrupgårdsvej 157" , CPRNummer = "0406006666" };

            //Console.WriteLine($"Studerendes Id: {studerende.Id}");
            //Console.WriteLine($"Studerendes Navn: {studerende.Navn}");
            //Console.WriteLine($"Studerendes Adresse: {studerende.Adresse}");
            //Console.WriteLine($"Studerendes CPRNummer: {studerende.CPRNummer}");
            Console.WriteLine(studerende);

            //opgave 2

            Hold hold = new Hold() { Type = "Datamatikker", Lokation = "Roskilde", Betegnelse = "A", Optagelsesår = 2023, Vinteroptagelse = false };

            //Console.WriteLine($"Holdets Type: {hold.Type}");
            //Console.WriteLine($"Holdets Lokation {hold.Lokation}");
            //Console.WriteLine($"Holdets Betegnelse {hold.Betegnelse}");
            //Console.WriteLine($"Holdets Optagelseså {hold.Optagelsesår}");
            //Console.WriteLine($"Holdets Vinteroptagelse {hold.Vinteroptagelse}");
            Console.WriteLine(hold);


            //opgave 3

            Console.WriteLine();
            Console.WriteLine("Add 1 Studerende");
            hold.AddStuderende(studerende);
            hold.SletStuderende(studerende.Id);

            try
            {
                Studerende studerendeFejl = new Studerende() { Id = 0, Navn = "Songül", Adresse = "Taastrupgårdsvej 157", CPRNummer = "0406006666" };
            } 
            catch (Exception ex) 
            { 
                Console.WriteLine("Fejl ved oprettelse af studerende:");   
                Console.WriteLine(ex.Message);
            }

            try
            {
                Studerende studerendeFejl = new Studerende() { Id = 2, Navn = "1", Adresse = "Taastrupgårdsvej 157", CPRNummer = "0406006666" };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved oprettelse af studerende:");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Studerende studerendeFejl = new Studerende() { Id = 3, Navn = "Songül", Adresse = "Taastrupgårdsvej 157", CPRNummer = "04060066" };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved oprettelse af studerende:");
                Console.WriteLine(ex.Message);
            }




        }
    }
}