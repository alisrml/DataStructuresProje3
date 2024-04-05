using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class UM_ALANI
    {
        public string alanAdi;
        public List<string> ilAdlari;
        public string ilanYili;
        public List<string> kelimeler;

        public UM_ALANI(string alanAdi, List<string> ilAdlari, string ilanYili,List<string> kelimeler)
        {
            this.alanAdi = alanAdi;
            this.ilAdlari = ilAdlari;
            this.ilanYili = ilanYili;
            this.kelimeler = kelimeler;
        }

        public override string ToString()
        {   
            string kelime = "";
            kelime += "Alan Adı: " + this.alanAdi+"\n";
            foreach(string il in this.ilAdlari)
            {
                kelime += il + " ";
            }
            kelime += "\nİlan yılı: " + this.ilanYili + "\nParagraf: ";
            foreach( string eleman in this.kelimeler)
            {
                kelime += eleman + " ";
            }
            return kelime;
        }
    }
}
