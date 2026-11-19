namespace KalaRintikTea.Forms
{
    partial class FormProfil
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRoleBadge = new System.Windows.Forms.Label();
            this.btnNavKatalog = new System.Windows.Forms.Button();
            this.btnNavKeranjang = new System.Windows.Forms.Button();
            this.btnNavRiwayat = new System.Windows.Forms.Button();
            this.btnNavProfil = new System.Windows.Forms.Button();
            this.pnlUserCard = new System.Windows.Forms.Panel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.lblInfoJoined = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.lblRoleBadge);
            this.pnlSidebar.Controls.Add(this.btnNavKatalog);
            this.pnlSidebar.Controls.Add(this.btnNavKeranjang);
            this.pnlSidebar.Controls.Add(this.btnNavRiwayat);
            this.pnlSidebar.Controls.Add(this.btnNavProfil);
            this.pnlSidebar.Controls.Add(this.pnlUserCard);
            this.pnlSidebar.Controls.Add(this.btnKeluar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSidebar.Size = new System.Drawing.Size(220, 761);
            this.pnlSidebar.TabIndex = 0;
            // 
            // picLogo
            //
            this.picLogo.Image = System.Drawing.Image.FromFile(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources\\logo.png"));
            this.picLogo.Location = new System.Drawing.Point(30, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblRoleBadge
            // 
            this.lblRoleBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.lblRoleBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoleBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblRoleBadge.Location = new System.Drawing.Point(25, 98);
            this.lblRoleBadge.Name = "lblRoleBadge";
            this.lblRoleBadge.Size = new System.Drawing.Size(75, 20);
            this.lblRoleBadge.TabIndex = 1;
            this.lblRoleBadge.Text = "Pelanggan";
            this.lblRoleBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavKatalog
            // 
            this.btnNavKatalog.BackColor = System.Drawing.Color.Transparent;
            this.btnNavKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKatalog.FlatAppearance.BorderSize = 0;
            this.btnNavKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKatalog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavKatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavKatalog.Location = new System.Drawing.Point(15, 130);
            this.btnNavKatalog.Name = "btnNavKatalog";
            this.btnNavKatalog.Size = new System.Drawing.Size(188, 42);
            this.btnNavKatalog.TabIndex = 2;
            this.btnNavKatalog.Text = "🌿  Katalog";
            this.btnNavKatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavKatalog.UseVisualStyleBackColor = false;
            // 
            // btnNavKeranjang
            // 
            this.btnNavKeranjang.BackColor = System.Drawing.Color.Transparent;
            this.btnNavKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKeranjang.FlatAppearance.BorderSize = 0;
            this.btnNavKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKeranjang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavKeranjang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavKeranjang.Location = new System.Drawing.Point(15, 178);
            this.btnNavKeranjang.Name = "btnNavKeranjang";
            this.btnNavKeranjang.Size = new System.Drawing.Size(188, 42);
            this.btnNavKeranjang.TabIndex = 3;
            this.btnNavKeranjang.Text = "🛒  Keranjang";
            this.btnNavKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavKeranjang.UseVisualStyleBackColor = false;
            // 
            // btnNavRiwayat
            // 
            this.btnNavRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.btnNavRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRiwayat.FlatAppearance.BorderSize = 0;
            this.btnNavRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRiwayat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavRiwayat.Location = new System.Drawing.Point(15, 226);
            this.btnNavRiwayat.Name = "btnNavRiwayat";
            this.btnNavRiwayat.Size = new System.Drawing.Size(188, 42);
            this.btnNavRiwayat.TabIndex = 4;
            this.btnNavRiwayat.Text = "📋  Riwayat Pesanan";
            this.btnNavRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnNavProfil
            // 
            this.btnNavProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfil.FlatAppearance.BorderSize = 0;
            this.btnNavProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProfil.ForeColor = System.Drawing.Color.White;
            this.btnNavProfil.Location = new System.Drawing.Point(15, 274);
            this.btnNavProfil.Name = "btnNavProfil";
            this.btnNavProfil.Size = new System.Drawing.Size(188, 42);
            this.btnNavProfil.TabIndex = 5;
            this.btnNavProfil.Text = "👤  Profil";
            this.btnNavProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfil.UseVisualStyleBackColor = false;
            // 
            // pnlUserCard
            // 
            this.pnlUserCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUserCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(228)))));
            this.pnlUserCard.Controls.Add(this.lblAvatar);
            this.pnlUserCard.Controls.Add(this.lblUserName);
            this.pnlUserCard.Controls.Add(this.lblUserRole);
            this.pnlUserCard.Location = new System.Drawing.Point(15, 640);
            this.pnlUserCard.Name = "pnlUserCard";
            this.pnlUserCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlUserCard.Size = new System.Drawing.Size(188, 55);
            this.pnlUserCard.TabIndex = 6;
            // 
            // lblAvatar
            // 
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(200)))));
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblAvatar.Location = new System.Drawing.Point(8, 8);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 38);
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "P";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUserName.Location = new System.Drawing.Point(52, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Pelanggan";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblUserRole.Location = new System.Drawing.Point(52, 28);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(61, 13);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Pelanggan";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKeluar.Location = new System.Drawing.Point(15, 705);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(188, 35);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.Text = "🚪  Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.pnlCard);
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.pnlMain.Size = new System.Drawing.Size(964, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(30, 25);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(904, 65);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Profil Pelanggan";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(374, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Kelola data diri dan alamat pengiriman default untuk checkout.";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblInfoJoined);
            this.pnlCard.Controls.Add(this.btnSimpan);
            this.pnlCard.Controls.Add(this.lblAlamat);
            this.pnlCard.Controls.Add(this.txtAlamat);
            this.pnlCard.Controls.Add(this.lblTelepon);
            this.pnlCard.Controls.Add(this.txtTelepon);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblNama);
            this.pnlCard.Controls.Add(this.txtNama);
            this.pnlCard.Location = new System.Drawing.Point(30, 110);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(30);
            this.pnlCard.Size = new System.Drawing.Size(550, 480);
            this.pnlCard.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNama.Location = new System.Drawing.Point(30, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(95, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNama.Location = new System.Drawing.Point(30, 42);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(480, 26);
            this.txtNama.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email (tidak diubah)";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(30, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(480, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTelepon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTelepon.Location = new System.Drawing.Point(30, 150);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(81, 17);
            this.lblTelepon.TabIndex = 4;
            this.lblTelepon.Text = "No. Telepon";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTelepon.Location = new System.Drawing.Point(30, 172);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(480, 26);
            this.txtTelepon.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAlamat.Location = new System.Drawing.Point(30, 215);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(182, 17);
            this.lblAlamat.TabIndex = 6;
            this.lblAlamat.Text = "Alamat Pengiriman Default";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAlamat.Location = new System.Drawing.Point(30, 237);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(480, 90);
            this.txtAlamat.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(30, 350);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(180, 42);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // lblInfoJoined
            // 
            this.lblInfoJoined.AutoSize = true;
            this.lblInfoJoined.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblInfoJoined.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblInfoJoined.Location = new System.Drawing.Point(30, 420);
            this.lblInfoJoined.Name = "lblInfoJoined";
            this.lblInfoJoined.Size = new System.Drawing.Size(130, 15);
            this.lblInfoJoined.TabIndex = 9;
            this.lblInfoJoined.Text = "Bergabung sejak: -";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormProfil";
            this.Text = "Kala Rintik Tea — Profil Pelanggan";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRoleBadge;
        private System.Windows.Forms.Button btnNavKatalog;
        private System.Windows.Forms.Button btnNavKeranjang;
        private System.Windows.Forms.Button btnNavRiwayat;
        private System.Windows.Forms.Button btnNavProfil;
        private System.Windows.Forms.Panel pnlUserCard;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lblInfoJoined;
    }
}
