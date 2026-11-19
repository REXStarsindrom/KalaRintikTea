namespace KalaRintikTea.Forms
{
    partial class FormRegister
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.lblSudahPunyaAkun = new System.Windows.Forms.Label();
            this.lblFooterLeft = new System.Windows.Forms.Label();
            this.lblFooterRight = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlTabs.SuspendLayout();
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
            this.pnlCard.Controls.Add(this.lblNama);
            this.pnlCard.Controls.Add(this.txtNama);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblTelepon);
            this.pnlCard.Controls.Add(this.txtTelepon);
            this.pnlCard.Controls.Add(this.lblAlamat);
            this.pnlCard.Controls.Add(this.txtAlamat);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblConfirm);
            this.pnlCard.Controls.Add(this.txtConfirm);
            this.pnlCard.Controls.Add(this.btnDaftar);
            this.pnlCard.Controls.Add(this.lblSudahPunyaAkun);
            this.pnlCard.Location = new System.Drawing.Point(342, 20);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(30);
            this.pnlCard.Size = new System.Drawing.Size(500, 620);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTabs.Controls.Add(this.btnTabLogin);
            this.pnlTabs.Controls.Add(this.btnTabDaftar);
            this.pnlTabs.Location = new System.Drawing.Point(30, 20);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(440, 40);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnTabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabLogin.FlatAppearance.BorderSize = 0;
            this.btnTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnTabLogin.Location = new System.Drawing.Point(3, 3);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(215, 34);
            this.btnTabLogin.TabIndex = 0;
            this.btnTabLogin.Text = "Login";
            this.btnTabLogin.UseVisualStyleBackColor = false;
            // 
            // btnTabDaftar
            // 
            this.btnTabDaftar.BackColor = System.Drawing.Color.White;
            this.btnTabDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabDaftar.FlatAppearance.BorderSize = 0;
            this.btnTabDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDaftar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnTabDaftar.Location = new System.Drawing.Point(222, 3);
            this.btnTabDaftar.Name = "btnTabDaftar";
            this.btnTabDaftar.Size = new System.Drawing.Size(215, 34);
            this.btnTabDaftar.TabIndex = 1;
            this.btnTabDaftar.Text = "Daftar";
            this.btnTabDaftar.UseVisualStyleBackColor = false;
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblCardTitle.Location = new System.Drawing.Point(30, 75);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(440, 30);
            this.lblCardTitle.TabIndex = 1;
            this.lblCardTitle.Text = "Buat akun pelanggan";
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardSubtitle
            // 
            this.lblCardSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCardSubtitle.Location = new System.Drawing.Point(30, 108);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.Size = new System.Drawing.Size(440, 22);
            this.lblCardSubtitle.TabIndex = 2;
            this.lblCardSubtitle.Text = "Daftar untuk mulai belanja teh lokal pilihan.";
            this.lblCardSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNama.Location = new System.Drawing.Point(30, 140);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(86, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNama.Location = new System.Drawing.Point(30, 160);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(440, 26);
            this.txtNama.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(30, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelepon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTelepon.Location = new System.Drawing.Point(260, 200);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(71, 15);
            this.lblTelepon.TabIndex = 7;
            this.lblTelepon.Text = "No. telepon";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTelepon.Location = new System.Drawing.Point(260, 220);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(210, 26);
            this.txtTelepon.TabIndex = 8;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAlamat.Location = new System.Drawing.Point(30, 260);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(109, 15);
            this.lblAlamat.TabIndex = 9;
            this.lblAlamat.Text = "Alamat pengiriman";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAlamat.Location = new System.Drawing.Point(30, 280);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(440, 60);
            this.txtAlamat.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPassword.Location = new System.Drawing.Point(30, 355);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 15);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Kata sandi";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.Location = new System.Drawing.Point(30, 375);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 26);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblConfirm.Location = new System.Drawing.Point(260, 355);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(103, 15);
            this.lblConfirm.TabIndex = 13;
            this.lblConfirm.Text = "Ulangi kata sandi";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtConfirm.Location = new System.Drawing.Point(260, 375);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(210, 26);
            this.txtConfirm.TabIndex = 14;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaftar.FlatAppearance.BorderSize = 0;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor = System.Drawing.Color.White;
            this.btnDaftar.Location = new System.Drawing.Point(30, 440);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(440, 45);
            this.btnDaftar.TabIndex = 15;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = false;
            // 
            // lblSudahPunyaAkun
            // 
            this.lblSudahPunyaAkun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSudahPunyaAkun.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSudahPunyaAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSudahPunyaAkun.Location = new System.Drawing.Point(30, 505);
            this.lblSudahPunyaAkun.Name = "lblSudahPunyaAkun";
            this.lblSudahPunyaAkun.Size = new System.Drawing.Size(440, 25);
            this.lblSudahPunyaAkun.TabIndex = 16;
            this.lblSudahPunyaAkun.Text = "Sudah punya akun? Masuk di sini";
            this.lblSudahPunyaAkun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblFooterLeft.TabIndex = 1;
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
            this.lblFooterRight.TabIndex = 2;
            this.lblFooterRight.Text = "Teh yang baik. Momen yang tenang.";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "FormRegister";
            this.Text = "Kala Rintik Tea — Daftar Akun";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label lblSudahPunyaAkun;
        private System.Windows.Forms.Label lblFooterLeft;
        private System.Windows.Forms.Label lblFooterRight;
    }
}
