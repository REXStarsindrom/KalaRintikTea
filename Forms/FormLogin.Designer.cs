namespace KalaRintikTea.Forms
{
    partial class FormLogin
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblBantuan = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnTabLogin = new System.Windows.Forms.Button();
            this.btnTabDaftar = new System.Windows.Forms.Button();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblCardSubtitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.chkIngatSaya = new System.Windows.Forms.CheckBox();
            this.lblLupaPassword = new System.Windows.Forms.Label();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.lblBelumPunyaAkun = new System.Windows.Forms.Label();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.lblHintTitle = new System.Windows.Forms.Label();
            this.lblHintText = new System.Windows.Forms.Label();
            this.lblFooterLeft = new System.Windows.Forms.Label();
            this.lblFooterRight = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlHint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.pnlTopBar.Controls.Add(this.btnKembali);
            this.pnlTopBar.Controls.Add(this.lblBantuan);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1184, 50);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(20, 8);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(220, 34);
            this.btnKembali.TabIndex = 0;
            this.btnKembali.Text = "←  Kembali ke Tampilan Awal";
            this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKembali.UseVisualStyleBackColor = false;
            // 
            // lblBantuan
            // 
            this.lblBantuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBantuan.AutoSize = true;
            this.lblBantuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBantuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBantuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lblBantuan.Location = new System.Drawing.Point(990, 16);
            this.lblBantuan.Name = "lblBantuan";
            this.lblBantuan.Size = new System.Drawing.Size(170, 17);
            this.lblBantuan.TabIndex = 1;
            this.lblBantuan.Text = "Butuh bantuan? Hubungi kami";
            // 
            // pnlCenter
            // 
            this.pnlCenter.AutoScroll = true;
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlCenter.Controls.Add(this.pnlCard);
            this.pnlCenter.Controls.Add(this.pnlHint);
            this.pnlCenter.Controls.Add(this.lblFooterLeft);
            this.pnlCenter.Controls.Add(this.lblFooterRight);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 50);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1184, 711);
            this.pnlCenter.TabIndex = 1;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.pnlTabs);
            this.pnlCard.Controls.Add(this.lblCardTitle);
            this.pnlCard.Controls.Add(this.lblCardSubtitle);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.btnShowPassword);
            this.pnlCard.Controls.Add(this.chkIngatSaya);
            this.pnlCard.Controls.Add(this.lblLupaPassword);
            this.pnlCard.Controls.Add(this.btnMasuk);
            this.pnlCard.Controls.Add(this.lblBelumPunyaAkun);
            this.pnlCard.Location = new System.Drawing.Point(367, 30);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(30);
            this.pnlCard.Size = new System.Drawing.Size(450, 480);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTabs.Controls.Add(this.btnTabLogin);
            this.pnlTabs.Controls.Add(this.btnTabDaftar);
            this.pnlTabs.Location = new System.Drawing.Point(30, 20);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(390, 40);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.BackColor = System.Drawing.Color.White;
            this.btnTabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabLogin.FlatAppearance.BorderSize = 0;
            this.btnTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnTabLogin.Location = new System.Drawing.Point(3, 3);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(190, 34);
            this.btnTabLogin.TabIndex = 0;
            this.btnTabLogin.Text = "Login";
            this.btnTabLogin.UseVisualStyleBackColor = false;
            // 
            // btnTabDaftar
            // 
            this.btnTabDaftar.BackColor = System.Drawing.Color.Transparent;
            this.btnTabDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabDaftar.FlatAppearance.BorderSize = 0;
            this.btnTabDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDaftar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnTabDaftar.Location = new System.Drawing.Point(197, 3);
            this.btnTabDaftar.Name = "btnTabDaftar";
            this.btnTabDaftar.Size = new System.Drawing.Size(190, 34);
            this.btnTabDaftar.TabIndex = 1;
            this.btnTabDaftar.Text = "Daftar";
            this.btnTabDaftar.UseVisualStyleBackColor = false;
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblCardTitle.Location = new System.Drawing.Point(30, 80);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(390, 30);
            this.lblCardTitle.TabIndex = 1;
            this.lblCardTitle.Text = "Selamat datang kembali";
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardSubtitle
            // 
            this.lblCardSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCardSubtitle.Location = new System.Drawing.Point(30, 115);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.Size = new System.Drawing.Size(390, 22);
            this.lblCardSubtitle.TabIndex = 2;
            this.lblCardSubtitle.Text = "Masuk untuk melanjutkan ritual teh favoritmu.";
            this.lblCardSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(30, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPassword.Location = new System.Drawing.Point(30, 225);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Kata sandi";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(30, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPassword.Location = new System.Drawing.Point(380, 245);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(40, 27);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.Text = "👁️";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            // 
            // chkIngatSaya
            // 
            this.chkIngatSaya.AutoSize = true;
            this.chkIngatSaya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIngatSaya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.chkIngatSaya.Location = new System.Drawing.Point(30, 290);
            this.chkIngatSaya.Name = "chkIngatSaya";
            this.chkIngatSaya.Size = new System.Drawing.Size(79, 19);
            this.chkIngatSaya.TabIndex = 8;
            this.chkIngatSaya.Text = "Ingat saya";
            this.chkIngatSaya.UseVisualStyleBackColor = true;
            // 
            // lblLupaPassword
            // 
            this.lblLupaPassword.AutoSize = true;
            this.lblLupaPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLupaPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLupaPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblLupaPassword.Location = new System.Drawing.Point(325, 291);
            this.lblLupaPassword.Name = "lblLupaPassword";
            this.lblLupaPassword.Size = new System.Drawing.Size(95, 15);
            this.lblLupaPassword.TabIndex = 9;
            this.lblLupaPassword.Text = "Lupa kata sandi?";
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.FlatAppearance.BorderSize = 0;
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(30, 335);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(390, 45);
            this.btnMasuk.TabIndex = 10;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            // 
            // lblBelumPunyaAkun
            // 
            this.lblBelumPunyaAkun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBelumPunyaAkun.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBelumPunyaAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblBelumPunyaAkun.Location = new System.Drawing.Point(30, 400);
            this.lblBelumPunyaAkun.Name = "lblBelumPunyaAkun";
            this.lblBelumPunyaAkun.Size = new System.Drawing.Size(390, 25);
            this.lblBelumPunyaAkun.TabIndex = 11;
            this.lblBelumPunyaAkun.Text = "Belum punya akun? Daftar sekarang";
            this.lblBelumPunyaAkun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHint
            // 
            this.pnlHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.pnlHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHint.Controls.Add(this.lblHintTitle);
            this.pnlHint.Controls.Add(this.lblHintText);
            this.pnlHint.Location = new System.Drawing.Point(367, 525);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Padding = new System.Windows.Forms.Padding(12);
            this.pnlHint.Size = new System.Drawing.Size(450, 75);
            this.pnlHint.TabIndex = 1;
            // 
            // lblHintTitle
            // 
            this.lblHintTitle.AutoSize = true;
            this.lblHintTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHintTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblHintTitle.Location = new System.Drawing.Point(12, 10);
            this.lblHintTitle.Name = "lblHintTitle";
            this.lblHintTitle.Size = new System.Drawing.Size(262, 15);
            this.lblHintTitle.TabIndex = 0;
            this.lblHintTitle.Text = "Setelah login, kamu diarahkan sesuai peran:";
            // 
            // lblHintText
            // 
            this.lblHintText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHintText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblHintText.Location = new System.Drawing.Point(12, 30);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Size = new System.Drawing.Size(420, 32);
            this.lblHintText.TabIndex = 1;
            this.lblHintText.Text = "Admin ➔ Dashboard Admin  ·  Pelanggan ➔ Katalog\n(Akun demo: admin@kalarintik.id / budi@gmail.com, pass: password123)";
            // 
            // lblFooterLeft
            // 
            this.lblFooterLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFooterLeft.AutoSize = true;
            this.lblFooterLeft.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblFooterLeft.Location = new System.Drawing.Point(30, 675);
            this.lblFooterLeft.Name = "lblFooterLeft";
            this.lblFooterLeft.Size = new System.Drawing.Size(209, 15);
            this.lblFooterLeft.TabIndex = 2;
            this.lblFooterLeft.Text = "© 2026 Kala Rintik Tea · Kelompok 3 PBO";
            // 
            // lblFooterRight
            // 
            this.lblFooterRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterRight.AutoSize = true;
            this.lblFooterRight.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblFooterRight.Location = new System.Drawing.Point(980, 675);
            this.lblFooterRight.Name = "lblFooterRight";
            this.lblFooterRight.Size = new System.Drawing.Size(171, 15);
            this.lblFooterRight.TabIndex = 3;
            this.lblFooterRight.Text = "Teh yang baik. Momen yang tenang.";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "FormLogin";
            this.Text = "Kala Rintik Tea — Login";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlHint.ResumeLayout(false);
            this.pnlHint.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblBantuan;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnTabLogin;
        private System.Windows.Forms.Button btnTabDaftar;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblCardSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.CheckBox chkIngatSaya;
        private System.Windows.Forms.Label lblLupaPassword;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Label lblBelumPunyaAkun;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Label lblHintTitle;
        private System.Windows.Forms.Label lblHintText;
        private System.Windows.Forms.Label lblFooterLeft;
        private System.Windows.Forms.Label lblFooterRight;
    }
}
