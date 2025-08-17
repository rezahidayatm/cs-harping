## 1.6. Koleksi Data Sederhana

### Pelajaran 6: Koleksi Data Sederhana (`Array` dan `List`)

Bayangkan sejauh ini variabel kita (`int`, `string`, dll.) adalah sebuah **laci tunggal**. Anda hanya bisa menyimpan satu barang di dalamnya. Sekarang, bagaimana jika Anda ingin menyimpan seluruh set pakaian atau koleksi buku? Anda butuh **lemari** atau **rak buku**.

Dalam C\#, "lemari" atau "rak buku" itu disebut **Koleksi (Collection)**. Ini adalah variabel spesial yang bisa menampung *banyak* nilai sekaligus. Dua koleksi paling dasar dan penting adalah `Array` dan `List`.

-----

### 1\. `Array` - Rak Buku dengan Slot Tetap

Sebuah **Array** adalah koleksi yang ukurannya **tetap dan tidak bisa diubah** setelah dibuat.

**Analogi:** Bayangkan sebuah **kotak telur**. Jika Anda membeli yang isi 12, maka selamanya akan ada 12 slot. Anda tidak bisa tiba-tiba membuatnya menjadi 13.

**Ciri Khas:**

* **Ukuran Tetap:** Didefinisikan saat dibuat.
* **Akses via Indeks:** Elemen diakses melalui nomor posisinya, yang disebut **indeks**. Indeks di C\# selalu dimulai dari **0**. Jadi, elemen pertama ada di indeks `[0]`, kedua di `[1]`, dan seterusnya.

**Contoh Kode:**

```csharp
// Membuat sebuah Array string yang bisa menampung 4 nama.
string[] namaTim = new string[4];

// Mengisi nilai ke dalam Array menggunakan indeks
namaTim[0] = "Budi";
namaTim[1] = "Siti";
namaTim[2] = "Eka";
namaTim[3] = "Joko";

// Mengakses nilai dari Array
Console.WriteLine($"Pemain pertama adalah: {namaTim[0]}"); // Output: Budi

// Cara lain yang lebih singkat untuk membuat Array jika kita sudah tahu isinya
int[] nilaiUjian = { 85, 90, 78, 92, 88 };

// Cara menampilkan semua isi Array dengan loop 'for'
Console.WriteLine("\n--- Daftar Nilai Ujian ---");
for (int i = 0; i < nilaiUjian.Length; i++) // '.Length' memberikan jumlah slot dalam Array
{
    Console.WriteLine($"Nilai ke-{i+1}: {nilaiUjian[i]}");
}
```

-----

### 2\. `List` - Tas Belanja yang Fleksibel

Sebuah **List** adalah koleksi yang ukurannya **dinamis dan fleksibel**. Anda bisa menambah atau menghapus isinya kapan saja.

**Analogi:** Bayangkan sebuah **tas belanja**. Anda bisa memasukkan barang sebanyak yang Anda mau, dan tasnya akan melar. Anda juga bisa mengeluarkan barang kapan saja.

**Ciri Khas:**

* **Ukuran Dinamis:** Bisa bertambah dan berkurang.
* **Metode Bantuan:** Punya banyak metode berguna seperti `.Add()`, `.Remove()`, `.Count`.
* **Sama seperti Array,** akses elemen juga menggunakan indeks yang dimulai dari 0.

**Contoh Kode:**

```csharp
// Untuk menggunakan List, kita perlu baris ini di paling atas file
using System.Collections.Generic;

// Membuat sebuah List kosong untuk menampung daftar belanjaan
List<string> daftarBelanja = new List<string>();

// Menambahkan item ke dalam List
Console.WriteLine("Menambahkan item ke daftar...");
daftarBelanja.Add("Apel");
daftarBelanja.Add("Susu");
daftarBelanja.Add("Roti");

// Menghitung jumlah item dalam List menggunakan '.Count'
Console.WriteLine($"Ada {daftarBelanja.Count} item di daftar belanja.");

// Menghapus item dari List
daftarBelanja.Remove("Susu");
Console.WriteLine("\nSusu telah dihapus.");

// Cara menampilkan semua isi List dengan loop 'foreach' (lebih mudah dibaca)
Console.WriteLine("\n--- Daftar Belanja Final ---");
foreach (string item in daftarBelanja)
{
    Console.WriteLine($"- {item}");
}
```

-----

### \#\# Kapan Pakai `Array` vs. `List`?

* Gunakan **`Array`** jika Anda **tahu pasti** jumlah elemennya dari awal dan jumlah itu tidak akan pernah berubah (contoh: hari dalam seminggu, bulan dalam setahun).
* Gunakan **`List`** di **hampir semua kasus lainnya**. Saat jumlah elemen tidak pasti, atau akan sering ditambah dan dikurangi.

**Saran untuk pemula:** Jika ragu, gunakan `List`. Fleksibilitasnya akan sangat membantu Anda.

-----

### ✍️ Latihan untuk Anda: "Playlist Lagu"

Mari kita praktikkan `List` yang sangat berguna ini.

**Tugas:**

1.  Buat sebuah `List<string>` baru dengan nama `playlistLagu`.
2.  Gunakan metode `.Add()` untuk menambahkan 3 atau 4 judul lagu favorit Anda ke dalam `playlistLagu`.
3.  Tampilkan pesan "Playlist Awal:" dan gunakan loop `foreach` untuk menampilkan semua lagu di dalamnya.
4.  Gunakan metode `.Remove()` untuk menghapus salah satu lagu dari playlist.
5.  Tampilkan pesan "Playlist Setelah Satu Lagu Dihapus:" dan tampilkan lagi semua isinya untuk membuktikan lagu tersebut sudah hilang.

-----

Sekarang fondasi kita benar-benar lengkap\! Setelah ini, kita **benar-benar** siap untuk Fase 2, di mana kita akan belajar membuat `List` yang isinya bukan lagi sekadar `string`, melainkan `object` `Kucing` atau `Mobil` buatan kita sendiri.

Silakan kerjakan latihannya, dan kita akan melanjutkan setelah Anda siap\!