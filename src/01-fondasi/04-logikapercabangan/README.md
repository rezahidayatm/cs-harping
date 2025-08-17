## 1.4. Struktur Kontrol (Logika Percabangan)

Sampai saat ini, program kita berjalan lurus seperti jalan tol—dari atas ke bawah tanpa ada belokan. Sekarang, kita akan memberikannya "otak" untuk bisa **mengambil keputusan**. Kita akan ajarkan program kita cara memilih jalan di sebuah persimpangan.

-----

### \#\# Pelajaran 3: Struktur Kontrol `if-else` (Logika Percabangan)

Bayangkan program Anda sedang berjalan dan tiba di sebuah persimpangan. Ia harus bertanya, "Apakah saya harus belok kiri atau kanan?" Pernyataan `if-else` adalah rambu lalu lintas yang memberitahu program jalan mana yang harus diambil berdasarkan sebuah **kondisi**.

#### **1. Pernyataan `if` - "Jika Benar, Lakukan Ini"**

Ini adalah bentuk paling dasar. Program akan memeriksa sebuah kondisi. **Jika** kondisi itu bernilai `true`, maka blok kode di dalamnya akan dijalankan. Jika `false`, blok kode itu akan dilewati begitu saja.

Struktur dasarnya:

```csharp
if (kondisi)
{
    // Kode di dalam sini HANYA akan dijalankan
    // jika 'kondisi' bernilai true.
}
```

**Kondisi** itu sendiri adalah sebuah ekspresi yang menghasilkan nilai `bool` (`true` atau `false`). Biasanya kita menggunakan operator perbandingan:

* `==`   (Apakah sama dengan?) **Perhatian:** Gunakan dua tanda sama dengan `==` untuk membandingkan, bukan satu `=`\!
* `!=`   (Apakah tidak sama dengan?)
* `>`    (Apakah lebih besar dari?)
* `<`    (Apakah lebih kecil dari?)
* `>=`   (Apakah lebih besar atau sama dengan?)
* `<=`   (Apakah lebih kecil atau sama dengan?)

**Contoh:** Program penjaga pintu bioskop.

```csharp
int umurPengunjung = 20;

if (umurPengunjung >= 17)
{
    Console.WriteLine("Silakan masuk, Anda sudah cukup umur.");
}
```

Jika Anda mengubah `umurPengunjung` menjadi `15`, program tidak akan menampilkan apa-apa karena kondisi `15 >= 17` adalah `false`.

-----

#### **2. Pernyataan `else` - "Jika Tidak, Lakukan yang Lain"**

Bagaimana jika kita ingin melakukan sesuatu saat kondisinya `false`? Di sinilah `else` berperan. `else` adalah jalan alternatif yang akan diambil jika kondisi `if` tidak terpenuhi.

**Contoh:** Program penjaga pintu bioskop yang lebih ramah.

```csharp
int umurPengunjung = 15;

if (umurPengunjung >= 17)
{
    // Blok ini dijalankan jika kondisi true
    Console.WriteLine("Silakan masuk, Anda sudah cukup umur.");
}
else
{
    // Blok ini dijalankan jika kondisi false
    Console.WriteLine("Maaf, Anda belum boleh masuk. Tunggu beberapa tahun lagi ya!");
}
```

-----

#### **3. Pernyataan `else if` - "Jika Bukan Itu, Coba Cek yang Ini"**

Bagaimana jika ada lebih dari dua kemungkinan? Misalnya, untuk menentukan nilai A, B, C, atau D. Kita bisa merangkai beberapa kondisi menggunakan `else if`.

Program akan memeriksa kondisi dari atas ke bawah. Begitu salah satu kondisi `if` atau `else if` terpenuhi (`true`), blok kodenya akan dijalankan dan sisa pengecekan akan diabaikan.

**Contoh:** Program penentu nilai.

```csharp
int nilaiUjian = 85;

if (nilaiUjian >= 90)
{
    Console.WriteLine("Nilai Anda: A (Luar Biasa!)");
}
else if (nilaiUjian >= 80)
{
    Console.WriteLine("Nilai Anda: B (Bagus!)");
}
else if (nilaiUjian >= 70)
{
    Console.WriteLine("Nilai Anda: C (Cukup)");
}
else
{
    Console.WriteLine("Nilai Anda: D (Perlu belajar lagi)");
}
// Outputnya adalah: Nilai Anda: B (Bagus!)
```

-----

### ✍️ Latihan untuk Anda: "Login Simulator Sederhana"

Saatnya mempraktikkan kekuatan pengambilan keputusan ini\!

**Tugas:**

1.  Buat dua variabel `string` untuk menyimpan username dan password yang benar, misalnya:
    * `string usernameTersimpan = "admin";`
    * `string passwordTersimpan = "rahasi4!"`
2.  Minta pengguna untuk memasukkan username dan password mereka melalui konsol.
    * Gunakan `Console.WriteLine("Masukkan username:");` dan `string inputUsername = Console.ReadLine();` (lakukan hal yang sama untuk password).
3.  Gunakan struktur `if-else if-else` untuk memeriksa input pengguna:
    * **Jika** username DAN password yang dimasukkan **sesuai** dengan yang tersimpan, tampilkan pesan: `"Selamat datang, admin! Login berhasil."`
    * **Jika tidak**, periksa lagi: **Jika** username-nya saja yang **sesuai** tetapi password-nya salah, tampilkan pesan: `"Password salah. Coba lagi."`
    * **Jika tidak keduanya**, tampilkan pesan: `"Username tidak ditemukan."`

**Petunjuk:** Untuk memeriksa dua kondisi sekaligus (username DAN password), Anda bisa menggunakan operator logika `&&` (AND).
Contoh: `if (inputUsername == usernameTersimpan && inputPassword == passwordTersimpan)`

Ini adalah latihan yang sangat bagus untuk mensimulasikan logika yang ada di hampir setiap aplikasi. Selamat mencoba\!
