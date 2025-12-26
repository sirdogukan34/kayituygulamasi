namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            kullaniciadi = new TextBox();
            sifre = new TextBox();
            mail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mailsifre = new TextBox();
            kategori = new ComboBox();
            label6 = new Label();
            listView1 = new ListView();
            koplaya = new Button();
            sil = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 231);
            button1.Name = "button1";
            button1.Size = new Size(236, 82);
            button1.TabIndex = 0;
            button1.Text = "Hesap Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kullaniciadi
            // 
            kullaniciadi.Location = new Point(12, 35);
            kullaniciadi.Name = "kullaniciadi";
            kullaniciadi.Size = new Size(149, 27);
            kullaniciadi.TabIndex = 1;
            kullaniciadi.TextChanged += textBox1_TextChanged;
            // 
            // sifre
            // 
            sifre.Location = new Point(197, 35);
            sifre.Name = "sifre";
            sifre.Size = new Size(149, 27);
            sifre.TabIndex = 2;
            // 
            // mail
            // 
            mail.Location = new Point(12, 101);
            mail.Name = "mail";
            mail.Size = new Size(149, 27);
            mail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 7;
            label1.Text = "Kullanıcı adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 12);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "Şifre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 78);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 10;
            label4.Text = "Mail Şifre";
            // 
            // mailsifre
            // 
            mailsifre.Location = new Point(197, 101);
            mailsifre.Name = "mailsifre";
            mailsifre.Size = new Size(149, 27);
            mailsifre.TabIndex = 4;
            // 
            // kategori
            // 
            kategori.FormattingEnabled = true;
            kategori.Items.AddRange(new object[] { "Instagram", "Tiktok", "Twitter", "Facebook", "Youtube" });
            kategori.Location = new Point(12, 173);
            kategori.Name = "kategori";
            kategori.Size = new Size(151, 28);
            kategori.TabIndex = 13;
            kategori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 150);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 14;
            label6.Text = "Hesap Kategorisi Seç";
            label6.Click += label6_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(389, 12);
            listView1.Name = "listView1";
            listView1.ShowGroups = false;
            listView1.Size = new Size(560, 325);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // koplaya
            // 
            koplaya.Location = new Point(955, 12);
            koplaya.Name = "koplaya";
            koplaya.Size = new Size(162, 35);
            koplaya.TabIndex = 16;
            koplaya.Text = "Hesap Bilgi Kopyala";
            koplaya.UseVisualStyleBackColor = true;
            koplaya.Click += koplaya_Click;
            // 
            // sil
            // 
            sil.Location = new Point(955, 69);
            sil.Name = "sil";
            sil.Size = new Size(162, 35);
            sil.TabIndex = 17;
            sil.Text = "Hesap Bilgi Sil";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 356);
            Controls.Add(sil);
            Controls.Add(koplaya);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(kategori);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mailsifre);
            Controls.Add(mail);
            Controls.Add(sifre);
            Controls.Add(kullaniciadi);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Hesap Kayıt Programı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox kullaniciadi;
        private TextBox sifre;
        private TextBox mail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mailsifre;
        private ComboBox kategori;
        private Label label6;
        private ListView listView1;
        private Button koplaya;
        private Button sil;
    }
}
