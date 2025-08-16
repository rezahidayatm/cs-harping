## 1.2. Variabel

### Pelajaran 1: Variabel - "Kotak Penyimpanan" Kode Anda

Bayangkan Anda sedang merapikan sebuah ruangan. Anda pasti butuh beberapa kotak untuk menyimpan barang-barang Anda, dan setiap kotak diberi label agar Anda tahu isinya.

Dalam pemrograman, **Variabel** adalah persis seperti **kotak penyimpanan berlabel** itu. Fungsinya adalah untuk menyimpan sebuah nilai (data) di dalam memori komputer agar bisa kita gunakan nanti.

Setiap "kotak" di C\# harus memiliki dua hal:

1.  **Tipe Data**: Jenis barang apa yang boleh disimpan di dalam kotak ini? (Apakah ini kotak untuk angka, untuk tulisan, atau untuk yang lain?)
2.  **Nama Variabel**: Label yang kita tempelkan di kotak agar mudah dikenali.

Mari kita kenali jenis-jenis "kotak" paling umum yang akan sering Anda gunakan.

#### 1\. `int` - Kotak untuk Angka Bulat

* **Tipe Data:** `int` (singkatan dari *integer*).
* **Isi:** Menyimpan bilangan bulat, baik positif maupun negatif, tanpa komponen desimal.
* **Contoh:** Usia, jumlah barang, tahun rilis.

<!-- end list -->

```csharp
// Tipe      Nama Variabel   Nilai
   int       umur            = 25;
   int       jumlahApel      = 12;
```

#### 2\. `string` - Kotak untuk Teks

* **Tipe Data:** `string`.
* **Isi:** Menyimpan kumpulan karakter atau teks. Nilainya selalu diapit oleh tanda kutip ganda (`"`).
* **Contoh:** Nama, alamat, judul buku.

<!-- end list -->

```csharp
// Tipe      Nama Variabel   Nilai
   string    namaDepan       = "Agus";
   string    pekerjaan       = "Developer C#";
```

#### 3\. `double` - Kotak untuk Angka Desimal

* **Tipe Data:** `double`.
* **Isi:** Menyimpan angka yang memiliki koma atau titik desimal. Sangat cocok untuk perhitungan yang butuh presisi.
* **Contoh:** Tinggi badan, berat, harga, rating.

<!-- end list -->

```csharp
// Tipe      Nama Variabel   Nilai
   double    tinggiBadan     = 168.5; // Gunakan titik untuk desimal
   double    hargaBuku       = 85500.75;
```

*(Catatan: Ada juga `float` dan `decimal` untuk angka desimal, tapi `double` adalah titik awal yang paling umum dan serbaguna).*

#### 4\. `bool` - Kotak Saklar (ON/OFF)

* **Tipe Data:** `bool` (singkatan dari *boolean*).
* **Isi:** Hanya bisa menyimpan dua nilai: `true` (benar) atau `false` (salah). Sangat penting untuk logika dan pengambilan keputusan.
* **Contoh:** Status login, ketersediaan barang.

<!-- end list -->

```csharp
// Tipe      Nama Variabel   Nilai
   bool      sudahLogin      = true;
   bool      apakahAdmin     = false;
```

-----

### Mari Kita Praktikkan\!

Sekarang, buka Rider Anda, buat proyek "Console App" baru, dan coba ketik atau salin-tempel kode di bawah ini ke dalam file `Program.cs` Anda. Ini akan menunjukkan cara mendeklarasikan dan menampilkan semua variabel yang baru kita pelajari.

```csharp
// Hapus semua kode template dan ganti dengan ini

// Kita akan mendeklarasikan beberapa variabel untuk menyimpan data diri
// Ini adalah komentar, baris yang diawali '//' akan diabaikan oleh komputer

// 1. Variabel untuk menyimpan nama (menggunakan string)
string nama = "Budi Setiawan";

// 2. Variabel untuk menyimpan umur (menggunakan int)
int umur = 30;

// 3. Variabel untuk menyimpan tinggi badan dalam meter (menggunakan double)
double tinggiDalamMeter = 1.72;

// 4. Variabel untuk status pernikahan (menggunakan bool)
bool sudahMenikah = true;

// Sekarang, kita tampilkan semua informasi ini ke konsol
Console.WriteLine("--- Biodata Diri ---");
Console.WriteLine($"Nama Lengkap: {nama}");
Console.WriteLine($"Umur: {umur} tahun");
Console.WriteLine($"Tinggi Badan: {tinggiDalamMeter} meter");
Console.WriteLine($"Status Pernikahan: {sudahMenikah}");
```

**Jalankan programnya (tekan tombol ▶️ hijau di Rider).** Anda akan melihat biodata Budi ditampilkan dengan rapi di konsol.

-----

### ✍️ Latihan untuk Anda

Sekarang giliran Anda\! Buatlah program baru atau modifikasi program di atas.
**Tugas:** Buatlah variabel-variabel untuk menyimpan informasi tentang **film favorit Anda**.

* `judulFilm` (tipe `string`)
* `tahunRilis` (tipe `int`)
* `ratingIMDb` (tipe `double`)
* `apakahSudahNonton` (tipe `bool`)

Setelah itu, tampilkan semua informasi tersebut ke konsol dengan format yang menarik\!