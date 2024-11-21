using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Models
{
    public class Egitmen : Personel
    {
        public Egitmen(string isim) :base(isim) //BUradaki base() ifadesi Personel sınıfının constructor'ini belirler
        {

        }

        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Ders Anlat");
        }
    }
}
