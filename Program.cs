using System;

namespace MiniräknarenNya
{
    internal class Program
    { 
        // pedsuo kod

       // x Välkomnande meddelande
       // x En lista för att spara historik för räkningar
       // x Användaren matar in tal och matematiska operation
       // x OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
       // x Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
       // x Lägga resultat till listan
       // x Visa resultat
       // x Fråga användaren om den vill visa tidigare resultat.
       // x Visa tidigare resultat
       // x Fråga användaren om den vill avsluta eller fortsätta


        // Förbättringsområden som skulle kunna göras i koden. 
         // * Filtrering av historiken, det kan vara långt att man kan överväga implementering
        // av en funktion för att filtrera historiken baserat på användarens kriterier det vill säga
        // som datum eller en specfik operationstyp.
        // * Man skulle kunna även göra modulär kodning, där man använder sig-
        // av olika klasser och metoder för att följa principerna i modulär programering.
        // Detta för att underlätta koden för framtida ändringar och mera strukturerad. 
        // *En annan förbättringsområde är kanske att använda sig av While istället för if 
        // för upprepande inmatning av tal vid fel inmatning. 


        private static List<string> Historik = new List<string>();

        private static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green; // Ändra textfärgen till grön
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Välkommen till miniräknaren");

            string AnvandernsVal = "1";

            while (AnvandernsVal != "6")

            {
                skrivmeny();
                AnvandernsVal = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                switch (AnvandernsVal) 

                {
                    case "1":
                        Menyaddera(); // Addera 
                        break;

                        case "2":
                        Menysubtrahera(); // Subtrahera 
                        break;

                        case "3":
                        Menymultiplicera(); // Multiplicera
                        break;

                        case "4":
                        Menydividera(); //Dividera 
                        break;

                        case "5":
                        MenyHistorik(); //Visa historik
                        break;


                        case "6":
                        break; // Avsluta programmet


                        default:
                        Console.WriteLine("Du har gjort ett ogiltligt val, var vänlig försök igen");
                        break;


                }

                    if (AnvandernsVal != "6")
                    {
                        Console.WriteLine("vill du fortsätta ja/nej");

                        string fortsätta = Console.ReadLine().ToLower();

                         if (fortsätta != "ja")
                         {
                             AnvandernsVal = "6";
                    
                         }

                    }

                                                   
                                              }
        }

        private static void skrivmeny()   //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            Console.WriteLine("Välj en operation");
            Console.WriteLine("1. Addera");
            Console.WriteLine("2. Subtrahera");
            Console.WriteLine("3. Multiplicera");
            Console.WriteLine("4. Dividera");
            Console.WriteLine("5. Visa historik");
            Console.WriteLine("6. Avsluta programmet");


        }

        private static void Menyaddera() //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            // Skriver ut textinstruktion för användaren att skriva in det första talet
            Console.WriteLine("Skriv in det första talet");

            // Försöker att konvertera inmatningen från användaren till en double-variabel (tal1)
            // Om inmatningen inte kan tolkas som en double, meddelas användaren och programmet avslutas
            if (!double.TryParse(Console.ReadLine(), out double tal1))
            {
                Console.WriteLine("Ogiltig inmatning. Du måste skriva in ett tal.");
                return;
            }

            // Skriver ut textinstruktion för användaren att skriva in det andra talet
            Console.WriteLine("Skriv in det andra talet");

            // Försöker att konvertera inmatningen från användaren till en double-variabel (tal2)
            // Om inmatningen inte kan tolkas som en double, meddelas användaren och programmet avslutas
            if (!double.TryParse(Console.ReadLine(), out double tal2))
            {
                Console.WriteLine("Ogiltig inmatning. Du måste skriva in ett tal.");
                return;
            }

            // Utför addition av tal1 och tal2 och tilldelar resultatet till variabeln "resultat"
            double resultat = tal1 + tal2;

            // Skriver ut resultatet av additionen tillsammans med de ingående talen
            Console.WriteLine($"Resultat: {tal1} + {tal2} = {resultat}");

            // Lägger till en sträng som representerar beräkningen till en historik (förutsätts vara en lista eller liknande som heter "Historik")
            Historik.Add($" {tal1} + {tal2} = {resultat}");
        }


        private static void Menysubtrahera() //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            Console.WriteLine("Skriv in första talet");

            if (!double.TryParse(Console.ReadLine(), out double tal1))
            {

                Console.WriteLine("Ogitlig inmatning. Du måste skriva in ett ett tal.");
                return;
            }

            Console.WriteLine("Skriv in andra talet");

            if(!double.TryParse(Console.ReadLine(), out double tal2))

            {
                Console.WriteLine("Ogitlig inmatning. Du måste skriva in ett ett tal.");
                return;
            }
            double resultat = tal1 - tal2;
            Console.WriteLine($"Resultat: {tal1} - {tal2} = {resultat}");
            Historik.Add($" {tal1} - {tal2} = {resultat}");
 
        }

        private static void Menymultiplicera() //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            Console.WriteLine("skriv in första talet");

            if (!double.TryParse(Console.ReadLine(), out double tal1))
            {
                Console.WriteLine("Ogitlig inmatning. Du måste skriva in ett ett tal.");
                return;
            }

            Console.WriteLine("skriv in första talet");
            
            if(!double.TryParse(Console.ReadLine(), out double tal2))
            {
                Console.WriteLine("Ogitlig inmatning. Du måste skriva in ett ett tal.");
                return;
            }
                
            double resultat = tal1 * tal2;
            Console.WriteLine ($"Resultat: {tal1} * {tal2} = {resultat}");
            Historik.Add($" {tal1} * {tal2} = {resultat}");
                
        }

        public static void Menydividera() //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            Console.WriteLine("Skriv in första talet");
            if(!double.TryParse(Console.ReadLine(), out double tal1))
            {
                Console.WriteLine("Ogiltligt inmatning. Du måste skriva in ett tal.");
                return;

            }

            Console.WriteLine("Skriv in andra talet");
            if(!double.TryParse(Console.ReadLine(), out double tal2))
            {
                Console.WriteLine("Ogiltligt inmatning. Du måste skriva in ett tal.");
                return;
            }
           
            if(tal2 == 0)
            {
                Console.WriteLine("Du kan inte dela med 0.");

            }
            else
            {
                double resultat = tal1 / tal2;
                Console.WriteLine($"{tal1} / {tal2} = {resultat}");
                Historik.Add($" {tal1} / {tal2} = {resultat}");
            }

        }

        private static void MenyHistorik() //koden ligger utanför main metoden för mer organiserat och lättläsligt kod
        {
            Console.WriteLine("Historik");
            foreach (var operation in Historik)
            {
                Console.WriteLine(operation);
            }

        }

    }        
    

}