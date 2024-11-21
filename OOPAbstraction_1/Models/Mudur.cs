using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Models
{
    public class Mudur : Personel
    {
        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Sube yonet");
        }
    }
}
