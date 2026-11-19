namespace KalaRintikTea.Forms
{
    partial class FormLanding
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.lblInfoSeed = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.lblRightSubtitle = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Desc = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Desc = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Desc = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.lblCard4Desc = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.lblSub);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.lblDesc);
            this.pnlLeft.Controls.Add(this.btnMasuk);
            this.pnlLeft.Controls.Add(this.btnDaftar);
            this.pnlLeft.Controls.Add(this.lblInfoSeed);
            this.pnlLeft.Controls.Add(this.lblFooter);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(60, 50, 40, 40);
            this.pnlLeft.Size = new System.Drawing.Size(700, 761);
            this.pnlLeft.TabIndex = 0;
            // 
            // picLogo
            //
            this.picLogo.Image = System.Drawing.Image.FromFile(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources\\logo.png"));
            this.picLogo.Location = new System.Drawing.Point(55, 40);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSub.Location = new System.Drawing.Point(57, 180);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(250, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "SELAMAT DATANG DI KALA RINTIK TEA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(53, 205);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 102);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Teh lokal pilihan,\r\ndiseduh dengan tenang.";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblDesc.Location = new System.Drawing.Point(56, 325);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(550, 50);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Aplikasi e-commerce desktop untuk membeli dan mengelola penjualan teh lokal berkualitas dari kebun-kebun terbaik Indonesia.";
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.FlatAppearance.BorderSize = 0;
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(60, 400);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(140, 45);
            this.btnMasuk.TabIndex = 4;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.White;
            this.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaftar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnDaftar.Location = new System.Drawing.Point(220, 400);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(150, 45);
            this.btnDaftar.TabIndex = 5;
            this.btnDaftar.Text = "Daftar Akun";
            this.btnDaftar.UseVisualStyleBackColor = false;
            // 
            // lblInfoSeed
            // 
            this.lblInfoSeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoSeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblInfoSeed.Location = new System.Drawing.Point(58, 470);
            this.lblInfoSeed.Name = "lblInfoSeed";
            this.lblInfoSeed.Size = new System.Drawing.Size(500, 35);
            this.lblInfoSeed.TabIndex = 6;
            this.lblInfoSeed.Text = "Akun Owner dan Admin dibuat lewat seed data, lalu masuk melalui halaman Login yang sama.";
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblFooter.Location = new System.Drawing.Point(58, 710);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(325, 15);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.Text = "Mitra: Kebun Teh Gunung Gambir, Sumberbaru, Jember  ·  Versi 1.0";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.pnlRight.Controls.Add(this.lblRightTitle);
            this.pnlRight.Controls.Add(this.lblRightSubtitle);
            this.pnlRight.Controls.Add(this.pnlCard1);
            this.pnlRight.Controls.Add(this.pnlCard2);
            this.pnlRight.Controls.Add(this.pnlCard3);
            this.pnlRight.Controls.Add(this.pnlCard4);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(700, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(40, 60, 40, 40);
            this.pnlRight.Size = new System.Drawing.Size(484, 761);
            this.pnlRight.TabIndex = 1;
            // 
            // lblRightTitle
            // 
            this.lblRightTitle.AutoSize = true;
            this.lblRightTitle.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblRightTitle.ForeColor = System.Drawing.Color.White;
            this.lblRightTitle.Location = new System.Drawing.Point(40, 50);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(370, 35);
            this.lblRightTitle.TabIndex = 0;
            this.lblRightTitle.Text = "Apa yang bisa kamu lakukan";
            // 
            // lblRightSubtitle
            // 
            this.lblRightSubtitle.AutoSize = true;
            this.lblRightSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRightSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblRightSubtitle.Location = new System.Drawing.Point(42, 95);
            this.lblRightSubtitle.Name = "lblRightSubtitle";
            this.lblRightSubtitle.Size = new System.Drawing.Size(326, 19);
            this.lblRightSubtitle.TabIndex = 1;
            this.lblRightSubtitle.Text = "Satu aplikasi untuk pelanggan, admin, dan pemilik toko.";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(70)))));
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Desc);
            this.pnlCard1.Location = new System.Drawing.Point(45, 145);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard1.Size = new System.Drawing.Size(395, 80);
            this.pnlCard1.TabIndex = 2;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.White;
            this.lblCard1Title.Location = new System.Drawing.Point(12, 12);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(147, 20);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "🌿  Katalog teh lokal";
            // 
            // lblCard1Desc
            // 
            this.lblCard1Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard1Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCard1Desc.Location = new System.Drawing.Point(14, 38);
            this.lblCard1Desc.Name = "lblCard1Desc";
            this.lblCard1Desc.Size = new System.Drawing.Size(365, 32);
            this.lblCard1Desc.TabIndex = 1;
            this.lblCard1Desc.Text = "7 kategori: Hijau, Hitam, Putih, Oolong, Herbal, Celup, dan Bubuk.";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(70)))));
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Desc);
            this.pnlCard2.Location = new System.Drawing.Point(45, 240);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard2.Size = new System.Drawing.Size(395, 80);
            this.pnlCard2.TabIndex = 3;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.White;
            this.lblCard2Title.Location = new System.Drawing.Point(12, 12);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(185, 20);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "🛒  Keranjang & checkout";
            // 
            // lblCard2Desc
            // 
            this.lblCard2Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard2Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCard2Desc.Location = new System.Drawing.Point(14, 38);
            this.lblCard2Desc.Name = "lblCard2Desc";
            this.lblCard2Desc.Size = new System.Drawing.Size(365, 32);
            this.lblCard2Desc.TabIndex = 1;
            this.lblCard2Desc.Text = "Pesan dengan Transfer, COD, atau Dompet Digital. Ongkir dihitung otomatis.";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(70)))));
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Desc);
            this.pnlCard3.Location = new System.Drawing.Point(45, 335);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard3.Size = new System.Drawing.Size(395, 80);
            this.pnlCard3.TabIndex = 4;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.White;
            this.lblCard3Title.Location = new System.Drawing.Point(12, 12);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(147, 20);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "⭐  Ulasan & rating";
            // 
            // lblCard3Desc
            // 
            this.lblCard3Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard3Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCard3Desc.Location = new System.Drawing.Point(14, 38);
            this.lblCard3Desc.Name = "lblCard3Desc";
            this.lblCard3Desc.Size = new System.Drawing.Size(365, 32);
            this.lblCard3Desc.TabIndex = 1;
            this.lblCard3Desc.Text = "Beri bintang 1–5 untuk teh dari pesanan yang sudah selesai.";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(70)))));
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblCard4Desc);
            this.pnlCard4.Location = new System.Drawing.Point(45, 430);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard4.Size = new System.Drawing.Size(395, 80);
            this.pnlCard4.TabIndex = 5;
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard4Title.ForeColor = System.Drawing.Color.White;
            this.lblCard4Title.Location = new System.Drawing.Point(12, 12);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(186, 20);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "🎛️  Panel Owner & Admin";
            // 
            // lblCard4Desc
            // 
            this.lblCard4Desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard4Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblCard4Desc.Location = new System.Drawing.Point(14, 38);
            this.lblCard4Desc.Name = "lblCard4Desc";
            this.lblCard4Desc.Size = new System.Drawing.Size(365, 32);
            this.lblCard4Desc.TabIndex = 1;
            this.lblCard4Desc.Text = "Kelola produk, status transaksi, dan akun admin dalam satu tempat.";
            // 
            // FormLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FormLanding";
            this.Text = "Kala Rintik Tea — Selamat Datang";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label lblInfoSeed;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblRightTitle;
        private System.Windows.Forms.Label lblRightSubtitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Desc;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Desc;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Desc;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCard4Desc;
    }
}
