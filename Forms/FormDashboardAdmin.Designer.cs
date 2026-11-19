namespace KalaRintikTea.Forms
{
    partial class FormDashboardAdmin
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
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.pnlStatusCounts = new System.Windows.Forms.Panel();
            this.lblStatusCountTitle = new System.Windows.Forms.Label();
            this.lblCountMenunggu = new System.Windows.Forms.Label();
            this.lblCountDiproses = new System.Windows.Forms.Label();
            this.lblCountDikirim = new System.Windows.Forms.Label();
            this.lblCountSelesai = new System.Windows.Forms.Label();
            this.lblCountDibatalkan = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.flowLowStock = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeftContent = new System.Windows.Forms.Panel();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lblRecentOrdersTitle = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.pnlRecentReviews = new System.Windows.Forms.Panel();
            this.lblRecentReviewsTitle = new System.Windows.Forms.Label();
            this.flowRecentReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatsRow = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Value = new System.Windows.Forms.Label();
            this.lblStat1Sub = new System.Windows.Forms.Label();
            this.lblStat1Title = new System.Windows.Forms.Label();
            this.pnlStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Value = new System.Windows.Forms.Label();
            this.lblStat2Sub = new System.Windows.Forms.Label();
            this.lblStat2Title = new System.Windows.Forms.Label();
            this.pnlStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Value = new System.Windows.Forms.Label();
            this.lblStat3Sub = new System.Windows.Forms.Label();
            this.lblStat3Title = new System.Windows.Forms.Label();
            this.pnlStat4 = new System.Windows.Forms.Panel();
            this.lblStat4Value = new System.Windows.Forms.Label();
            this.lblStat4Sub = new System.Windows.Forms.Label();
            this.lblStat4Title = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRightSide.SuspendLayout();
            this.pnlStatusCounts.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlLeftContent.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.pnlRecentReviews.SuspendLayout();
            this.pnlStatsRow.SuspendLayout();
            this.pnlStat1.SuspendLayout();
            this.pnlStat2.SuspendLayout();
            this.pnlStat3.SuspendLayout();
            this.pnlStat4.SuspendLayout();
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
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
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
            this.pnlMain.Controls.Add(this.pnlRightSide);
            this.pnlMain.Controls.Add(this.pnlLeftContent);
            this.pnlMain.Controls.Add(this.pnlStatsRow);
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.pnlMain.Size = new System.Drawing.Size(964, 761);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightSide.Controls.Add(this.pnlStatusCounts);
            this.pnlRightSide.Controls.Add(this.pnlLowStock);
            this.pnlRightSide.Location = new System.Drawing.Point(674, 195);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Size = new System.Drawing.Size(260, 541);
            this.pnlRightSide.TabIndex = 3;
            // 
            // pnlStatusCounts
            // 
            this.pnlStatusCounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatusCounts.BackColor = System.Drawing.Color.White;
            this.pnlStatusCounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatusCounts.Controls.Add(this.lblStatusCountTitle);
            this.pnlStatusCounts.Controls.Add(this.lblCountMenunggu);
            this.pnlStatusCounts.Controls.Add(this.lblCountDiproses);
            this.pnlStatusCounts.Controls.Add(this.lblCountDikirim);
            this.pnlStatusCounts.Controls.Add(this.lblCountSelesai);
            this.pnlStatusCounts.Controls.Add(this.lblCountDibatalkan);
            this.pnlStatusCounts.Location = new System.Drawing.Point(0, 220);
            this.pnlStatusCounts.Name = "pnlStatusCounts";
            this.pnlStatusCounts.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStatusCounts.Size = new System.Drawing.Size(260, 260);
            this.pnlStatusCounts.TabIndex = 1;
            // 
            // lblStatusCountTitle
            // 
            this.lblStatusCountTitle.AutoSize = true;
            this.lblStatusCountTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStatusCountTitle.Location = new System.Drawing.Point(15, 12);
            this.lblStatusCountTitle.Name = "lblStatusCountTitle";
            this.lblStatusCountTitle.Size = new System.Drawing.Size(130, 19);
            this.lblStatusCountTitle.TabIndex = 0;
            this.lblStatusCountTitle.Text = "Pesanan per Status";
            // 
            // lblCountMenunggu
            // 
            this.lblCountMenunggu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblCountMenunggu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountMenunggu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblCountMenunggu.Location = new System.Drawing.Point(15, 45);
            this.lblCountMenunggu.Name = "lblCountMenunggu";
            this.lblCountMenunggu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountMenunggu.Size = new System.Drawing.Size(228, 30);
            this.lblCountMenunggu.TabIndex = 1;
            this.lblCountMenunggu.Text = "Menunggu: 0";
            this.lblCountMenunggu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountDiproses
            // 
            this.lblCountDiproses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblCountDiproses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountDiproses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            this.lblCountDiproses.Location = new System.Drawing.Point(15, 82);
            this.lblCountDiproses.Name = "lblCountDiproses";
            this.lblCountDiproses.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountDiproses.Size = new System.Drawing.Size(228, 30);
            this.lblCountDiproses.TabIndex = 2;
            this.lblCountDiproses.Text = "Diproses: 0";
            this.lblCountDiproses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountDikirim
            // 
            this.lblCountDikirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblCountDikirim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountDikirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            this.lblCountDikirim.Location = new System.Drawing.Point(15, 119);
            this.lblCountDikirim.Name = "lblCountDikirim";
            this.lblCountDikirim.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountDikirim.Size = new System.Drawing.Size(228, 30);
            this.lblCountDikirim.TabIndex = 3;
            this.lblCountDikirim.Text = "Dikirim: 0";
            this.lblCountDikirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountSelesai
            // 
            this.lblCountSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.lblCountSelesai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblCountSelesai.Location = new System.Drawing.Point(15, 156);
            this.lblCountSelesai.Name = "lblCountSelesai";
            this.lblCountSelesai.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountSelesai.Size = new System.Drawing.Size(228, 30);
            this.lblCountSelesai.TabIndex = 4;
            this.lblCountSelesai.Text = "Selesai: 0";
            this.lblCountSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountDibatalkan
            // 
            this.lblCountDibatalkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblCountDibatalkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountDibatalkan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblCountDibatalkan.Location = new System.Drawing.Point(15, 193);
            this.lblCountDibatalkan.Name = "lblCountDibatalkan";
            this.lblCountDibatalkan.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCountDibatalkan.Size = new System.Drawing.Size(228, 30);
            this.lblCountDibatalkan.TabIndex = 5;
            this.lblCountDibatalkan.Text = "Dibatalkan: 0";
            this.lblCountDibatalkan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.flowLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(0, 0);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLowStock.Size = new System.Drawing.Size(260, 205);
            this.pnlLowStock.TabIndex = 0;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(15, 12);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(100, 19);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "⚠️ Stok Menipis";
            // 
            // flowLowStock
            // 
            this.flowLowStock.AutoScroll = true;
            this.flowLowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLowStock.Location = new System.Drawing.Point(15, 40);
            this.flowLowStock.Name = "flowLowStock";
            this.flowLowStock.Size = new System.Drawing.Size(228, 148);
            this.flowLowStock.TabIndex = 1;
            // 
            // pnlLeftContent
            // 
            this.pnlLeftContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeftContent.Controls.Add(this.pnlRecentOrders);
            this.pnlLeftContent.Controls.Add(this.pnlRecentReviews);
            this.pnlLeftContent.Location = new System.Drawing.Point(30, 195);
            this.pnlLeftContent.Name = "pnlLeftContent";
            this.pnlLeftContent.Size = new System.Drawing.Size(628, 541);
            this.pnlLeftContent.TabIndex = 2;
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.BackColor = System.Drawing.Color.White;
            this.pnlRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrdersTitle);
            this.pnlRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Padding = new System.Windows.Forms.Padding(15);
            this.pnlRecentOrders.Size = new System.Drawing.Size(628, 290);
            this.pnlRecentOrders.TabIndex = 0;
            // 
            // lblRecentOrdersTitle
            // 
            this.lblRecentOrdersTitle.AutoSize = true;
            this.lblRecentOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRecentOrdersTitle.Location = new System.Drawing.Point(15, 12);
            this.lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            this.lblRecentOrdersTitle.Size = new System.Drawing.Size(186, 20);
            this.lblRecentOrdersTitle.TabIndex = 0;
            this.lblRecentOrdersTitle.Text = "Aktivitas Transaksi Terkini";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecentOrders.Location = new System.Drawing.Point(15, 42);
            this.dgvRecentOrders.MultiSelect = false;
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersVisible = false;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(596, 231);
            this.dgvRecentOrders.TabIndex = 1;
            // 
            // pnlRecentReviews
            // 
            this.pnlRecentReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentReviews.BackColor = System.Drawing.Color.White;
            this.pnlRecentReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentReviews.Controls.Add(this.lblRecentReviewsTitle);
            this.pnlRecentReviews.Controls.Add(this.flowRecentReviews);
            this.pnlRecentReviews.Location = new System.Drawing.Point(0, 305);
            this.pnlRecentReviews.Name = "pnlRecentReviews";
            this.pnlRecentReviews.Padding = new System.Windows.Forms.Padding(15);
            this.pnlRecentReviews.Size = new System.Drawing.Size(628, 236);
            this.pnlRecentReviews.TabIndex = 1;
            // 
            // lblRecentReviewsTitle
            // 
            this.lblRecentReviewsTitle.AutoSize = true;
            this.lblRecentReviewsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentReviewsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRecentReviewsTitle.Location = new System.Drawing.Point(15, 12);
            this.lblRecentReviewsTitle.Name = "lblRecentReviewsTitle";
            this.lblRecentReviewsTitle.Size = new System.Drawing.Size(117, 20);
            this.lblRecentReviewsTitle.TabIndex = 0;
            this.lblRecentReviewsTitle.Text = "Ulasan Terbaru";
            // 
            // flowRecentReviews
            // 
            this.flowRecentReviews.AutoScroll = true;
            this.flowRecentReviews.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRecentReviews.Location = new System.Drawing.Point(15, 42);
            this.flowRecentReviews.Name = "flowRecentReviews";
            this.flowRecentReviews.Size = new System.Drawing.Size(596, 177);
            this.flowRecentReviews.TabIndex = 1;
            // 
            // pnlStatsRow
            // 
            this.pnlStatsRow.ColumnCount = 4;
            this.pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlStatsRow.Controls.Add(this.pnlStat1, 0, 0);
            this.pnlStatsRow.Controls.Add(this.pnlStat2, 1, 0);
            this.pnlStatsRow.Controls.Add(this.pnlStat3, 2, 0);
            this.pnlStatsRow.Controls.Add(this.pnlStat4, 3, 0);
            this.pnlStatsRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsRow.Location = new System.Drawing.Point(30, 90);
            this.pnlStatsRow.Name = "pnlStatsRow";
            this.pnlStatsRow.RowCount = 1;
            this.pnlStatsRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStatsRow.Size = new System.Drawing.Size(904, 95);
            this.pnlStatsRow.TabIndex = 1;
            // 
            // pnlStat1
            // 
            this.pnlStat1.BackColor = System.Drawing.Color.White;
            this.pnlStat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat1.Controls.Add(this.lblStat1Value);
            this.pnlStat1.Controls.Add(this.lblStat1Sub);
            this.pnlStat1.Controls.Add(this.lblStat1Title);
            this.pnlStat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStat1.Location = new System.Drawing.Point(3, 3);
            this.pnlStat1.Name = "pnlStat1";
            this.pnlStat1.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStat1.Size = new System.Drawing.Size(220, 89);
            this.pnlStat1.TabIndex = 0;
            // 
            // lblStat1Value
            // 
            this.lblStat1Value.AutoSize = true;
            this.lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStat1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblStat1Value.Location = new System.Drawing.Point(10, 32);
            this.lblStat1Value.Name = "lblStat1Value";
            this.lblStat1Value.Size = new System.Drawing.Size(51, 25);
            this.lblStat1Value.TabIndex = 1;
            this.lblStat1Value.Text = "Rp 0";
            // 
            // lblStat1Sub
            // 
            this.lblStat1Sub.AutoSize = true;
            this.lblStat1Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStat1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblStat1Sub.Location = new System.Drawing.Point(12, 60);
            this.lblStat1Sub.Name = "lblStat1Sub";
            this.lblStat1Sub.Size = new System.Drawing.Size(127, 12);
            this.lblStat1Sub.TabIndex = 2;
            this.lblStat1Sub.Text = "Dari pesanan berstatus Selesai";
            // 
            // lblStat1Title
            // 
            this.lblStat1Title.AutoSize = true;
            this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStat1Title.Location = new System.Drawing.Point(10, 10);
            this.lblStat1Title.Name = "lblStat1Title";
            this.lblStat1Title.Size = new System.Drawing.Size(100, 15);
            this.lblStat1Title.TabIndex = 0;
            this.lblStat1Title.Text = "Total Pendapatan";
            // 
            // pnlStat2
            // 
            this.pnlStat2.BackColor = System.Drawing.Color.White;
            this.pnlStat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat2.Controls.Add(this.lblStat2Value);
            this.pnlStat2.Controls.Add(this.lblStat2Sub);
            this.pnlStat2.Controls.Add(this.lblStat2Title);
            this.pnlStat2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStat2.Location = new System.Drawing.Point(229, 3);
            this.pnlStat2.Name = "pnlStat2";
            this.pnlStat2.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStat2.Size = new System.Drawing.Size(220, 89);
            this.pnlStat2.TabIndex = 1;
            // 
            // lblStat2Value
            // 
            this.lblStat2Value.AutoSize = true;
            this.lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStat2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblStat2Value.Location = new System.Drawing.Point(10, 32);
            this.lblStat2Value.Name = "lblStat2Value";
            this.lblStat2Value.Size = new System.Drawing.Size(23, 25);
            this.lblStat2Value.TabIndex = 1;
            this.lblStat2Value.Text = "0";
            // 
            // lblStat2Sub
            // 
            this.lblStat2Sub.AutoSize = true;
            this.lblStat2Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStat2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblStat2Sub.Location = new System.Drawing.Point(12, 60);
            this.lblStat2Sub.Name = "lblStat2Sub";
            this.lblStat2Sub.Size = new System.Drawing.Size(107, 12);
            this.lblStat2Sub.TabIndex = 2;
            this.lblStat2Sub.Text = "Total pesanan terdaftar";
            // 
            // lblStat2Title
            // 
            this.lblStat2Title.AutoSize = true;
            this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStat2Title.Location = new System.Drawing.Point(10, 10);
            this.lblStat2Title.Name = "lblStat2Title";
            this.lblStat2Title.Size = new System.Drawing.Size(81, 15);
            this.lblStat2Title.TabIndex = 0;
            this.lblStat2Title.Text = "Total Pesanan";
            // 
            // pnlStat3
            // 
            this.pnlStat3.BackColor = System.Drawing.Color.White;
            this.pnlStat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat3.Controls.Add(this.lblStat3Value);
            this.pnlStat3.Controls.Add(this.lblStat3Sub);
            this.pnlStat3.Controls.Add(this.lblStat3Title);
            this.pnlStat3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStat3.Location = new System.Drawing.Point(455, 3);
            this.pnlStat3.Name = "pnlStat3";
            this.pnlStat3.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStat3.Size = new System.Drawing.Size(220, 89);
            this.pnlStat3.TabIndex = 2;
            // 
            // lblStat3Value
            // 
            this.lblStat3Value.AutoSize = true;
            this.lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStat3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblStat3Value.Location = new System.Drawing.Point(10, 32);
            this.lblStat3Value.Name = "lblStat3Value";
            this.lblStat3Value.Size = new System.Drawing.Size(23, 25);
            this.lblStat3Value.TabIndex = 1;
            this.lblStat3Value.Text = "0";
            // 
            // lblStat3Sub
            // 
            this.lblStat3Sub.AutoSize = true;
            this.lblStat3Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStat3Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblStat3Sub.Location = new System.Drawing.Point(12, 60);
            this.lblStat3Sub.Name = "lblStat3Sub";
            this.lblStat3Sub.Size = new System.Drawing.Size(117, 12);
            this.lblStat3Sub.TabIndex = 2;
            this.lblStat3Sub.Text = "Tersedia di katalog publik";
            // 
            // lblStat3Title
            // 
            this.lblStat3Title.AutoSize = true;
            this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStat3Title.Location = new System.Drawing.Point(10, 10);
            this.lblStat3Title.Name = "lblStat3Title";
            this.lblStat3Title.Size = new System.Drawing.Size(76, 15);
            this.lblStat3Title.TabIndex = 0;
            this.lblStat3Title.Text = "Produk Aktif";
            // 
            // pnlStat4
            // 
            this.pnlStat4.BackColor = System.Drawing.Color.White;
            this.pnlStat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat4.Controls.Add(this.lblStat4Value);
            this.pnlStat4.Controls.Add(this.lblStat4Sub);
            this.pnlStat4.Controls.Add(this.lblStat4Title);
            this.pnlStat4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStat4.Location = new System.Drawing.Point(681, 3);
            this.pnlStat4.Name = "pnlStat4";
            this.pnlStat4.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStat4.Size = new System.Drawing.Size(220, 89);
            this.pnlStat4.TabIndex = 3;
            // 
            // lblStat4Value
            // 
            this.lblStat4Value.AutoSize = true;
            this.lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStat4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStat4Value.Location = new System.Drawing.Point(10, 32);
            this.lblStat4Value.Name = "lblStat4Value";
            this.lblStat4Value.Size = new System.Drawing.Size(23, 25);
            this.lblStat4Value.TabIndex = 1;
            this.lblStat4Value.Text = "0";
            // 
            // lblStat4Sub
            // 
            this.lblStat4Sub.AutoSize = true;
            this.lblStat4Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStat4Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblStat4Sub.Location = new System.Drawing.Point(12, 60);
            this.lblStat4Sub.Name = "lblStat4Sub";
            this.lblStat4Sub.Size = new System.Drawing.Size(107, 12);
            this.lblStat4Sub.TabIndex = 2;
            this.lblStat4Sub.Text = "Menunggu + Diproses";
            // 
            // lblStat4Title
            // 
            this.lblStat4Title.AutoSize = true;
            this.lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStat4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStat4Title.Location = new System.Drawing.Point(10, 10);
            this.lblStat4Title.Name = "lblStat4Title";
            this.lblStat4Title.Size = new System.Drawing.Size(126, 15);
            this.lblStat4Title.TabIndex = 0;
            this.lblStat4Title.Text = "Perlu Ditindaklanjuti";
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
            this.lblTitle.Size = new System.Drawing.Size(256, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Admin";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(155, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ringkasan performa toko.";
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDashboardAdmin";
            this.Text = "Kala Rintik Tea — Dashboard Admin";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRightSide.ResumeLayout(false);
            this.pnlStatusCounts.ResumeLayout(false);
            this.pnlStatusCounts.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlLeftContent.ResumeLayout(false);
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.pnlRecentReviews.ResumeLayout(false);
            this.pnlRecentReviews.PerformLayout();
            this.pnlStatsRow.ResumeLayout(false);
            this.pnlStat1.ResumeLayout(false);
            this.pnlStat1.PerformLayout();
            this.pnlStat2.ResumeLayout(false);
            this.pnlStat2.PerformLayout();
            this.pnlStat3.ResumeLayout(false);
            this.pnlStat3.PerformLayout();
            this.pnlStat4.ResumeLayout(false);
            this.pnlStat4.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel pnlStatsRow;
        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1Title;
        private System.Windows.Forms.Label lblStat1Value;
        private System.Windows.Forms.Label lblStat1Sub;
        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2Title;
        private System.Windows.Forms.Label lblStat2Value;
        private System.Windows.Forms.Label lblStat2Sub;
        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3Title;
        private System.Windows.Forms.Label lblStat3Value;
        private System.Windows.Forms.Label lblStat3Sub;
        private System.Windows.Forms.Panel pnlStat4;
        private System.Windows.Forms.Label lblStat4Title;
        private System.Windows.Forms.Label lblStat4Value;
        private System.Windows.Forms.Label lblStat4Sub;
        private System.Windows.Forms.Panel pnlLeftContent;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrdersTitle;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel pnlRecentReviews;
        private System.Windows.Forms.Label lblRecentReviewsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowRecentReviews;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLowStock;
        private System.Windows.Forms.Panel pnlStatusCounts;
        private System.Windows.Forms.Label lblStatusCountTitle;
        private System.Windows.Forms.Label lblCountMenunggu;
        private System.Windows.Forms.Label lblCountDiproses;
        private System.Windows.Forms.Label lblCountDikirim;
        private System.Windows.Forms.Label lblCountSelesai;
        private System.Windows.Forms.Label lblCountDibatalkan;
    }
}
