using System;
using System.IO;
using System.Windows.Forms;

namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi; // Editördeki dosyanın adı

        public Form1()
        {
            InitializeComponent();
            YeniBelge(); // Uygulama ilk çalıştığında yeni belge oluştursun
        }

        void YeniBelge()
        {
            txtbelge.Text = ""; // Metin kutusunu temizler
            dosyaAdi = "";
            Text = "[Yeni Belge]";
        }

        void Kaydet()
        {
            // Eğer dosya zaten kayıtlı ise diyalog gösterme
            if (!string.IsNullOrEmpty(dosyaAdi))
            {
                File.WriteAllText(dosyaAdi, txtbelge.Text);
                return;
            }

            saveFileDialog1.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK) // Kullanıcı "Tamam" dediyse
            {
                string secilenDosya = saveFileDialog1.FileName;
                File.WriteAllText(secilenDosya, txtbelge.Text);
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
        }

        private void miYeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void tsbAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            dialog.DefaultExt = "*.txt";

            DialogResult cevap = dialog.ShowDialog(); // Diyaloğu göster ve sonucu bekle
            if (cevap == DialogResult.OK) // Kullanıcı dosya seçtiyse
            {
                string secilenDosya = dialog.FileName;
                string icerik = File.ReadAllText(secilenDosya);
                txtbelge.Text = icerik;
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var cevap = MessageBox.Show("Kayıt edilmemiş değişiklikleri kaydetmek ister misiniz?",
                "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (cevap == DialogResult.Cancel)
            {
                e.Cancel = true; // Kapatma işlemini iptal et
            }
            // "Hayır" seçeneğini kontrol etmeye gerek yok, çünkü işlem devam edecek.
        }

        private void miKes_Click(object sender, EventArgs e)
        {
            txtbelge.Cut();
        }

        private void miKopyala_Click(object sender, EventArgs e)
        {
            txtbelge.Copy();
        }

        private void miYapistir_Click(object sender, EventArgs e)
        {
            txtbelge.Paste();
        }
    }
}
