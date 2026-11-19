namespace KalaRintikTea.Forms
{
    partial class FormKeranjang
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
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.lblCheckoutTitle = new System.Windows.Forms.Label();
            this.lblAlamatLabel = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblMetodeLabel = new System.Windows.Forms.Label();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.rbDompetDigital = new System.Windows.Forms.RadioButton();
            this.lblCatatanLabel = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.lblSummaryBerat = new System.Windows.Forms.Label();
            this.lblSummaryOngkir = new System.Windows.Forms.Label();
            this.lblSummaryGrandTotal = new System.Windows.Forms.Label();
            this.btnBuatPesanan = new System.Windows.Forms.Button();
            this.pnlCartItemsContainer = new System.Windows.Forms.Panel();
            this.flowCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnLanjutBelanja = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.pnlCartItemsContainer.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
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
            this.btnNavKeranjang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKeranjang.FlatAppearance.BorderSize = 0;
            this.btnNavKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKeranjang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavKeranjang.ForeColor = System.Drawing.Color.White;
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
            this.pnlMain.Controls.Add(this.pnlCheckout);
            this.pnlMain.Controls.Add(this.pnlCartItemsContainer);
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.pnlMain.Size = new System.Drawing.Size(964, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCheckout.BackColor = System.Drawing.Color.White;
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Controls.Add(this.lblCheckoutTitle);
            this.pnlCheckout.Controls.Add(this.lblAlamatLabel);
            this.pnlCheckout.Controls.Add(this.txtAlamat);
            this.pnlCheckout.Controls.Add(this.lblMetodeLabel);
            this.pnlCheckout.Controls.Add(this.rbTransfer);
            this.pnlCheckout.Controls.Add(this.rbCod);
            this.pnlCheckout.Controls.Add(this.rbDompetDigital);
            this.pnlCheckout.Controls.Add(this.lblCatatanLabel);
            this.pnlCheckout.Controls.Add(this.txtCatatan);
            this.pnlCheckout.Controls.Add(this.lblSummarySubtotal);
            this.pnlCheckout.Controls.Add(this.lblSummaryBerat);
            this.pnlCheckout.Controls.Add(this.lblSummaryOngkir);
            this.pnlCheckout.Controls.Add(this.lblSummaryGrandTotal);
            this.pnlCheckout.Controls.Add(this.btnBuatPesanan);
            this.pnlCheckout.Location = new System.Drawing.Point(584, 90);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Padding = new System.Windows.Forms.Padding(20);
            this.pnlCheckout.Size = new System.Drawing.Size(350, 646);
            this.pnlCheckout.TabIndex = 2;
            // 
            // lblCheckoutTitle
            // 
            this.lblCheckoutTitle.AutoSize = true;
            this.lblCheckoutTitle.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblCheckoutTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblCheckoutTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCheckoutTitle.Name = "lblCheckoutTitle";
            this.lblCheckoutTitle.Size = new System.Drawing.Size(102, 23);
            this.lblCheckoutTitle.TabIndex = 0;
            this.lblCheckoutTitle.Text = "Checkout";
            // 
            // lblAlamatLabel
            // 
            this.lblAlamatLabel.AutoSize = true;
            this.lblAlamatLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlamatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAlamatLabel.Location = new System.Drawing.Point(20, 50);
            this.lblAlamatLabel.Name = "lblAlamatLabel";
            this.lblAlamatLabel.Size = new System.Drawing.Size(117, 15);
            this.lblAlamatLabel.TabIndex = 1;
            this.lblAlamatLabel.Text = "Alamat Pengiriman:";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAlamat.Location = new System.Drawing.Point(20, 70);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(308, 65);
            this.txtAlamat.TabIndex = 2;
            // 
            // lblMetodeLabel
            // 
            this.lblMetodeLabel.AutoSize = true;
            this.lblMetodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMetodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMetodeLabel.Location = new System.Drawing.Point(20, 145);
            this.lblMetodeLabel.Name = "lblMetodeLabel";
            this.lblMetodeLabel.Size = new System.Drawing.Size(126, 15);
            this.lblMetodeLabel.TabIndex = 3;
            this.lblMetodeLabel.Text = "Metode Pembayaran:";
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Checked = true;
            this.rbTransfer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbTransfer.Location = new System.Drawing.Point(25, 168);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(103, 21);
            this.rbTransfer.TabIndex = 4;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer Bank";
            this.rbTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbCod.Location = new System.Drawing.Point(25, 195);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(155, 21);
            this.rbCod.TabIndex = 5;
            this.rbCod.Text = "COD (Bayar di Tempat)";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // rbDompetDigital
            // 
            this.rbDompetDigital.AutoSize = true;
            this.rbDompetDigital.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbDompetDigital.Location = new System.Drawing.Point(25, 222);
            this.rbDompetDigital.Name = "rbDompetDigital";
            this.rbDompetDigital.Size = new System.Drawing.Size(175, 21);
            this.rbDompetDigital.TabIndex = 6;
            this.rbDompetDigital.Text = "Dompet Digital (QRIS/E-W)";
            this.rbDompetDigital.UseVisualStyleBackColor = true;
            // 
            // lblCatatanLabel
            // 
            this.lblCatatanLabel.AutoSize = true;
            this.lblCatatanLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCatatanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCatatanLabel.Location = new System.Drawing.Point(20, 255);
            this.lblCatatanLabel.Name = "lblCatatanLabel";
            this.lblCatatanLabel.Size = new System.Drawing.Size(107, 15);
            this.lblCatatanLabel.TabIndex = 7;
            this.lblCatatanLabel.Text = "Catatan (opsional):";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatatan.Location = new System.Drawing.Point(20, 275);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.PlaceholderText = "Tulis catatan untuk penjual...";
            this.txtCatatan.Size = new System.Drawing.Size(308, 24);
            this.txtCatatan.TabIndex = 8;
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummarySubtotal.AutoSize = true;
            this.lblSummarySubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSummarySubtotal.Location = new System.Drawing.Point(20, 480);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(89, 17);
            this.lblSummarySubtotal.TabIndex = 9;
            this.lblSummarySubtotal.Text = "Subtotal: Rp 0";
            // 
            // lblSummaryBerat
            // 
            this.lblSummaryBerat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummaryBerat.AutoSize = true;
            this.lblSummaryBerat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSummaryBerat.Location = new System.Drawing.Point(20, 505);
            this.lblSummaryBerat.Name = "lblSummaryBerat";
            this.lblSummaryBerat.Size = new System.Drawing.Size(103, 17);
            this.lblSummaryBerat.TabIndex = 10;
            this.lblSummaryBerat.Text = "Total berat: 0 g";
            // 
            // lblSummaryOngkir
            // 
            this.lblSummaryOngkir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummaryOngkir.AutoSize = true;
            this.lblSummaryOngkir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSummaryOngkir.Location = new System.Drawing.Point(20, 530);
            this.lblSummaryOngkir.Name = "lblSummaryOngkir";
            this.lblSummaryOngkir.Size = new System.Drawing.Size(155, 17);
            this.lblSummaryOngkir.TabIndex = 11;
            this.lblSummaryOngkir.Text = "Ongkir (Flat): Rp 10.000";
            // 
            // lblSummaryGrandTotal
            // 
            this.lblSummaryGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummaryGrandTotal.AutoSize = true;
            this.lblSummaryGrandTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblSummaryGrandTotal.Location = new System.Drawing.Point(20, 555);
            this.lblSummaryGrandTotal.Name = "lblSummaryGrandTotal";
            this.lblSummaryGrandTotal.Size = new System.Drawing.Size(147, 21);
            this.lblSummaryGrandTotal.TabIndex = 12;
            this.lblSummaryGrandTotal.Text = "Grand Total: Rp 0";
            // 
            // btnBuatPesanan
            // 
            this.btnBuatPesanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuatPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnBuatPesanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuatPesanan.FlatAppearance.BorderSize = 0;
            this.btnBuatPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuatPesanan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuatPesanan.ForeColor = System.Drawing.Color.White;
            this.btnBuatPesanan.Location = new System.Drawing.Point(20, 585);
            this.btnBuatPesanan.Name = "btnBuatPesanan";
            this.btnBuatPesanan.Size = new System.Drawing.Size(308, 45);
            this.btnBuatPesanan.TabIndex = 13;
            this.btnBuatPesanan.Text = "Buat Pesanan";
            this.btnBuatPesanan.UseVisualStyleBackColor = false;
            // 
            // pnlCartItemsContainer
            // 
            this.pnlCartItemsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCartItemsContainer.Controls.Add(this.flowCartItems);
            this.pnlCartItemsContainer.Controls.Add(this.lblNote);
            this.pnlCartItemsContainer.Location = new System.Drawing.Point(30, 90);
            this.pnlCartItemsContainer.Name = "pnlCartItemsContainer";
            this.pnlCartItemsContainer.Size = new System.Drawing.Size(538, 646);
            this.pnlCartItemsContainer.TabIndex = 1;
            // 
            // flowCartItems
            // 
            this.flowCartItems.AutoScroll = true;
            this.flowCartItems.BackColor = System.Drawing.Color.White;
            this.flowCartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCartItems.Location = new System.Drawing.Point(0, 0);
            this.flowCartItems.Name = "flowCartItems";
            this.flowCartItems.Padding = new System.Windows.Forms.Padding(12);
            this.flowCartItems.Size = new System.Drawing.Size(538, 616);
            this.flowCartItems.TabIndex = 0;
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblNote.Location = new System.Drawing.Point(0, 616);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new System.Windows.Forms.Padding(5);
            this.lblNote.Size = new System.Drawing.Size(538, 30);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Kuantitas dibatasi stok tersedia. Ongkir flat: Rp 10.000.";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Controls.Add(this.btnLanjutBelanja);
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
            this.lblTitle.Size = new System.Drawing.Size(262, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Keranjang Belanja";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(332, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Periksa pesananmu lalu lanjutkan ke proses checkout.";
            // 
            // btnLanjutBelanja
            // 
            this.btnLanjutBelanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLanjutBelanja.BackColor = System.Drawing.Color.White;
            this.btnLanjutBelanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanjutBelanja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnLanjutBelanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanjutBelanja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLanjutBelanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnLanjutBelanja.Location = new System.Drawing.Point(754, 10);
            this.btnLanjutBelanja.Name = "btnLanjutBelanja";
            this.btnLanjutBelanja.Size = new System.Drawing.Size(150, 42);
            this.btnLanjutBelanja.TabIndex = 2;
            this.btnLanjutBelanja.Text = "←  Lanjut Belanja";
            this.btnLanjutBelanja.UseVisualStyleBackColor = false;
            // 
            // FormKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormKeranjang";
            this.Text = "Kala Rintik Tea — Keranjang Belanja & Checkout";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.pnlCartItemsContainer.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
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
        private System.Windows.Forms.Button btnLanjutBelanja;
        private System.Windows.Forms.Panel pnlCartItemsContainer;
        private System.Windows.Forms.FlowLayoutPanel flowCartItems;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblCheckoutTitle;
        private System.Windows.Forms.Label lblAlamatLabel;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblMetodeLabel;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.RadioButton rbDompetDigital;
        private System.Windows.Forms.Label lblCatatanLabel;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label lblSummaryBerat;
        private System.Windows.Forms.Label lblSummaryOngkir;
        private System.Windows.Forms.Label lblSummaryGrandTotal;
        private System.Windows.Forms.Button btnBuatPesanan;
    }
}
