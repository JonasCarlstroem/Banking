using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banken
{
    class Bank
    {
        public struct Konto
        {
            public int kontoNr { get; set; }
            public string userName { get; set; }
            public string passWord { get; set; }
            public string forNamn { get; set; }
            public int saldo { get; set; }
        }

        public void nyttKonto(int kontoNr, string userName, string passWord, string forNamn, int saldo)
        {
            Konto konto = new Konto();
            konto.kontoNr = kontoNr;
            konto.userName = userName;
            konto.passWord = passWord;
            konto.forNamn = forNamn;
            konto.saldo = saldo;
        }
    }
}

