namespace KalaRintikTea.Forms
{
    partial class FormDetailProduk
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLeaf = new System.Windows.Forms.Label();
            this.lblCatOrigin = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStokBerat = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblReviewHeader = new System.Windows.Forms.Label();
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlTop.Controls.Add(this.lblLeaf);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(584, 150);
            this.pnlTop.TabIndex = 0;
            // 
            // lblLeaf
            // 
            this.lblLeaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeaf.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblLeaf.Location = new System.Drawing.Point(0, 0);
            this.lblLeaf.Name = "lblLeaf";
            this.lblLeaf.Size = new System.Drawing.Size(584, 150);
            this.lblLeaf.TabIndex = 0;
            this.lblLeaf.Text = "🍃";
            this.lblLeaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCatOrigin
            // 
            this.lblCatOrigin.AutoSize = true;
            this.lblCatOrigin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCatOrigin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCatOrigin.Location = new System.Drawing.Point(25, 165);
            this.lblCatOrigin.Name = "lblCatOrigin";
            this.lblCatOrigin.Size = new System.Drawing.Size(130, 17);
            this.lblCatOrigin.TabIndex = 1;
            this.lblCatOrigin.Text = "Kategori · Asal Daerah";
            // 
            // lblNama
            // 
            this.lblNama.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblNama.Location = new System.Drawing.Point(23, 185);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(535, 30);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Produk";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.lblRating.Location = new System.Drawing.Point(25, 218);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(117, 15);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "⭐ 0.0 (0 ulasan)";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lblHarga.Location = new System.Drawing.Point(23, 240);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(63, 30);
            this.lblHarga.TabIndex = 4;
            this.lblHarga.Text = "Rp 0";
            // 
            // lblStokBerat
            // 
            this.lblStokBerat.AutoSize = true;
            this.lblStokBerat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStokBerat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStokBerat.Location = new System.Drawing.Point(25, 275);
            this.lblStokBerat.Name = "lblStokBerat";
            this.lblStokBerat.Size = new System.Drawing.Size(182, 17);
            this.lblStokBerat.TabIndex = 5;
            this.lblStokBerat.Text = "Stok: 0 unit  ·  Berat: 100 gram";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDesc.Location = new System.Drawing.Point(25, 305);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(535, 60);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Deskripsi produk...";
            // 
            // lblQtyLabel
            // 
            this.lblQtyLabel.AutoSize = true;
            this.lblQtyLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQtyLabel.Location = new System.Drawing.Point(25, 380);
            this.lblQtyLabel.Name = "lblQtyLabel";
            this.lblQtyLabel.Size = new System.Drawing.Size(60, 17);
            this.lblQtyLabel.TabIndex = 7;
            this.lblQtyLabel.Text = "Jumlah:";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(95, 373);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(32, 32);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQty.Location = new System.Drawing.Point(133, 375);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(45, 27);
            this.txtQty.TabIndex = 9;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(184, 373);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(32, 32);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(230, 370);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(220, 38);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "+ Tambah ke Keranjang";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // lblReviewHeader
            // 
            this.lblReviewHeader.AutoSize = true;
            this.lblReviewHeader.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblReviewHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblReviewHeader.Location = new System.Drawing.Point(25, 425);
            this.lblReviewHeader.Name = "lblReviewHeader";
            this.lblReviewHeader.Size = new System.Drawing.Size(126, 19);
            this.lblReviewHeader.TabIndex = 12;
            this.lblReviewHeader.Text = "Ulasan Pelanggan";
            // 
            // flowReviews
            // 
            this.flowReviews.AutoScroll = true;
            this.flowReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowReviews.Location = new System.Drawing.Point(25, 450);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Padding = new System.Windows.Forms.Padding(8);
            this.flowReviews.Size = new System.Drawing.Size(535, 170);
            this.flowReviews.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.Location = new System.Drawing.Point(465, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Tutup";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FormDetailProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(584, 640);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowReviews);
            this.Controls.Add(this.lblReviewHeader);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblQtyLabel);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblStokBerat);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblCatOrigin);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetailProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Produk — Kala Rintik Tea";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLeaf;
        private System.Windows.Forms.Label lblCatOrigin;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStokBerat;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblReviewHeader;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private System.Windows.Forms.Button btnClose;
    }
}
