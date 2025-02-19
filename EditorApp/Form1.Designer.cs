namespace EditorApp
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
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            miYeni = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            miKaydet = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            miKes = new ToolStripMenuItem();
            miKopyala = new ToolStripMenuItem();
            miYapistir = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            miBul = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            temaToolStripMenuItem = new ToolStripMenuItem();
            koyuTemaToolStripMenuItem = new ToolStripMenuItem();
            açıkTemaToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            ftbYeni = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tspKaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            label1 = new Label();
            txtbelge = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, yardımToolStripMenuItem, görünümToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miYeni, açToolStripMenuItem, miKaydet, farklıKaydetToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // miYeni
            // 
            miYeni.Name = "miYeni";
            miYeni.Size = new Size(140, 22);
            miYeni.Text = "Yeni";
            miYeni.Click += miYeni_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(140, 22);
            açToolStripMenuItem.Text = "Aç";
            // 
            // miKaydet
            // 
            miKaydet.Name = "miKaydet";
            miKaydet.Size = new Size(140, 22);
            miKaydet.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(140, 22);
            farklıKaydetToolStripMenuItem.Text = "Farklı kaydet";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miKes, miKopyala, miYapistir, toolStripMenuItem1, miBul });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // miKes
            // 
            miKes.Name = "miKes";
            miKes.Size = new Size(180, 22);
            miKes.Text = "Kes";
            miKes.Click += miKes_Click;
            // 
            // miKopyala
            // 
            miKopyala.Name = "miKopyala";
            miKopyala.Size = new Size(180, 22);
            miKopyala.Text = "Kopyala";
            miKopyala.Click += miKopyala_Click;
            // 
            // miYapistir
            // 
            miYapistir.Name = "miYapistir";
            miYapistir.Size = new Size(180, 22);
            miYapistir.Text = "Yapıştır";
            miYapistir.Click += miYapistir_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // miBul
            // 
            miBul.Name = "miBul";
            miBul.Size = new Size(180, 22);
            miBul.Text = "Bul";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(124, 22);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temaToolStripMenuItem, yazıTipiToolStripMenuItem, yazıRengiToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // temaToolStripMenuItem
            // 
            temaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { koyuTemaToolStripMenuItem, açıkTemaToolStripMenuItem });
            temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            temaToolStripMenuItem.Size = new Size(124, 22);
            temaToolStripMenuItem.Text = "Tema";
            // 
            // koyuTemaToolStripMenuItem
            // 
            koyuTemaToolStripMenuItem.Name = "koyuTemaToolStripMenuItem";
            koyuTemaToolStripMenuItem.Size = new Size(131, 22);
            koyuTemaToolStripMenuItem.Text = "Koyu tema";
            // 
            // açıkTemaToolStripMenuItem
            // 
            açıkTemaToolStripMenuItem.Name = "açıkTemaToolStripMenuItem";
            açıkTemaToolStripMenuItem.Size = new Size(131, 22);
            açıkTemaToolStripMenuItem.Text = "Açık tema";
            // 
            // yazıTipiToolStripMenuItem
            // 
            yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            yazıTipiToolStripMenuItem.Size = new Size(124, 22);
            yazıTipiToolStripMenuItem.Text = "Yazı tipi";
            // 
            // yazıRengiToolStripMenuItem
            // 
            yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            yazıRengiToolStripMenuItem.Size = new Size(124, 22);
            yazıRengiToolStripMenuItem.Text = "Yazı rengi";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ftbYeni, toolStripButton2, tspKaydet, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(901, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ftbYeni
            // 
            ftbYeni.Image = Properties.Resources.folder;
            ftbYeni.ImageTransparentColor = Color.Magenta;
            ftbYeni.Name = "ftbYeni";
            ftbYeni.Size = new Size(36, 51);
            ftbYeni.Text = "Yeni";
            ftbYeni.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.folder__1_;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 51);
            toolStripButton2.Text = "Aç";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tspKaydet
            // 
            tspKaydet.Image = Properties.Resources.save;
            tspKaydet.ImageTransparentColor = Color.Magenta;
            tspKaydet.Name = "tspKaydet";
            tspKaydet.Size = new Size(47, 51);
            tspKaydet.Text = "Kaydet";
            tspKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.cut;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 51);
            toolStripButton4.Text = "Kes";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton4.Click += miKes_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.copy_two_paper_sheets_interface_symbol;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(53, 51);
            toolStripButton5.Text = "Kopyala";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton5.Click += miKopyala_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.copy;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(49, 51);
            toolStripButton6.Text = "Yapıştır";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton6.Click += miYapistir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 377);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // txtbelge
            // 
            txtbelge.BackColor = Color.WhiteSmoke;
            txtbelge.Dock = DockStyle.Fill;
            txtbelge.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtbelge.Location = new Point(0, 78);
            txtbelge.Multiline = true;
            txtbelge.Name = "txtbelge";
            txtbelge.Size = new Size(901, 363);
            txtbelge.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 441);
            Controls.Add(txtbelge);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem miYeni;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem miKaydet;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripMenuItem miKes;
        private ToolStripMenuItem miKopyala;
        private ToolStripMenuItem miYapistir;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem miBul;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem temaToolStripMenuItem;
        private ToolStripMenuItem koyuTemaToolStripMenuItem;
        private ToolStripMenuItem açıkTemaToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripButton ftbYeni;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tspKaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private Label label1;
        private TextBox txtbelge;
        private SaveFileDialog saveFileDialog1;
    }
}