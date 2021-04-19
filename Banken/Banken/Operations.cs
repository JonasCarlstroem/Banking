using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Banken
{
    class Operations
    {
        public bool loggedIn = false;
        public void WithDraw(int amnt)
        {

        }

        public void Deposit(string usrName,int amnt)
        {
            try
            {
                using (StreamWriter deposit = new StreamWriter(usrName + ".txt"))
                {

                }
            }
            catch
            {

            }
            
        }

        public void CreateAccount(string usrName, string passWrd)
        {
            try
            {
                string fileName = usrName + ".txt";
                using (StreamWriter createAcc = new StreamWriter(fileName))
                {
                    createAcc.WriteLine("#\r\n" + passWrd);
                    createAcc.Close();
                }
            }
            catch
            {
                Console.WriteLine("Misslyckades att skapa konto.");
                Task.Delay(1500);
            }
        }
        public bool kontoExist(string usrName)
        {
            try
            {
                using (StreamReader ifKontoExist = new StreamReader(usrName + ".txt"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public double getSaldo(string usrName)
        {
            try
            {
                StreamReader readSaldo = new StreamReader(usrName + ".txt");
                string saldoRead = readSaldo.ReadLine();
                while (!saldoRead.StartsWith("saldo:"))
                {
                    saldoRead = readSaldo.ReadLine();
                    if (saldoRead.StartsWith("saldo:"))
                    {
                        saldoRead = readSaldo.ReadLine();
                        double returnValue = Convert.ToDouble(saldoRead);
                        return returnValue;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        public void Login(string userName, string passWrd)
        {
            try
            {
                StreamReader login = new StreamReader(userName + ".txt");
                string pwdCheck = login.ReadLine();
                while (pwdCheck != null)
                {
                    if (pwdCheck.StartsWith("#"))
                    {
                        pwdCheck = login.ReadLine();
                        if (pwdCheck == passWrd)
                        {
                            Console.WriteLine("Välkommen: " + userName);
                            loggedIn = true;
                            Thread.Sleep(1500);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fel lösenord.");
                            break;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Användare finns ej.");
                Thread.Sleep(1000);
            }
        }
    }
}
