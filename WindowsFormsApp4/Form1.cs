using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapi.Text;
            string pencereSayisi = txtPencere.Text;
            string yakit = txtYakit.Text;

            // Tüm bilgileri birleştirerek mesaj kutusunda gösteriyoruz
            string bilgi = $"🚗 Araba Bilgileri:\n" +
                           $"Marka: {marka}\n" +
                           $"Model: {model}\n" +
                           $"Renk: {renk}\n" +
                           $"Kapı Sayısı: {kapiSayisi}\n" +
                           $"Pencere Sayısı: {pencereSayisi}\n" +
                           $"100 km'de Yaktığı Yakıt: {yakit} Litre";

            // MessageBox ile ekranda göster
            MessageBox.Show(bilgi, "Araba Bilgisi");
        }
    }
}
       