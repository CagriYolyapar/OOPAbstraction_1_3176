using OOPAbstraction_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAbstraction_1
{
    public partial class Form1 : Form
    {

        /*
                    ---Abstraction Prensibi

        Abstraction prensibini de Inheritance yoksa uygulayamazsınız...

        Bizim bazı sınıflarımız kendilerinden instance alındıgı zaman RAM üzerinde anlamsız veri modelleri (nesneleri) olusturabilir...Mesela GeometrikSekil isimli bir sınıf özellikle bir nesne üretmek icin tasarlanmamıstır...Cünkü cok genel bir tanımdır...Bu sınıfın tek görevi daha spesifik olan class'lara miras vermektir...Biz eger GeometrikSekil sınıfından instance alıp nesne üretirsek RAM'de bu nesne cok genel ve anlamsız bir tanım olup bos yere yer kaplayacaktır(Aynı zaman Phantom Object sorunu karsımıza gelecektir) Bunu engellemek adına sınıftan bir instance alınmasının önüne gecilmesi gereklidir. Yani sınıf soyut bir model olarak sadece miras vermekle yükümlü olacaktır...

        Abstract sınıfların tek görevi miras vermektir...

        Bir sınıfın neden abstract olması gerektigini sadece o class miras vermekle görevlendirilecek ise anlarsınız(instance'i alınmayacaksa)


        Abstract Class:
        1. Adım => Class'ı olustur
        2. Adım => Class'ı Abstract olarak işaretle

        -------------------------------------

        Abstract Members(Ogeler)

        !!!Abstract ogeler sadece ve sadece Abstract Class'lar icerisinde olusturulabilir
         
         
         Implement : Görevleri tanımlandıkları yerde belli olmayan yapıların görevlerinin miras verildikleri yerde tanımlanmasıdır...

        Bizim bazı senaryolar karsısında metodun veya property'nin varsayılan görevini tanımlamak istemdigimiz veya bilmedigimiz durumlar olabilir...Bu ogelerin görevlerini sadece miras verilecek sınıflarda tanımlamak isteyebiliriz...Böylece biz de o ögenin baslangıc metodu/Property'si aracılıgı ile istedigimiz görevi tanımlayalım diye bu sefer ilgili ögeye abstract keyword'u koyarız...Abstract ogeler ilk olusturuldukları yerde bir yasam alanına sahip olamaz...Sadece görevlerinin belirtilecegi yerde yasam alanlarının acılıp o şekilde yazılmaları gerekir.Görevi belli olmayan bir yapının görevlerinin miras verildigi yerde belirtilmesine implement etmek denir...Görevleri belli olmayan yapıların görevleri, miras verildikleri yer Abstract bir class degilse kesinlikle belirtilmelidir...Yoksa syntax hatası alırsınız...Cünkü Abstract ögeler sadece Abstract class'lar icerisinde barındırılabilir...

        Field'lar abstract keyword'u alamazlar...

        abstract ogeler private keyword'u alamazlar...
         
         
         
         
         
         
         
         
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mudur m = new Mudur();

            Egitmen egt = new Egitmen("Cagri");

           
        }
    }
}
