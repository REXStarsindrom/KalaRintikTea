namespace KalaRintikTea.Forms
{
    partial class FormRiwayat
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
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailKode = new System.Windows.Forms.Label();
            this.lblDetailStatusBadge = new System.Windows.Forms.Label();
            this.lblStepper = new System.Windows.Forms.Label();
            this.lblDetailAlamat = new System.Windows.Forms.Label();
            this.lblDetailPayment = new System.Windows.Forms.Label();
            this.flowDetailItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReviewBox = new System.Windows.Forms.Panel();
            this.lblReviewPrompt = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.btnKirimUlasan = new System.Windows.Forms.Button();
            this.lblDetailTotals = new System.Windows.Forms.Label();
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlReviewBox.SuspendLayout();
            this.pnlListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.btnNavRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnNavRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRiwayat.FlatAppearance.BorderSize = 0;
            this.btnNavRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRiwayat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavRiwayat.ForeColor = System.Drawing.Color.White;
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
            this.pnlMain.Controls.Add(this.pnlDetail);
            this.pnlMain.Controls.Add(this.pnlListContainer);
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
            this.pnlDetail.Controls.Add(this.lblDetailAlamat);
            this.pnlDetail.Controls.Add(this.lblDetailPayment);
            this.pnlDetail.Controls.Add(this.flowDetailItems);
            this.pnlDetail.Controls.Add(this.pnlReviewBox);
            this.pnlDetail.Controls.Add(this.lblDetailTotals);
            this.pnlDetail.Location = new System.Drawing.Point(544, 90);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDetail.Size = new System.Drawing.Size(390, 646);
            this.pnlDetail.TabIndex = 2;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(150, 23);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "Detail Pesanan";
            // 
            // lblDetailKode
            // 
            this.lblDetailKode.AutoSize = true;
            this.lblDetailKode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDetailKode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDetailKode.Location = new System.Drawing.Point(20, 42);
            this.lblDetailKode.Name = "lblDetailKode";
            this.lblDetailKode.Size = new System.Drawing.Size(161, 17);
            this.lblDetailKode.TabIndex = 1;
            this.lblDetailKode.Text = "Pilih pesanan untuk melihat";
            // 
            // lblDetailStatusBadge
            // 
            this.lblDetailStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetailStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.lblDetailStatusBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDetailStatusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblDetailStatusBadge.Location = new System.Drawing.Point(280, 15);
            this.lblDetailStatusBadge.Name = "lblDetailStatusBadge";
            this.lblDetailStatusBadge.Size = new System.Drawing.Size(90, 24);
            this.lblDetailStatusBadge.TabIndex = 2;
            this.lblDetailStatusBadge.Text = "Status";
            this.lblDetailStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStepper
            // 
            this.lblStepper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStepper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStepper.Location = new System.Drawing.Point(20, 70);
            this.lblStepper.Name = "lblStepper";
            this.lblStepper.Size = new System.Drawing.Size(350, 22);
            this.lblStepper.TabIndex = 3;
            this.lblStepper.Text = "🟡 Menunggu  ➔  🔵 Diproses  ➔  🟠 Dikirim  ➔  🟢 Selesai";
            this.lblStepper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailAlamat
            // 
            this.lblDetailAlamat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDetailAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDetailAlamat.Location = new System.Drawing.Point(20, 100);
            this.lblDetailAlamat.Name = "lblDetailAlamat";
            this.lblDetailAlamat.Size = new System.Drawing.Size(350, 40);
            this.lblDetailAlamat.TabIndex = 4;
            this.lblDetailAlamat.Text = "Alamat Pengiriman:\n-";
            // 
            // lblDetailPayment
            // 
            this.lblDetailPayment.AutoSize = true;
            this.lblDetailPayment.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDetailPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDetailPayment.Location = new System.Drawing.Point(20, 145);
            this.lblDetailPayment.Name = "lblDetailPayment";
            this.lblDetailPayment.Size = new System.Drawing.Size(185, 15);
            this.lblDetailPayment.TabIndex = 5;
            this.lblDetailPayment.Text = "Metode: Transfer · Status: Belum Dibayar";
            // 
            // flowDetailItems
            // 
            this.flowDetailItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowDetailItems.AutoScroll = true;
            this.flowDetailItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDetailItems.Location = new System.Drawing.Point(20, 170);
            this.flowDetailItems.Name = "flowDetailItems";
            this.flowDetailItems.Padding = new System.Windows.Forms.Padding(6);
            this.flowDetailItems.Size = new System.Drawing.Size(350, 190);
            this.flowDetailItems.TabIndex = 6;
            // 
            // pnlReviewBox
            // 
            this.pnlReviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.pnlReviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReviewBox.Controls.Add(this.lblReviewPrompt);
            this.pnlReviewBox.Controls.Add(this.cmbRating);
            this.pnlReviewBox.Controls.Add(this.txtReviewComment);
            this.pnlReviewBox.Controls.Add(this.btnKirimUlasan);
            this.pnlReviewBox.Location = new System.Drawing.Point(20, 368);
            this.pnlReviewBox.Name = "pnlReviewBox";
            this.pnlReviewBox.Padding = new System.Windows.Forms.Padding(10);
            this.pnlReviewBox.Size = new System.Drawing.Size(350, 170);
            this.pnlReviewBox.TabIndex = 7;
            this.pnlReviewBox.Visible = false;
            // 
            // lblReviewPrompt
            // 
            this.lblReviewPrompt.AutoSize = true;
            this.lblReviewPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReviewPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblReviewPrompt.Location = new System.Drawing.Point(10, 8);
            this.lblReviewPrompt.Name = "lblReviewPrompt";
            this.lblReviewPrompt.Size = new System.Drawing.Size(155, 15);
            this.lblReviewPrompt.TabIndex = 0;
            this.lblReviewPrompt.Text = "Beri Ulasan Produk Selesai:";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "⭐⭐⭐⭐⭐  (5 - Sangat Puas)",
            "⭐⭐⭐⭐  (4 - Puas)",
            "⭐⭐⭐  (3 - Cukup)",
            "⭐⭐  (2 - Kurang)",
            "⭐  (1 - Kecewa)"});
            this.cmbRating.Location = new System.Drawing.Point(10, 30);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(328, 23);
            this.cmbRating.TabIndex = 1;
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReviewComment.Location = new System.Drawing.Point(10, 60);
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.PlaceholderText = "Tulis ulasan tentang rasa, aroma, atau kemasan teh...";
            this.txtReviewComment.Size = new System.Drawing.Size(328, 55);
            this.txtReviewComment.TabIndex = 2;
            // 
            // btnKirimUlasan
            // 
            this.btnKirimUlasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnKirimUlasan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKirimUlasan.FlatAppearance.BorderSize = 0;
            this.btnKirimUlasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirimUlasan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKirimUlasan.ForeColor = System.Drawing.Color.White;
            this.btnKirimUlasan.Location = new System.Drawing.Point(10, 125);
            this.btnKirimUlasan.Name = "btnKirimUlasan";
            this.btnKirimUlasan.Size = new System.Drawing.Size(328, 32);
            this.btnKirimUlasan.TabIndex = 3;
            this.btnKirimUlasan.Text = "Kirim Ulasan";
            this.btnKirimUlasan.UseVisualStyleBackColor = false;
            // 
            // lblDetailTotals
            // 
            this.lblDetailTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDetailTotals.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDetailTotals.Location = new System.Drawing.Point(20, 550);
            this.lblDetailTotals.Name = "lblDetailTotals";
            this.lblDetailTotals.Size = new System.Drawing.Size(348, 74);
            this.lblDetailTotals.TabIndex = 8;
            this.lblDetailTotals.Text = "Subtotal: Rp 0\nOngkir: Rp 0\nGrand Total: Rp 0";
            this.lblDetailTotals.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListContainer.Controls.Add(this.dgvOrders);
            this.pnlListContainer.Location = new System.Drawing.Point(30, 90);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(498, 646);
            this.pnlListContainer.TabIndex = 1;
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
            this.dgvOrders.Size = new System.Drawing.Size(498, 646);
            this.dgvOrders.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Controls.Add(this.cmbFilterStatus);
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
            this.lblTitle.Size = new System.Drawing.Size(252, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Riwayat Pesanan";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(465, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Pantau status pesananmu dan beri ulasan setelah pesanan berstatus Selesai.";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Status: Semua",
            "Status: Menunggu",
            "Status: Diproses",
            "Status: Dikirim",
            "Status: Selesai",
            "Status: Dibatalkan"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(724, 15);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(180, 25);
            this.cmbFilterStatus.TabIndex = 2;
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormRiwayat";
            this.Text = "Kala Rintik Tea — Riwayat Pesanan";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserCard.ResumeLayout(false);
            this.pnlUserCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlReviewBox.ResumeLayout(false);
            this.pnlReviewBox.PerformLayout();
            this.pnlListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Panel pnlListContainer;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailKode;
        private System.Windows.Forms.Label lblDetailStatusBadge;
        private System.Windows.Forms.Label lblStepper;
        private System.Windows.Forms.Label lblDetailAlamat;
        private System.Windows.Forms.Label lblDetailPayment;
        private System.Windows.Forms.FlowLayoutPanel flowDetailItems;
        private System.Windows.Forms.Panel pnlReviewBox;
        private System.Windows.Forms.Label lblReviewPrompt;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.TextBox txtReviewComment;
        private System.Windows.Forms.Button btnKirimUlasan;
        private System.Windows.Forms.Label lblDetailTotals;
    }
}
