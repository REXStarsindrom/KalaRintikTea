-- ==============================================================================
-- KALA RINTIK TEA - DATABASE SCHEMA (PostgreSQL)
-- Sesuai Dokumen Perancangan Proyek Akhir PBO
-- ==============================================================================

-- 1. TABEL KATEGORI
CREATE TABLE IF NOT EXISTS kategori (
    id_kategori SERIAL PRIMARY KEY,
    nama_kategori VARCHAR(50) NOT NULL UNIQUE
);

-- 2. TABEL USERS
CREATE TABLE IF NOT EXISTS users (
    id_user         SERIAL PRIMARY KEY,
    nama            VARCHAR(100) NOT NULL,
    email           VARCHAR(100) NOT NULL UNIQUE,
    password_hash   VARCHAR(100) NOT NULL,
    role            VARCHAR(10) NOT NULL CHECK (role IN ('Admin', 'Pelanggan')),
    no_telepon      VARCHAR(20),
    alamat          TEXT,
    created_at      TIMESTAMPTZ NOT NULL DEFAULT NOW()
);

-- 3. TABEL PRODUK
CREATE TABLE IF NOT EXISTS produk (
    id_produk        SERIAL PRIMARY KEY,
    id_kategori      INT NOT NULL REFERENCES kategori(id_kategori),
    nama             VARCHAR(150) NOT NULL,
    deskripsi        TEXT,
    harga            NUMERIC(12,2) NOT NULL CHECK (harga > 0),
    stok             INT NOT NULL DEFAULT 0 CHECK (stok >= 0),
    berat_gram       INT NOT NULL CHECK (berat_gram > 0),
    asal_daerah      VARCHAR(100),
    path_gambar      VARCHAR(255),
    rata_rata_rating NUMERIC(3,2) NOT NULL DEFAULT 0,
    jumlah_ulasan    INT NOT NULL DEFAULT 0,
    is_active        BOOLEAN NOT NULL DEFAULT TRUE,
    created_at       TIMESTAMPTZ NOT NULL DEFAULT NOW()
);

-- 4. TABEL KERANJANG
CREATE TABLE IF NOT EXISTS keranjang (
    id_keranjang    SERIAL PRIMARY KEY,
    id_user         INT NOT NULL UNIQUE REFERENCES users(id_user),
    updated_at      TIMESTAMPTZ NOT NULL DEFAULT NOW()
);

-- 5. TABEL ITEM KERANJANG
CREATE TABLE IF NOT EXISTS item_keranjang (
    id_item         SERIAL PRIMARY KEY,
    id_keranjang    INT NOT NULL REFERENCES keranjang(id_keranjang) ON DELETE CASCADE,
    id_produk       INT NOT NULL REFERENCES produk(id_produk),
    kuantitas       INT NOT NULL CHECK (kuantitas > 0),
    UNIQUE (id_keranjang, id_produk)
);

-- 6. TABEL PESANAN
CREATE TABLE IF NOT EXISTS pesanan (
    id_pesanan          SERIAL PRIMARY KEY,
    kode_pesanan        VARCHAR(20) NOT NULL UNIQUE,
    id_user             INT NOT NULL REFERENCES users(id_user),
    tanggal_pesanan     TIMESTAMPTZ NOT NULL DEFAULT NOW(),
    alamat_pengiriman   TEXT NOT NULL,
    metode_pembayaran   VARCHAR(20) NOT NULL CHECK (metode_pembayaran IN ('Transfer', 'COD', 'Dompet Digital')),
    status_pembayaran   VARCHAR(15) NOT NULL DEFAULT 'Belum Dibayar' CHECK (status_pembayaran IN ('Belum Dibayar', 'Lunas')),
    status              VARCHAR(15) NOT NULL DEFAULT 'Menunggu' CHECK (status IN ('Menunggu', 'Diproses', 'Dikirim', 'Selesai', 'Dibatalkan')),
    catatan             TEXT,
    subtotal            NUMERIC(12,2) NOT NULL CHECK (subtotal >= 0),
    ongkir              NUMERIC(12,2) NOT NULL CHECK (ongkir >= 0),
    grand_total         NUMERIC(12,2) NOT NULL CHECK (grand_total >= 0)
);

-- 7. TABEL DETAIL PESANAN
CREATE TABLE IF NOT EXISTS detail_pesanan (
    id_detail       SERIAL PRIMARY KEY,
    id_pesanan      INT NOT NULL REFERENCES pesanan(id_pesanan) ON DELETE CASCADE,
    id_produk       INT NOT NULL REFERENCES produk(id_produk),
    nama_produk     VARCHAR(150) NOT NULL,
    harga_satuan    NUMERIC(12,2) NOT NULL CHECK (harga_satuan > 0),
    kuantitas       INT NOT NULL CHECK (kuantitas > 0),
    subtotal        NUMERIC(12,2) NOT NULL CHECK (subtotal >= 0)
);

-- 8. TABEL ULASAN
CREATE TABLE IF NOT EXISTS ulasan (
    id_ulasan       SERIAL PRIMARY KEY,
    id_user         INT NOT NULL REFERENCES users(id_user),
    id_produk       INT NOT NULL REFERENCES produk(id_produk),
    id_pesanan      INT NOT NULL REFERENCES pesanan(id_pesanan),
    rating          INT NOT NULL CHECK (rating BETWEEN 1 AND 5),
    komentar        TEXT,
    tanggal         TIMESTAMPTZ NOT NULL DEFAULT NOW(),
    UNIQUE (id_user, id_produk)
);

