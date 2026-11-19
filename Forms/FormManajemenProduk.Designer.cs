namespace KalaRintikTea.Forms
{
    partial class FormManajemenProduk
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
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavDataBarang = new System.Windows.Forms.Button();
            this.btnNavTransaksi = new System.Windows.Forms.Button();
            this.btnNavPelanggan = new System.Windows.Forms.Button();
            this.btnNavUlasan = new System.Windows.Forms.Button();
            this.pnlUserCard = new System.Windows.Forms.Panel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblBerat = new System.Windows.Forms.Label();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.lblAsal = new System.Windows.Forms.Label();
            this.txtAsal = new System.Windows.Forms.TextBox();
            this.lblPathGambar = new System.Windows.Forms.Label();
            this.txtPathGambar = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnToggleActive = new System.Windows.Forms.Button();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterKategori = new System.Windows.Forms.ComboBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnTambahBaru = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlFilterBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.lblRoleBadge);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavDataBarang);
            this.pnlSidebar.Controls.Add(this.btnNavTransaksi);
            this.pnlSidebar.Controls.Add(this.btnNavPelanggan);
            this.pnlSidebar.Controls.Add(this.btnNavUlasan);
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
            this.lblRoleBadge.Size = new System.Drawing.Size(65, 20);
            this.lblRoleBadge.TabIndex = 1;
            this.lblRoleBadge.Text = "Admin";
            this.lblRoleBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavDashboard.Location = new System.Drawing.Point(15, 130);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(188, 42);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "📊  Dashboard Admin";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            // 
            // btnNavDataBarang
            // 
            this.btnNavDataBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavDataBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDataBarang.FlatAppearance.BorderSize = 0;
            this.btnNavDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDataBarang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDataBarang.ForeColor = System.Drawing.Color.White;
            this.btnNavDataBarang.Location = new System.Drawing.Point(15, 178);
            this.btnNavDataBarang.Name = "btnNavDataBarang";
            this.btnNavDataBarang.Size = new System.Drawing.Size(188, 42);
            this.btnNavDataBarang.TabIndex = 3;
            this.btnNavDataBarang.Text = "📦  Data Barang";
            this.btnNavDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDataBarang.UseVisualStyleBackColor = false;
            // 
            // btnNavTransaksi
            // 
            this.btnNavTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransaksi.FlatAppearance.BorderSize = 0;
            this.btnNavTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavTransaksi.Location = new System.Drawing.Point(15, 226);
            this.btnNavTransaksi.Name = "btnNavTransaksi";
            this.btnNavTransaksi.Size = new System.Drawing.Size(188, 42);
            this.btnNavTransaksi.TabIndex = 4;
            this.btnNavTransaksi.Text = "📑  Transaksi";
            this.btnNavTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnNavPelanggan
            // 
            this.btnNavPelanggan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPelanggan.FlatAppearance.BorderSize = 0;
            this.btnNavPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavPelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavPelanggan.Location = new System.Drawing.Point(15, 274);
            this.btnNavPelanggan.Name = "btnNavPelanggan";
            this.btnNavPelanggan.Size = new System.Drawing.Size(188, 42);
            this.btnNavPelanggan.TabIndex = 5;
            this.btnNavPelanggan.Text = "👥  Data Pelanggan";
            this.btnNavPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPelanggan.UseVisualStyleBackColor = false;
            // 
            // btnNavUlasan
            // 
            this.btnNavUlasan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUlasan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUlasan.FlatAppearance.BorderSize = 0;
            this.btnNavUlasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUlasan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavUlasan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavUlasan.Location = new System.Drawing.Point(15, 322);
            this.btnNavUlasan.Name = "btnNavUlasan";
            this.btnNavUlasan.Size = new System.Drawing.Size(188, 42);
            this.btnNavUlasan.TabIndex = 6;
            this.btnNavUlasan.Text = "💬  Ulasan Produk";
            this.btnNavUlasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUlasan.UseVisualStyleBackColor = false;
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
            this.pnlUserCard.TabIndex = 7;
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
            this.lblAvatar.Text = "A";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUserName.Location = new System.Drawing.Point(52, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(49, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Admin";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblUserRole.Location = new System.Drawing.Point(52, 28);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(40, 13);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Admin";
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
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "🚪  Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.pnlEditor);
            this.pnlMain.Controls.Add(this.pnlTableContainer);
            this.pnlMain.Controls.Add(this.pnlFilterBar);
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.pnlMain.Size = new System.Drawing.Size(964, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.lblEditorTitle);
            this.pnlEditor.Controls.Add(this.lblNama);
            this.pnlEditor.Controls.Add(this.txtNama);
            this.pnlEditor.Controls.Add(this.lblDeskripsi);
            this.pnlEditor.Controls.Add(this.txtDeskripsi);
            this.pnlEditor.Controls.Add(this.lblKategori);
            this.pnlEditor.Controls.Add(this.cmbKategori);
            this.pnlEditor.Controls.Add(this.lblHarga);
            this.pnlEditor.Controls.Add(this.txtHarga);
            this.pnlEditor.Controls.Add(this.lblStok);
            this.pnlEditor.Controls.Add(this.txtStok);
            this.pnlEditor.Controls.Add(this.lblBerat);
            this.pnlEditor.Controls.Add(this.txtBerat);
            this.pnlEditor.Controls.Add(this.lblAsal);
            this.pnlEditor.Controls.Add(this.txtAsal);
            this.pnlEditor.Controls.Add(this.lblPathGambar);
            this.pnlEditor.Controls.Add(this.txtPathGambar);
            this.pnlEditor.Controls.Add(this.btnSimpan);
            this.pnlEditor.Controls.Add(this.btnToggleActive);
            this.pnlEditor.Location = new System.Drawing.Point(624, 140);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Padding = new System.Windows.Forms.Padding(18);
            this.pnlEditor.Size = new System.Drawing.Size(310, 596);
            this.pnlEditor.TabIndex = 3;
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.AutoSize = true;
            this.lblEditorTitle.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblEditorTitle.Location = new System.Drawing.Point(18, 15);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Size = new System.Drawing.Size(130, 21);
            this.lblEditorTitle.TabIndex = 0;
            this.lblEditorTitle.Text = "Ubah Produk";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.Location = new System.Drawing.Point(18, 48);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(83, 15);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Produk:";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.Location = new System.Drawing.Point(18, 66);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(270, 24);
            this.txtNama.TabIndex = 2;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDeskripsi.Location = new System.Drawing.Point(18, 98);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(61, 15);
            this.lblDeskripsi.TabIndex = 3;
            this.lblDeskripsi.Text = "Deskripsi:";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDeskripsi.Location = new System.Drawing.Point(18, 116);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(270, 55);
            this.txtDeskripsi.TabIndex = 4;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(18, 180);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 15);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(18, 198);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(270, 25);
            this.cmbKategori.TabIndex = 6;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHarga.Location = new System.Drawing.Point(18, 235);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(67, 15);
            this.lblHarga.TabIndex = 7;
            this.lblHarga.Text = "Harga (Rp):";
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHarga.Location = new System.Drawing.Point(18, 253);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(125, 24);
            this.txtHarga.TabIndex = 8;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStok.Location = new System.Drawing.Point(163, 235);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(35, 15);
            this.lblStok.TabIndex = 9;
            this.lblStok.Text = "Stok:";
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtStok.Location = new System.Drawing.Point(163, 253);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(125, 24);
            this.txtStok.TabIndex = 10;
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBerat.Location = new System.Drawing.Point(18, 288);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(76, 15);
            this.lblBerat.TabIndex = 11;
            this.lblBerat.Text = "Berat (gram):";
            // 
            // txtBerat
            // 
            this.txtBerat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBerat.Location = new System.Drawing.Point(18, 306);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(125, 24);
            this.txtBerat.TabIndex = 12;
            // 
            // lblAsal
            // 
            this.lblAsal.AutoSize = true;
            this.lblAsal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAsal.Location = new System.Drawing.Point(163, 288);
            this.lblAsal.Name = "lblAsal";
            this.lblAsal.Size = new System.Drawing.Size(73, 15);
            this.lblAsal.TabIndex = 13;
            this.lblAsal.Text = "Asal Daerah:";
            // 
            // txtAsal
            // 
            this.txtAsal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAsal.Location = new System.Drawing.Point(163, 306);
            this.txtAsal.Name = "txtAsal";
            this.txtAsal.Size = new System.Drawing.Size(125, 24);
            this.txtAsal.TabIndex = 14;
            // 
            // lblPathGambar
            // 
            this.lblPathGambar.AutoSize = true;
            this.lblPathGambar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPathGambar.Location = new System.Drawing.Point(18, 340);
            this.lblPathGambar.Name = "lblPathGambar";
            this.lblPathGambar.Size = new System.Drawing.Size(81, 15);
            this.lblPathGambar.TabIndex = 15;
            this.lblPathGambar.Text = "Path Gambar:";
            // 
            // txtPathGambar
            // 
            this.txtPathGambar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPathGambar.Location = new System.Drawing.Point(18, 358);
            this.txtPathGambar.Name = "txtPathGambar";
            this.txtPathGambar.PlaceholderText = "C:\\KalaRintik\\img\\hijau.png";
            this.txtPathGambar.Size = new System.Drawing.Size(270, 24);
            this.txtPathGambar.TabIndex = 16;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(18, 410);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(145, 38);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnToggleActive
            // 
            this.btnToggleActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleActive.FlatAppearance.BorderSize = 0;
            this.btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleActive.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnToggleActive.Location = new System.Drawing.Point(170, 410);
            this.btnToggleActive.Name = "btnToggleActive";
            this.btnToggleActive.Size = new System.Drawing.Size(118, 38);
            this.btnToggleActive.TabIndex = 18;
            this.btnToggleActive.Text = "Nonaktifkan";
            this.btnToggleActive.UseVisualStyleBackColor = false;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.Controls.Add(this.dgvProducts);
            this.pnlTableContainer.Location = new System.Drawing.Point(30, 140);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(578, 596);
            this.pnlTableContainer.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(578, 596);
            this.dgvProducts.TabIndex = 0;
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.Controls.Add(this.txtSearch);
            this.pnlFilterBar.Controls.Add(this.cmbFilterKategori);
            this.pnlFilterBar.Controls.Add(this.cmbFilterStatus);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(30, 90);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(904, 45);
            this.pnlFilterBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Cari nama, deskripsi, atau asal daerah...";
            this.txtSearch.Size = new System.Drawing.Size(540, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbFilterKategori
            // 
            this.cmbFilterKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterKategori.FormattingEnabled = true;
            this.cmbFilterKategori.Location = new System.Drawing.Point(555, 8);
            this.cmbFilterKategori.Name = "cmbFilterKategori";
            this.cmbFilterKategori.Size = new System.Drawing.Size(180, 25);
            this.cmbFilterKategori.TabIndex = 1;
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Status: Semua",
            "Status: Aktif",
            "Status: Nonaktif"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(745, 8);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(159, 25);
            this.cmbFilterStatus.TabIndex = 2;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Controls.Add(this.btnTambahBaru);
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
            this.lblTitle.Size = new System.Drawing.Size(326, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manajemen Data Barang";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(387, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Kelola katalog teh: tambah, ubah, dan nonaktifkan produk (soft delete).";
            // 
            // btnTambahBaru
            // 
            this.btnTambahBaru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambahBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnTambahBaru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahBaru.FlatAppearance.BorderSize = 0;
            this.btnTambahBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBaru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTambahBaru.ForeColor = System.Drawing.Color.White;
            this.btnTambahBaru.Location = new System.Drawing.Point(744, 10);
            this.btnTambahBaru.Name = "btnTambahBaru";
            this.btnTambahBaru.Size = new System.Drawing.Size(160, 42);
            this.btnTambahBaru.TabIndex = 2;
            this.btnTambahBaru.Text = "+  Tambah Produk";
            this.btnTambahBaru.UseVisualStyleBackColor = false;
            // 
            // FormManajemenProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormManajemenProduk";
            this.Text = "Kala Rintik Tea — Manajemen Data Barang";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRoleBadge;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavDataBarang;
        private System.Windows.Forms.Button btnNavTransaksi;
        private System.Windows.Forms.Button btnNavPelanggan;
        private System.Windows.Forms.Button btnNavUlasan;
        private System.Windows.Forms.Panel pnlUserCard;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnTambahBaru;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterKategori;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label lblAsal;
        private System.Windows.Forms.TextBox txtAsal;
        private System.Windows.Forms.Label lblPathGambar;
        private System.Windows.Forms.TextBox txtPathGambar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnToggleActive;
    }
}
