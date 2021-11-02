using System;
using System.Collections.Generic;
using System.Text;

namespace ProcvicovaniOOP
{
    public class Auto
    {
        private int naklad;
        public int Naklad { get => naklad; }
        public string Znacka { get; }
        public int Nosnost { get; }

        public Auto(string znacka, int nostnost)
        {
            Znacka = znacka;
            Nosnost = nostnost;
        }
        public int Nalozit(int naklad)
        {
            var misto = Nosnost - Naklad;
            if (misto < naklad)
            {
                this.naklad += misto;
                return misto;
            }
            else
            {
                this.naklad += naklad;
                return naklad;
            }
        }
        public int Vylozit (int naklad)
        {
            var misto = Nosnost - Naklad;
            if (misto < naklad)
            {
                this.naklad -= misto;
                return misto;
            }
            else
            {
                this.naklad -= naklad;
                return naklad;
            }
        }
    }
}
