using System;
using System.Windows.Forms;
using System.IO;
namespace TekÇift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool asalSayıKontrol(double sayi)
        {
            int kontrol = 0;
            bool sonuc = false;
            if (sayi==1)
            {
                sayi = sayi + 3;
            }
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) { 
                    kontrol = 1;
                break;
                }
            }

            if (kontrol == 0)
                sonuc = true;
            else
                sonuc = false;

            return sonuc;
                
        }

        private bool mukemmelSayıKontrol(double sayi)
        {
            double toplam = 0;
            double kontrol = 0;
            double i;
            bool sonuc = false;
            for ( i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
                kontrol = 1;

            if (kontrol == 1)
                sonuc = true;
            else
                sonuc = false;

            return sonuc;

        }
       
        private void btnçalıştır_Click(object sender, EventArgs e)
        {

            notifyIcon1.Text = "Tek Çift Asal ve Mükemmel sayıların toplamı ve çarpımı";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "nesne yönelimli programlama ödevi";
            notifyIcon1.BalloonTipText = "Tek Çift Asal ve Mükemmel sayıların listelenmesi toplamı ve çarpımı";
            notifyIcon1.ShowBalloonTip(100);
            double başlangıc, bitiş, çifttoplam = 0,  tektoplam = 0,  asaltoplam = 0 ;
            double mukemmeltoplam = 0;
            double çiftçarpım = 1, tekçarpım = 1, asalçarpım = 1, mukemmelçarpım = 1,i;
           
            başlangıc = Convert.ToInt32(boxbaşlangıç.Text);
            bitiş = Convert.ToInt32(boxbitiş.Text);

            

            if (başlangıc <= 0 )
            {
                MessageBox.Show("HATA!!!  Başlangıç degeri 1'den küçüktür.");

            }
            else if(bitiş > 10000)
            {
                MessageBox.Show("HATA!!!  Bitiş degeri 10000'den büyüktür.");

            }
            else if (başlangıc > bitiş)
            {
                MessageBox.Show("HATA!!!  Başlangıç değeri bitiş değerinden büyüktür");
            }
            else
            {

                for ( i = başlangıc; i <= bitiş; i++)
                {
                    if (i % 2 == 0)
                    {
                        çifttoplam += i;
                        çiftçarpım *= i;
                        listçift.Items.Add(i.ToString());
                        
                    }
                    else
                    {
                        tektoplam += i;
                        tekçarpım *= i;
                        listtek.Items.Add(i.ToString());
                        
                    }

                    if (asalSayıKontrol(i) == true)
                    {
                        listasal.Items.Add(i.ToString());
                        asaltoplam += i;
                        asalçarpım *= i;
                    }

                    if (mukemmelSayıKontrol(i) == true)
                    {
                        listmuk.Items.Add(i.ToString());
                        mukemmeltoplam += i;
                        mukemmelçarpım *= i;
                    }
                }

                listtektoplam.Items.Add(tektoplam.ToString());
                listtekçarpım.Items.Add(tekçarpım.ToString());
                listçifttoplam.Items.Add(çifttoplam.ToString());
                listçiftçarpım.Items.Add(çiftçarpım.ToString());
                listasaltoplam.Items.Add(asaltoplam.ToString());
                listasalçarpım.Items.Add(asalçarpım.ToString());
                listmuktoplam.Items.Add(mukemmeltoplam.ToString());
                listmukçarpım.Items.Add(mukemmelçarpım.ToString());
            }


            if (listmuk.Items.Count == 0)
            {
                listmukçarpım.Clear();
            }
            if (listasal.Items.Count == 0)
            {
                listasalçarpım.Clear();
            }
            

            


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            boxbaşlangıç.Clear();
            boxbitiş.Clear();
            listtek.Items.Clear();
            listçift.Items.Clear();
            listasal.Items.Clear();
            listmuk.Items.Clear();
            listtektoplam.Items.Clear();
            listtekçarpım.Items.Clear();
            listçifttoplam.Items.Clear();
            listçiftçarpım.Items.Clear();
            listasaltoplam.Items.Clear();
            listasalçarpım.Items.Clear();
            listmuktoplam.Items.Clear();
            listmukçarpım.Items.Clear();
        }
    }
}
