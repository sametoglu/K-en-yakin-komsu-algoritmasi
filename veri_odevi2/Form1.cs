using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_odevi2
{
    public partial class Form1 : Form
    {
        double[] E = new double[10];
        double[] K = new double[10];



        int k;

        public void sıralıatama(double[] dizi) {

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        double gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }

        
        }

        public void diziyazdir(double[] dizi)
        {

            for (int i = 0; i <= 9; i++)
            {
                MessageBox.Show(dizi[i].ToString());
            }

        }

        public void hesap(int k)
        {

            double ue = 0;
            double uk = 0;

            


            for (int i = 0; i < k; i++)
            {

                

                ue += E[i];
                uk += K[i];

                

            }
                ue = ue / k;
                uk = uk / k;
               

                if (ue > uk)
                {
                    MessageBox.Show("K sınıfına yakın");
                    
                }

                else
                {
                    MessageBox.Show("E sınıfına yakın");
                   
                }



            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *
             * noktanın x ve y si;
             * k degeri;
             * label1x,label1y hepsi icin;
             * sqrt((label1x)*(label1x)+(label1y)*(label1y))=u1 hepsi icin;
             * yukarıda hesapladıklarımızı kucukten buyuge sıralı halde diziye atarız.
             * k ' ye gore dizi ' nin elemanları ortalaması alınır ve sonuc. 
             * 
             */

            

            int noktax = nokta.Location.X;
            int noktay = nokta.Location.Y;

            int e0x = e0.Location.X;
            int e1x = e1.Location.X;
            int e2x = e2.Location.X;
            int e3x = e3.Location.X;
            int e4x = e4.Location.X;
            int e5x = e5.Location.X;
            int e6x = e6.Location.X;
            int e7x = e7.Location.X;
            int e8x = e8.Location.X;
            int e9x = e9.Location.X;

            

            int e0y = e0.Location.Y;
            int e1y = e1.Location.Y;
            int e2y = e2.Location.Y;
            int e3y = e3.Location.Y;
            int e4y = e4.Location.Y;
            int e5y = e5.Location.Y;
            int e6y = e6.Location.Y;
            int e7y = e7.Location.Y;
            int e8y = e8.Location.Y;
            int e9y = e9.Location.Y;

            


            int k0x = k0.Location.X;
            int k1x = k1.Location.X;
            int k2x = k2.Location.X;
            int k3x = k3.Location.X;
            int k4x = k4.Location.X;
            int k5x = k5.Location.X;
            int k6x = k6.Location.X;
            int k7x = k7.Location.X;
            int k8x = k8.Location.X;
            int k9x = k9.Location.X;

            

            int k0y = k0.Location.Y;
            int k1y = k1.Location.Y;
            int k2y = k2.Location.Y;
            int k3y = k3.Location.Y;
            int k4y = k4.Location.Y;
            int k5y = k5.Location.Y;
            int k6y = k6.Location.Y;
            int k7y = k7.Location.Y;
            int k8y = k8.Location.Y;
            int k9y = k9.Location.Y;

           
            E[1] = Math.Sqrt((Math.Abs(e1x - noktax) * Math.Abs(e1x - noktax)) + (Math.Abs(e1y - noktay) * Math.Abs(e1y - noktay)));
            E[2] = Math.Sqrt((Math.Abs(e2x - noktax) * Math.Abs(e2x - noktax)) + (Math.Abs(e2y - noktay) * Math.Abs(e2y - noktay)));
            E[3] = Math.Sqrt((Math.Abs(e3x - noktax) * Math.Abs(e3x - noktax)) + (Math.Abs(e3y - noktay) * Math.Abs(e3y - noktay)));
            E[4] = Math.Sqrt((Math.Abs(e4x - noktax) * Math.Abs(e4x - noktax)) + (Math.Abs(e4y - noktay) * Math.Abs(e4y - noktay)));
            E[5] = Math.Sqrt((Math.Abs(e5x - noktax) * Math.Abs(e5x - noktax)) + (Math.Abs(e5y - noktay) * Math.Abs(e5y - noktay)));
            E[6] = Math.Sqrt((Math.Abs(e6x - noktax) * Math.Abs(e6x - noktax)) + (Math.Abs(e6y - noktay) * Math.Abs(e6y - noktay)));
            E[7] = Math.Sqrt((Math.Abs(e7x - noktax) * Math.Abs(e7x - noktax)) + (Math.Abs(e7y - noktay) * Math.Abs(e7y - noktay)));
            E[8] = Math.Sqrt((Math.Abs(e8x - noktax) * Math.Abs(e8x - noktax)) + (Math.Abs(e8y - noktay) * Math.Abs(e8y - noktay)));
            E[9] = Math.Sqrt((Math.Abs(e9x - noktax) * Math.Abs(e9x - noktax)) + (Math.Abs(e9y - noktay) * Math.Abs(e9y - noktay)));
            E[0] = Math.Sqrt((Math.Abs(e0x - noktax) * Math.Abs(e0x - noktax)) + (Math.Abs(e0y - noktay) * Math.Abs(e0y - noktay)));

            sıralıatama(E);
            

            K[1] = Math.Sqrt((Math.Abs(k1x - noktax) * Math.Abs(k1x - noktax)) + (Math.Abs(k1y - noktay) * Math.Abs(k1y - noktay)));
            K[2] = Math.Sqrt((Math.Abs(k2x - noktax) * Math.Abs(k2x - noktax)) + (Math.Abs(k2y - noktay) * Math.Abs(k2y - noktay)));
            K[3] = Math.Sqrt((Math.Abs(k3x - noktax) * Math.Abs(k3x - noktax)) + (Math.Abs(k3y - noktay) * Math.Abs(k3y - noktay)));
            K[4] = Math.Sqrt((Math.Abs(k4x - noktax) * Math.Abs(k4x - noktax)) + (Math.Abs(k4y - noktay) * Math.Abs(k4y - noktay)));
            K[5] = Math.Sqrt((Math.Abs(k5x - noktax) * Math.Abs(k5x - noktax)) + (Math.Abs(k5y - noktay) * Math.Abs(k5y - noktay)));
            K[6] = Math.Sqrt((Math.Abs(k6x - noktax) * Math.Abs(k6x - noktax)) + (Math.Abs(k6y - noktay) * Math.Abs(k6y - noktay)));
            K[7] = Math.Sqrt((Math.Abs(k7x - noktax) * Math.Abs(k7x - noktax)) + (Math.Abs(k7y - noktay) * Math.Abs(k7y - noktay)));
            K[8] = Math.Sqrt((Math.Abs(k8x - noktax) * Math.Abs(k8x - noktax)) + (Math.Abs(k8y - noktay) * Math.Abs(k8y - noktay)));
            K[9] = Math.Sqrt((Math.Abs(k9x - noktax) * Math.Abs(k9x - noktax)) + (Math.Abs(k9y - noktay) * Math.Abs(k9y - noktay)));
            K[0] = Math.Sqrt((Math.Abs(k0x - noktax) * Math.Abs(k0x - noktax)) + (Math.Abs(k0y - noktay) * Math.Abs(k0y - noktay)));

            sıralıatama(K);

        }

        private void bt_hesap_Click(object sender, EventArgs e)
        {
            //diziyazdir(E);
            //diziyazdir(K);
            hesap(Convert.ToInt32(nud_kdegeri.Value));
        }

        
    }
}
