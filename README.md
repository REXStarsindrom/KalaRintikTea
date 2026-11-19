# 🍃 Kala Rintik Tea — Aplikasi Desktop E-Commerce Teh Nusantara

Aplikasi desktop pemesanan dan katalog teh Nusantara berbasis **C# Windows Forms (.NET 8)** dengan arsitektur berlapis (*Layered Architecture*), manajemen database relasional **PostgreSQL** (`Npgsql`), serta dukungan penuh antarmuka grafis di **Visual Studio** (*Designer.cs*) dan **Visual Studio Code**.

---

## 📁 Struktur Direktori Proyek

Proyek ini tersusun dalam satu folder terpadu dengan pembagian tanggung jawab kelas yang ketat:

```text
KalaRintikTea/
├── KalaRintikTea.sln                 # File Solution untuk Visual Studio (Aplikasi Ungu)
├── KalaRintikTea.csproj              # Konfigurasi Project .NET 8 Windows Forms
├── Program.cs                        # Titik masuk utama aplikasi (Inisialisasi DB & FormLanding)
│
├── Models/                           # Entitas Data Berorientasi Objek
│   ├── User.cs                       # Abstract Base Class Pengguna
│   ├── Admin.cs                      # Turunan User dengan Role Admin
│   ├── Pelanggan.cs                  # Turunan User dengan Role Pelanggan
│   ├── Produk.cs                     # Model Produk (Enkapsulasi Stok & Validasi)
│   ├── Kategori.cs                   # Model Kategori Teh
│   ├── Keranjang.cs                  # Model Keranjang Belanja Pelanggan
│   ├── ItemKeranjang.cs              # Model Item di dalam Keranjang
│   ├── Pesanan.cs                    # Header Pesanan & Pelacakan Status
│   ├── DetailPesanan.cs              # Item Rincian Pesanan (Snapshot Harga & Subtotal)
│   ├── Ulasan.cs                     # Review & Rating Pelanggan
│   └── Enums/
│       ├── Role.cs                   # Enum Role (Admin, Pelanggan)
│       ├── StatusPesanan.cs          # Enum Status (Menunggu, Diproses, Dikirim, Selesai, Dibatalkan)
│       ├── MetodePembayaran.cs       # Enum Metode (Transfer, COD, DompetDigital)
│       └── StatusPembayaran.cs       # Enum Status Bayar (Pending, Sukses, Gagal)
│
├── Repositories/                     # Akses Data Menggunakan Parameterized Queries & ACID
│   ├── IRepository.cs                # Generic Repository Interface <T>
│   ├── BaseRepository.cs             # Abstract Base Repo dengan Helper Eksekusi
│   ├── DbConnectionFactory.cs        # Factory Koneksi PostgreSQL Npgsql
│   ├── UserRepository.cs             # Operasi CRUD & Autentikasi Pengguna
│   ├── ProdukRepository.cs           # Katalog, Filter, CRUD & Manipulasi Stok Transaksional
│   ├── PesananRepository.cs          # Riwayat, Header & Detail Pesanan Transaksional
│   ├── KeranjangRepository.cs        # Pengelolaan Keranjang & Item Belanja
│   ├── KategoriRepository.cs         # Master Data Kategori
│   └── UlasanRepository.cs           # Ulasan, Rating & Rekalkulasi Rata-rata
│
├── Services/                         # Lapisan Logika Bisnis (Business Logic Layer)
│   ├── AuthService.cs                # Autentikasi, Registrasi (BCrypt) & Manajemen Profil
│   ├── CartService.cs                # Validasi Stok, Penambahan Item, Update Qty & Subtotal
│   ├── OrderService.cs               # Transaksi ACID Checkout & Perubahan Status Pesanan
│   ├── ProdukService.cs              # Pengelolaan Produk & Filter Kategori
│   └── ReviewService.cs              # Validasi Pesanan Selesai & Pengiriman Rating (1-5)
│
├── Payment/                          # Strategy Pattern untuk Pembayaran
│   ├── IPaymentMethod.cs             # Interface Metode Pembayaran
│   ├── TransferPayment.cs            # Implementasi Transfer Bank
│   ├── CodPayment.cs                 # Implementasi Bayar di Tempat (COD)
│   ├── DompetDigitalPayment.cs       # Implementasi E-Wallet (GoPay, OVO, Dana)
│   └── PaymentMethodFactory.cs       # Factory Pattern Pembuatan Handler Pembayaran
│
├── Shipping/                         # Strategy Pattern untuk Kalkulasi Pengiriman
│   ├── IShippingCalculator.cs        # Interface Kalkulator Ongkir
│   └── FlatRateShippingCalculator.cs # Implementasi Flat Rate Rp10.000
│
├── Helpers/                          # Utilitas & Konfigurasi Global
│   ├── AppConfig.cs                  # Konstanta Ongkir Flat Rate & PostgreSQL Connection String
│   ├── SessionManager.cs             # Singleton Pengelola Sesi Login & Hak Akses
│   ├── PasswordHasher.cs             # Hashing & Verifikasi Kata Sandi dengan BCrypt
│   ├── UIHelper.cs                   # Palet Warna Mockup (#1B5E3B, #FDF5EC), Styling & Format Rupiah
│   └── InputDialog.cs                # Dialog Prompt Input Dinamis
│
├── Database/
│   ├── schema.sql                    # Skrip DDL PostgreSQL 8 Tabel, Relasi FK, Indeks & Seed Data
│   └── DbInitializer.cs              # Otomasi Inisialisasi Database saat Startup
│
└── Forms/                            # Antarmuka Pengguna (WinForms .cs + .Designer.cs)
    ├── BaseForm.cs                   # Form Induk Abstrak (Navigasi, Alert, Otorisasi Role)
    ├── FormLanding.cs & .Designer.cs # Welcome Screen (Split View Branding & CTA Masuk/Daftar)
    ├── FormLogin.cs & .Designer.cs   # Form Masuk dengan Toggle Sandi & Redireksi Role
    ├── FormRegister.cs & .Designer.cs# Pendaftaran Pelanggan Baru & Auto-Creation Keranjang
    ├── FormKatalog.cs & .Designer.cs # Katalog Utama, Filter Kategori Pill, Pencarian & Grid Card Produk
    ├── FormDetailProduk.cs & .Designer.cs # Modal Detail Produk, Stok, Info Daerah & Tab Ulasan
    ├── FormKeranjang.cs & .Designer.cs    # Keranjang Belanja & Modal Checkout Terpadu
    ├── FormRiwayat.cs & .Designer.cs # Riwayat Pesanan Pelanggan, Stepper Status & Tombol Beri Ulasan
    ├── FormProfil.cs & .Designer.cs  # Form Edit Profil, Alamat & Kontak Pengguna
    ├── FormDashboardAdmin.cs & .Designer.cs # Dashboard Admin, Ringkasan Finansial & Alert Stok Rendah
    ├── FormManajemenProduk.cs & .Designer.cs# CRUD Katalog Produk & Status Aktif/Nonaktif
    ├── FormTransaksiAdmin.cs & .Designer.cs # Pipeline Pesanan Admin (Update Status & Batalkan/Kembalikan Stok)
    ├── FormPelangganAdmin.cs & .Designer.cs # Tabel Master Pelanggan Terdaftar
    └── FormUlasanAdmin.cs & .Designer.cs    # Tabel Monitoring Rating & Feedback Konsumen
```

