namespace KalaRintikTea.Forms
{
    partial class FormTransaksiAdmin
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
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailKode = new System.Windows.Forms.Label();
            this.lblDetailStatusBadge = new System.Windows.Forms.Label();
            this.lblStepper = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.flowDetailItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.btnAdvanceStatus = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterMetode = new System.Windows.Forms.ComboBox();
            this.flowStatusTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.btnNavDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.btnNavDataBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDataBarang.FlatAppearance.BorderSize = 0;
            this.btnNavDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDataBarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavDataBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
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
            this.btnNavTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransaksi.FlatAppearance.BorderSize = 0;
            this.btnNavTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavTransaksi.ForeColor = System.Drawing.Color.White;
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
            this.pnlMain.Controls.Add(this.pnlDetail);
            this.pnlMain.Controls.Add(this.pnlTableContainer);
            this.pnlMain.Controls.Add(this.pnlFilterBar);
            this.pnlMain.Controls.Add(this.flowStatusTabs);
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.pnlMain.Size = new System.Drawing.Size(964, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetail.Controls.Add(this.lblDetailTitle);
            this.pnlDetail.Controls.Add(this.lblDetailKode);
            this.pnlDetail.Controls.Add(this.lblDetailStatusBadge);
            this.pnlDetail.Controls.Add(this.lblStepper);
            this.pnlDetail.Controls.Add(this.lblCustomerInfo);
            this.pnlDetail.Controls.Add(this.flowDetailItems);
            this.pnlDetail.Controls.Add(this.lblSummary);
            this.pnlDetail.Controls.Add(this.lblPaymentInfo);
            this.pnlDetail.Controls.Add(this.btnAdvanceStatus);
            this.pnlDetail.Controls.Add(this.btnCancelOrder);
            this.pnlDetail.Location = new System.Drawing.Point(574, 180);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Padding = new System.Windows.Forms.Padding(18);
            this.pnlDetail.Size = new System.Drawing.Size(360, 556);
            this.pnlDetail.TabIndex = 4;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(18, 12);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(150, 23);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "Detail Pesanan";
            // 
            // lblDetailKode
            // 
            this.lblDetailKode.AutoSize = true;
            this.lblDetailKode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailKode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDetailKode.Location = new System.Drawing.Point(18, 38);
            this.lblDetailKode.Name = "lblDetailKode";
            this.lblDetailKode.Size = new System.Drawing.Size(161, 15);
            this.lblDetailKode.TabIndex = 1;
            this.lblDetailKode.Text = "Pilih pesanan untuk melihat";
            // 
            // lblDetailStatusBadge
            // 
            this.lblDetailStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetailStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblDetailStatusBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDetailStatusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblDetailStatusBadge.Location = new System.Drawing.Point(255, 12);
            this.lblDetailStatusBadge.Name = "lblDetailStatusBadge";
            this.lblDetailStatusBadge.Size = new System.Drawing.Size(85, 24);
            this.lblDetailStatusBadge.TabIndex = 2;
            this.lblDetailStatusBadge.Text = "Menunggu";
            this.lblDetailStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStepper
            // 
            this.lblStepper.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStepper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblStepper.Location = new System.Drawing.Point(18, 62);
            this.lblStepper.Name = "lblStepper";
            this.lblStepper.Size = new System.Drawing.Size(322, 22);
            this.lblStepper.TabIndex = 3;
            this.lblStepper.Text = "Menunggu ➔ Diproses ➔ Dikirim ➔ Selesai";
            this.lblStepper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCustomerInfo.Location = new System.Drawing.Point(18, 90);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(322, 45);
            this.lblCustomerInfo.TabIndex = 4;
            this.lblCustomerInfo.Text = "Pelanggan:\nAlamat:";
            // 
            // flowDetailItems
            // 
            this.flowDetailItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowDetailItems.AutoScroll = true;
            this.flowDetailItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDetailItems.Location = new System.Drawing.Point(18, 140);
            this.flowDetailItems.Name = "flowDetailItems";
            this.flowDetailItems.Padding = new System.Windows.Forms.Padding(6);
            this.flowDetailItems.Size = new System.Drawing.Size(322, 190);
            this.flowDetailItems.TabIndex = 5;
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSummary.Location = new System.Drawing.Point(18, 340);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(193, 51);
            this.lblSummary.TabIndex = 6;
            this.lblSummary.Text = "Subtotal: Rp 0\nOngkir: Rp 0\nGrand Total: Rp 0";
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblPaymentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPaymentInfo.Location = new System.Drawing.Point(18, 400);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(209, 15);
            this.lblPaymentInfo.TabIndex = 7;
            this.lblPaymentInfo.Text = "Transfer · Status: Belum Lunas";
            // 
            // btnAdvanceStatus
            // 
            this.btnAdvanceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnAdvanceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanceStatus.FlatAppearance.BorderSize = 0;
            this.btnAdvanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanceStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdvanceStatus.ForeColor = System.Drawing.Color.White;
            this.btnAdvanceStatus.Location = new System.Drawing.Point(18, 430);
            this.btnAdvanceStatus.Name = "btnAdvanceStatus";
            this.btnAdvanceStatus.Size = new System.Drawing.Size(322, 40);
            this.btnAdvanceStatus.TabIndex = 8;
            this.btnAdvanceStatus.Text = "✓  Ubah status ➔ Diproses";
            this.btnAdvanceStatus.UseVisualStyleBackColor = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelOrder.Location = new System.Drawing.Point(18, 480);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(322, 35);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "Batalkan Pesanan (stok dikembalikan)";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.Controls.Add(this.dgvOrders);
            this.pnlTableContainer.Location = new System.Drawing.Point(30, 180);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(528, 556);
            this.pnlTableContainer.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(528, 556);
            this.dgvOrders.TabIndex = 0;
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.Controls.Add(this.txtSearch);
            this.pnlFilterBar.Controls.Add(this.cmbFilterMetode);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(30, 135);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(904, 45);
            this.pnlFilterBar.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Cari kode pesanan atau nama...";
            this.txtSearch.Size = new System.Drawing.Size(700, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbFilterMetode
            // 
            this.cmbFilterMetode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterMetode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterMetode.FormattingEnabled = true;
            this.cmbFilterMetode.Items.AddRange(new object[] {
            "Metode: Semua",
            "Transfer",
            "COD",
            "Dompet Digital"});
            this.cmbFilterMetode.Location = new System.Drawing.Point(720, 8);
            this.cmbFilterMetode.Name = "cmbFilterMetode";
            this.cmbFilterMetode.Size = new System.Drawing.Size(184, 25);
            this.cmbFilterMetode.TabIndex = 1;
            // 
            // flowStatusTabs
            // 
            this.flowStatusTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowStatusTabs.Location = new System.Drawing.Point(30, 90);
            this.flowStatusTabs.Name = "flowStatusTabs";
            this.flowStatusTabs.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowStatusTabs.Size = new System.Drawing.Size(904, 45);
            this.flowStatusTabs.TabIndex = 1;
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
            this.lblTitle.Size = new System.Drawing.Size(155, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaksi";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(378, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Pantau pesanan semua pelanggan dan kelola alur status pesanan.";
            // 
            // FormTransaksiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormTransaksiAdmin";
            this.Text = "Kala Rintik Tea — Transaksi";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowStatusTabs;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterMetode;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailKode;
        private System.Windows.Forms.Label lblDetailStatusBadge;
        private System.Windows.Forms.Label lblStepper;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.FlowLayoutPanel flowDetailItems;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.Button btnAdvanceStatus;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}
