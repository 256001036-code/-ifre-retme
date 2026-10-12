namespace Şifre_Üretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Karakter havuzlarını tanımla
            string buyukHarfler = "ABCDEFGHYJKLMNOPRSTUVYZXWQ";
            string kucukHarfler = "abcdefghyjklmnoprstuvyzxwq";
            string rakamlar = "0123456789";
            string ozelKarakterler = "!@?_.*-+$#";

            string tumKarakterler = "";
            Random rnd = new Random();

            // 2. Seçili özelliklere göre havuzu doldur
            if (checkBox1.Checked) tumKarakterler += buyukHarfler;
            if (checkBox2.Checked) tumKarakterler += kucukHarfler;
            if (checkBox3.Checked) tumKarakterler += rakamlar;
            if (checkBox4.Checked) tumKarakterler += ozelKarakterler;

            // 3. Güvenlik Kontrolü: En az bir seçim yapılmalı
            if (tumKarakterler == "")
            {
                MessageBox.Show("Lütfen en az bir özellik seçiniz!");
                return;
            }

            // 4. Uzunluk kontrolü
            if (!int.TryParse(textBox1.Text, out int uzunluk) || uzunluk <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir şifre uzunluğu giriniz!");
                return;
            }

            // 5. Şifreyi üret
            string sifre = "";
            for (int i = 0; i < uzunluk; i++)
            {
                int rastgeleIndex = rnd.Next(0, tumKarakterler.Length);
                sifre += tumKarakterler[rastgeleIndex];
            }

            // 6. Sonucu göster
            label2.Text = sifre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
