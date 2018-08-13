using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            int[] sayibasamaklari = new int[4];
            int i = 0;
            string metin = "";
            string[,] basamaklarstring = { { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" }, { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" }, { "", "yüz", "iki yüz", "üç yüz", "dört yüz", "beş yüz", "altı yüz", "yedi yüz", "sekiz yüz", "dokuz yüz" }, { "", "bin", "iki bin", "üç bin", "dört bin", "beş bin", "altı bin", "yedi bin", "sekiz bin", "dokuz bin" } };
            int[] basamaklarint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sayi = Convert.ToInt32(textBox1.Text);
            while (sayi > 0)
            {
                sayibasamaklari[i] = sayi % 10;
                sayi = sayi / 10;
                i++;
            }
            for (i = sayibasamaklari.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sayibasamaklari[i] == basamaklarint[j])
                    {
                        metin += basamaklarstring[i, j] + " ";
                    }
                }
            }
            lblsonuc.Text = metin;
        }
    }
}