-- INDEKS PERFORMA
CREATE INDEX IF NOT EXISTS idx_produk_kategori ON produk(id_kategori);
CREATE INDEX IF NOT EXISTS idx_produk_aktif ON produk(is_active);
CREATE INDEX IF NOT EXISTS idx_pesanan_user ON pesanan(id_user);
CREATE INDEX IF NOT EXISTS idx_pesanan_status ON pesanan(status);
CREATE INDEX IF NOT EXISTS idx_detail_pesanan ON detail_pesanan(id_pesanan);
CREATE INDEX IF NOT EXISTS idx_ulasan_produk ON ulasan(id_produk);

-- SEED DATA KATEGORI
INSERT INTO kategori (nama_kategori) VALUES
    ('Teh Hijau'),
    ('Teh Hitam'),
    ('Teh Putih'),
    ('Teh Oolong'),
    ('Teh Herbal'),
    ('Teh Celup'),
    ('Teh Bubuk')
ON CONFLICT (nama_kategori) DO NOTHING;

-- SEED DATA USERS (Password: password123)
-- BCrypt hash untuk 'password123'
INSERT INTO users (nama, email, password_hash, role, no_telepon, alamat)
VALUES 
    ('Rex (Admin Toko)', 'admin@kalarintik.id', '$2a$11$w8x2sYw8uS2b0tM1rQv4.OnP9W8qG0kYz2zX8wJ9bL0rQv4OnP9W8', 'Admin', '0812-3456-7801', 'Kebun Teh Gunung Gambir, Sumberbaru, Jember'),
    ('Agus Setiawan', 'agus.s@kalarintik.id', '$2a$11$w8x2sYw8uS2b0tM1rQv4.OnP9W8qG0kYz2zX8wJ9bL0rQv4OnP9W8', 'Admin', '0813-5567-2290', 'Jember, Jawa Timur'),
    ('Botem', 'botem@gmail.com', '$2a$11$w8x2sYw8uS2b0tM1rQv4.OnP9W8qG0kYz2zX8wJ9bL0rQv4OnP9W8', 'Pelanggan', '0812-3456-7890', 'Jl. Kalimantan No. 37, Sumbersari, Jember'),
    ('Dewi Anggraini', 'dewi@gmail.com', '$2a$11$w8x2sYw8uS2b0tM1rQv4.OnP9W8qG0kYz2zX8wJ9bL0rQv4OnP9W8', 'Pelanggan', '0812-3456-7890', 'Jl. Mastrip No. 12, Sumbersari, Jember 68121')
ON CONFLICT (email) DO NOTHING;

-- SEED DATA KERANJANG
INSERT INTO keranjang (id_user)
SELECT id_user FROM users WHERE role = 'Pelanggan'
ON CONFLICT (id_user) DO NOTHING;

-- SEED DATA PRODUK SESUAI MOCKUP
INSERT INTO produk (id_kategori, nama, deskripsi, harga, stok, berat_gram, asal_daerah, path_gambar, rata_rata_rating, jumlah_ulasan, is_active)
VALUES
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Hijau'), 
     'Teh Hijau Gunung Gambir', 'Daun teh hijau segar, aroma floral lembut dipetik dari lereng Gunung Gambir.', 45000, 38, 100, 'Jember', 'img/hijau-gg.png', 4.8, 32, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Hitam'), 
     'Teh Hitam Orthodox Puncak', 'Teh hitam klasik dengan rasa pekat dan aroma rempah alami khas dataran tinggi Puncak Bogor.', 52000, 27, 100, 'Puncak, Bogor', 'img/hitam-puncak.png', 4.7, 27, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Putih'), 
     'Teh Putih Silver Needle', 'Pucuk teh putih premium langka dari Wonosobo beraroma segar dan manis lembut.', 95000, 4, 50, 'Wonosobo', 'img/putih-silver.png', 4.9, 18, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Oolong'), 
     'Teh Oolong Ciwidey', 'Teh semi fermentasi khas Ciwidey dengan aroma buah persik dan madu alami.', 65000, 9, 80, 'Ciwidey', 'img/oolong-ciwidey.png', 4.6, 21, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Herbal'), 
     'Teh Herbal Jahe Serai', 'Racikan herbal alami penghangat tubuh dari jahe merah dan serai segar Kintamani.', 38000, 44, 75, 'Kintamani', 'img/herbal-jahe.png', 4.5, 15, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Celup'), 
     'Teh Celup Melati', 'Teh melati wangi alami dalam kemasan kantong celup praktis dan higienis.', 28000, 120, 60, 'Wonosobo', 'img/celup-melati.png', 4.4, 40, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Bubuk'), 
     'Teh Bubuk Matcha Lokal', 'Matcha murni hasil gilingan halus batu tradisional dari perkebunan Puncak.', 72000, 6, 50, 'Puncak, Bogor', 'img/matcha-lokal.png', 4.7, 12, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Herbal'), 
     'Teh Herbal Bunga Telang', 'Bunga telang kering organik khas Banyuwangi dengan warna biru alami yang eksotis.', 34000, 56, 40, 'Banyuwangi', 'img/bunga-telang.png', 4.6, 19, TRUE),
    
    ((SELECT id_kategori FROM kategori WHERE nama_kategori = 'Teh Hijau'), 
     'Teh Hijau Pekalongan', 'Teh hijau aroma melati segar dari perkebunan teh Pekalongan.', 40000, 0, 100, 'Pekalongan', 'img/hijau-pekalongan.png', 4.2, 8, FALSE)
ON CONFLICT DO NOTHING;
