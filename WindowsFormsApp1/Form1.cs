using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tahminsayisi;
        int i = 5;
        
        private void btn_random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tahminsayisi = random.Next(1, 100);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            tahminDogruMu(sayi);
        }

        void tahminDogruMu (int sayi)
        {
            if(i > 0)
            {
                if (sayi < tahminsayisi)
                {
                    MessageBox.Show("Tahminizi Yükseltin, kalan hakkınız: " + i);
                    i = i - 1;
                }

                else if (sayi > tahminsayisi)
                {
                    MessageBox.Show("Tahminizi düşürün, kalan hakkınız: " + i);
                    i = i - 1;
                }

                else
                {
                    MessageBox.Show("Tebrikler doğru tahmin");                   
                }
            }

            else
            {
                MessageBox.Show("Bulamadınız !!! Aradığınız Sayı: " + tahminsayisi);                
            }
            
        }

    }
}
