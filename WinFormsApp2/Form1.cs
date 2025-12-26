namespace WinFormsApp2

{
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Collections;

    public partial class Form1 : Form
    {
        Dictionary<string, int> kategoriOncelik = new Dictionary<string, int>()
{
    { "Instagram", 1 },
    { "Tiktok", 2 },
    { "Twitter", 3 },
    { "Youtube", 4 },
    { "Facebook", 5 }
};




        string dosyaYolu = "veriler.txt";

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciadi.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }

            // Yeni item oluştur
            ListViewItem yeniItem = new ListViewItem(kategori.Text);
            yeniItem.SubItems.Add(kullaniciadi.Text);
            yeniItem.SubItems.Add(sifre.Text);
            yeniItem.SubItems.Add(mail.Text);
            yeniItem.SubItems.Add(mailsifre.Text);

            int eklenecekIndex = listView1.Items.Count; // varsayılan: sona ekle
            int yeniKategoriOncelik = kategoriOncelik[kategori.Text];

            // ListView içini dolaş
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string mevcutKategori = listView1.Items[i].SubItems[0].Text;
                int mevcutOncelik = kategoriOncelik[mevcutKategori];

                // Aynı kategori varsa → onun ALTINA ekle
                if (mevcutKategori == kategori.Text)
                {
                    eklenecekIndex = i + 1;
                }
                // Daha büyük öncelikli kategoriye gelince DUR
                else if (mevcutOncelik > yeniKategoriOncelik)
                {
                    eklenecekIndex = i;
                    break;
                }
            }

            // Doğru yere ekle
            listView1.Items.Insert(eklenecekIndex, yeniItem);

            // DOSYAYA YAZ (sıra doğru)
            string satir =
                kategori.Text + "|" +
                kullaniciadi.Text + "|" +
                sifre.Text + "|" +
                mail.Text + "|" +
                mailsifre.Text;

            File.AppendAllText(dosyaYolu, satir + Environment.NewLine);

            // Temizle
            kullaniciadi.Clear();
            sifre.Clear();
            mail.Clear();
            mailsifre.Clear();
            kategori.SelectedIndex = -1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.MultiSelect = true;
            listView1.HideSelection = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Kategori", 120);
            listView1.Columns.Add("Kullanıcı Adı", 120);
            listView1.Columns.Add("Şifre", 70);
            listView1.Columns.Add("Mail", 120);
            listView1.Columns.Add("Mail Şifre", 120);


            listView1.Groups.Add(new ListViewGroup("Instagram"));
            listView1.Groups.Add(new ListViewGroup("Tiktok"));
            listView1.Groups.Add(new ListViewGroup("Twitter"));
            listView1.Groups.Add(new ListViewGroup("Facebook"));
            listView1.Groups.Add(new ListViewGroup("Youtube"));

            // DOSYA VARSA OKU
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] parca = satir.Split('|');

                    if (parca.Length == 5)
                    {
                        ListViewItem item = new ListViewItem(parca[0]);
                        item.SubItems.Add(parca[1]);
                        item.SubItems.Add(parca[2]);
                        item.SubItems.Add(parca[3]);
                        item.SubItems.Add(parca[4]);

                        int eklenecekIndex = listView1.Items.Count;
                        int yeniKategoriOncelik = kategoriOncelik[parca[0]];

                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            string mevcutKategori = listView1.Items[i].SubItems[0].Text;
                            int mevcutOncelik = kategoriOncelik[mevcutKategori];

                            if (mevcutKategori == parca[0])
                            {
                                eklenecekIndex = i + 1;
                            }
                            else if (mevcutOncelik > yeniKategoriOncelik)
                            {
                                eklenecekIndex = i;
                                break;
                            }
                        }

                        listView1.Items.Insert(eklenecekIndex, item);
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void koplaya_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kopyalamak için en az bir kayıt seçmelisin.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                sb.AppendLine("Kullanıcı Adı: " + item.SubItems[0].Text);
                sb.AppendLine("Şifre: " + item.SubItems[1].Text);
                sb.AppendLine("Mail: " + item.SubItems[2].Text);
                sb.AppendLine("Mail Şifre: " + item.SubItems[3].Text);
                sb.AppendLine("Kategori: " + item.SubItems[4].Text);
                sb.AppendLine("----------------------------");
            }

            Clipboard.SetText(sb.ToString());
            MessageBox.Show("Seçilen kayıtlar kopyalandı.");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silmek için en az bir kayıt seçmelisin.");
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                "Seçili kayıtlar silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
            // DOSYAYI BAŞTAN YAZ
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in listView1.Items)
            {
                sb.AppendLine(
                    item.SubItems[0].Text + "|" +
                    item.SubItems[1].Text + "|" +
                    item.SubItems[2].Text + "|" +
                    item.SubItems[3].Text + "|" +
                    item.SubItems[4].Text
                );
            }

            File.WriteAllText(dosyaYolu, sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
      
    }


  
}
