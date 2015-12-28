using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManager
{
    public static class Vfunc
    {
        public enum polaKlient { imie = 0, nazwisko = 1, telefon = 2, kod_pocztowy = 3, adres = 4, nazwafirmy = 5, NIP = 6, email = 7, zwrot = 8 };
        public static bool[] validateAddKlientValues(klient klient)
        {
            bool[] tab = new bool[9];
            for(int i=0 ;i<9;i++)
            tab[i]=true;
            if (klient.imie.Length > 20)
                tab[(int)polaKlient.imie] = false;
            if (klient.nazwisko.Length > 30)
                tab[(int)polaKlient.nazwisko] = false;
            if (klient.telefon.Length > 20)
                tab[(int)polaKlient.telefon] = false;
            if (klient.kod_pocztowy.Length > 6)
                tab[(int)polaKlient.kod_pocztowy] = false;
            if (klient.adres.Length > 30)
                tab[(int)polaKlient.adres] = false;
            if (klient.nazwa_firmy.Length > 40)
                tab[(int)polaKlient.nazwafirmy] = false;
            if(klient.nip.Length>30)
                tab[(int)polaKlient.NIP]=false;
            if(klient.email.Length>30)
                tab[(int)polaKlient.email]=false;
          //  if (klient.zwrot.Length > 10)
              //  tab[(int)polaKlient.zwrot] = false;

            return tab;                        
            }
    }
}
