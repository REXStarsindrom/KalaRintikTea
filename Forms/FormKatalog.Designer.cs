namespace KalaRintikTea.Forms
{
    partial class FormKatalog
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnHeaderCart = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.pnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlFilters.SuspendLayout();
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
            this.btnNavKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKatalog.FlatAppearance.BorderSize = 0;
            this.btnNavKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKatalog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavKatalog.ForeColor = System.Drawing.Color.White;
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
            this.btnNavProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnNavProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfil.FlatAppearance.BorderSize = 0;
            this.btnNavProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
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
            this.pnlMain.Controls.Add(this.flowProducts);
            this.pnlMain.Controls.Add(this.pnlCategories);
            this.pnlMain.Controls.Add(this.pnlFilters);
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
            this.pnlTopBar.Controls.Add(this.lblGreeting);
            this.pnlTopBar.Controls.Add(this.btnHeaderCart);
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
            this.lblTitle.Size = new System.Drawing.Size(183, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Katalog Teh";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblGreeting.Location = new System.Drawing.Point(2, 38);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(262, 17);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Halo! Temukan teh lokal pilihanmu hari ini.";
            // 
            // btnHeaderCart
            // 
            this.btnHeaderCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnHeaderCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderCart.FlatAppearance.BorderSize = 0;
            this.btnHeaderCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHeaderCart.ForeColor = System.Drawing.Color.White;
            this.btnHeaderCart.Location = new System.Drawing.Point(734, 10);
            this.btnHeaderCart.Name = "btnHeaderCart";
            this.btnHeaderCart.Size = new System.Drawing.Size(170, 42);
            this.btnHeaderCart.TabIndex = 2;
            this.btnHeaderCart.Text = "🛒  Keranjang · 0 item";
            this.btnHeaderCart.UseVisualStyleBackColor = false;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.cmbSort);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(30, 90);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(904, 45);
            this.pnlFilters.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Cari nama, deskripsi, atau asal daerah...";
            this.txtSearch.Size = new System.Drawing.Size(680, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Urutkan: Rating tertinggi",
            "Urutkan: Harga terendah",
            "Urutkan: Harga tertinggi",
            "Urutkan: Nama A-Z"});
            this.cmbSort.Location = new System.Drawing.Point(700, 8);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(204, 25);
            this.cmbSort.TabIndex = 1;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(30, 135);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.pnlCategories.Size = new System.Drawing.Size(904, 45);
            this.pnlCategories.TabIndex = 2;
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProducts.Location = new System.Drawing.Point(30, 180);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowProducts.Size = new System.Drawing.Size(904, 556);
            this.flowProducts.TabIndex = 3;
            // 
            // FormKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormKatalog";
            this.Text = "Kala Rintik Tea — Katalog Teh";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
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
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnHeaderCart;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.FlowLayoutPanel pnlCategories;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
    }
}
