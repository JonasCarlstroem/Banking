using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kontoNr = new int[10];
            //int kontoNummer;
            //string konto = "";
            bool loggedIn = false;
            string usrName;
            string passWrd;
            string forNamn;
            Random rnd = new Random();
            Operations operations = new Operations();
            while (true)
            {
                while (loggedIn == false)
                {
                    Console.WriteLine("Välkommen till banken!");
                    Console.WriteLine("1. Logga in");
                    Console.WriteLine("2. Skapa nytt konto");
                    Console.WriteLine("3. FAQ");
                    string val = Console.ReadLine();
                    int oVal = Convert.ToInt32(val);
                    switch (oVal)
                    {
                        case 1:
                            Console.WriteLine("Logga in;");
                            Console.Write("Användarnamn: ");
                            usrName = Console.ReadLine();
                            Console.Write("Lösenord: ");
                            passWrd = Console.ReadLine();
                            try
                            {
                                operations.Login(usrName, passWrd);
                                loggedIn = operations.loggedIn;
                            }
                            catch
                            {
                                break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Skapa nytt konto; ");
                            /*string usrName = Console.ReadLine();
                            for (int i = 0; i < 8; i++)
                            {
                                kontoNr[i] = rnd.Next(1, 9);
                                Thread.Sleep(500);
                                Console.Write(kontoNr[i]);
                                konto += kontoNr[i].ToString();
                            }
                            //kontoNummer = Convert.ToInt32(konto);
                            //Console.WriteLine("\r\nDitt kontonummer är: " + kontoNummer);
                            Console.ReadLine();
                            */
                            Console.Write("Användarnamn: ");
                            usrName = Console.ReadLine();
                            Console.Write("Lösenord: ");
                            passWrd = Console.ReadLine();
                            Console.Write("Förnamn: ");
                            forNamn = Console.ReadLine();
                            operations.CreateAccount(usrName, passWrd);
                            break;

                        case 3:
                            break;



                    }
                }
                while (loggedIn == true)
                {
                    Console.WriteLine(" bank");
                    Console.WriteLine("Kontobelopp: ");
                    Console.WriteLine("Vad vill du göra?");
                    Console.WriteLine("1. Ta ut pengar.");
                    Console.WriteLine("2. Sätta in pengar.");
                    Console.WriteLine("3. Logga ut.");
                    string val = Console.ReadLine();
                    int oVal = Convert.ToInt32(val);
                    switch (oVal)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            loggedIn = false;
                            break;
                    }
                }
            }
        }
    }
}