---

## 🛠️ Konfigurasi Database (PostgreSQL)

1. Pastikan layanan **PostgreSQL** sudah berjalan di komputer Anda (port standar: `5432`).
2. Buat database baru bernama `kalarintiktea`:
   ```sql
   CREATE DATABASE kalarintiktea;
   ```
3. Sesuaikan username dan password PostgreSQL pada file [AppConfig.cs](file:///C:/Users/Rismay/.gemini/antigravity/scratch/KalaRintikTea/Helpers/AppConfig.cs):
   ```csharp
   public const string ConnectionString =
       "Host=localhost;Port=5432;Database=kalarintiktea;Username=postgres;Password=postgres";
   ```
4. Saat aplikasi dijalankan pertama kali, [DbInitializer.cs](file:///C:/Users/Rismay/.gemini/antigravity/scratch/KalaRintikTea/Database/DbInitializer.cs) akan secara otomatis mengeksekusi [schema.sql](file:///C:/Users/Rismay/.gemini/antigravity/scratch/KalaRintikTea/Database/schema.sql) untuk membentuk 8 tabel serta mengisi data awal (*seed data*).

---

## 💻 Cara Menjalankan Proyek

### A. Di Visual Studio (Aplikasi Ungu)
1. Buka aplikasi **Visual Studio 2022**.
2. Pilih menu **File > Open > Project/Solution...** (atau langsung klik dua kali file [KalaRintikTea.sln](file:///C:/Users/Rismay/.gemini/antigravity/scratch/KalaRintikTea/KalaRintikTea.sln)).
3. Tunggu hingga solusi selesai dimuat.
4. Anda dapat membuka setiap form di folder `Forms/` menggunakan **Visual Studio Form Designer** (klik ganda file seperti `FormLanding.cs` atau `FormDashboardAdmin.cs`) untuk melihat dan memodifikasi tata letak secara visual.
5. Tekan tombol **F5** atau klik tombol hijau **Start / Debug** untuk menjalankan aplikasi.

### B. Di Visual Studio Code
1. Buka folder `KalaRintikTea` di Visual Studio Code:
   ```bash
   code C:\Users\Rismay\.gemini\antigravity\scratch\KalaRintikTea
   ```
2. Buka terminal terintegrasi (`Ctrl + ~`) dan ketik:
   ```bash
   dotnet build
   dotnet run
   ```

---

## 👤 Akun Pengujian Default (Seed Data)

Database telah terisi akun default siap uji dengan password bawaan: `password123`:

| Role | Email | Password | Keterangan |
| :--- | :--- | :--- | :--- |
| **Admin** | `admin@kalarintik.id` | `password123` | Administrator Toko (Akses Dashboard Admin) |
| **Admin** | `agus.s@kalarintik.id` | `password123` | Administrator Operasional |
| **Pelanggan** | `botem@gmail.com` | `password123` | Pelanggan Aktif (Akses Katalog, Keranjang, Checkout) |
| **Pelanggan** | `dewi@gmail.com` | `password123` | Pelanggan Aktif |

*Catatan: Anda juga dapat mendaftarkan akun pelanggan baru secara langsung melalui tombol **Daftar Akun Baru** pada Form Login.*

---

## ☕ Prinsip Pemrograman Berorientasi Objek (PBO)

1. **Inheritance & Abstraction:**
   - Kelas abstrak `User` diturunkan ke kelas spesifik `Admin` dan `Pelanggan`.
   - Kelas abstrak `BaseForm` mewarisi fungsi navigasi umum, otorisasi hak akses peran, serta format pesan dialog kepada seluruh form UI.
   - Kelas abstrak `BaseRepository` menyediakan wrapper koneksi database ke repository spesifik.
2. **Encapsulation:**
   - Model `Produk` mengenkapsulasi status dan stok barang dengan method `CukupStok()`, `KurangiStok()`, `TambahStok()`, dan `Nonaktifkan()`.
3. **Polymorphism & Strategy Pattern:**
   - Interface `IPaymentMethod` diterapkan secara polimorfik oleh `TransferPayment`, `CodPayment`, dan `DompetDigitalPayment`.
   - Interface `IShippingCalculator` diimplementasikan oleh `FlatRateShippingCalculator`.
4. **Design Patterns:**
   - **Singleton:** `SessionManager.Instance` untuk menjamin konsistensi satu sesi pengguna global.
   - **Factory Method:** `PaymentMethodFactory.Create()` untuk instansiasi handler pembayaran secara dinamis.
   - **Repository Pattern:** Memisahkan lapisan domain logika dari akses data SQL relasional.
5. **ACID Transaction Integrity:**
   - Proses checkout pesanan (`OrderService.Checkout`) dan pembatalan pesanan (`OrderService.UpdateStatus(..., StatusPesanan.Dibatalkan)`) dieksekusi di dalam blok `NpgsqlTransaction` eksplisit guna menjamin konsistensi stok dan data transaksi finansial secara atomik.
