## 1.5. Struktur Kontrol (Logika Perulangan)

Selamat datang di **Pelajaran 4: Struktur Kontrol Perulangan (`while` dan `for`)**.

-----

### \#\# Mengapa Kita Butuh Perulangan (Loop)?

Bayangkan Anda ingin menampilkan "Halo Dunia" sebanyak 5 kali. Tentu Anda bisa menulis `Console.WriteLine()` sebanyak 5 kali. Tapi bagaimana jika Anda ingin menampilkannya 1000 kali? Tentu tidak efisien.

Perulangan atau **Loop** adalah sebuah instruksi untuk menyuruh program menjalankan blok kode yang sama berulang kali sampai sebuah kondisi tertentu terpenuhi.

Ada dua jenis loop utama yang akan kita pelajari: `while` dan `for`.

-----

### \#\# 1. `while` Loop - "Selama Kondisi Benar, Terus Lakukan"

Loop `while` adalah yang paling dasar. Ia akan terus mengulang blok kode **selama** kondisi yang ada di dalam kurung `()` bernilai `true`.

**Analogi:** Bayangkan Anda sedang berlari di treadmill. **Selama** tombol "start" menyala (`true`), treadmill akan terus berputar. Begitu tombolnya Anda matikan (`false`), treadmill akan berhenti. Anda tidak tahu pasti berapa langkah yang akan Anda ambil, Anda hanya tahu Anda akan terus berlari selama tombolnya menyala.

Struktur dasarnya:

```csharp
// 1. Inisialisasi: Siapkan variabel 'saklar' atau 'penghitung' sebelum loop
int hitungan = 1;

// 2. Kondisi: Loop akan berjalan selama 'hitungan' masih kurang dari atau sama dengan 5
while (hitungan <= 5)
{
    Console.WriteLine($"Ini adalah putaran ke-{hitungan}");
    
    // 3. Update: Ubah nilai variabel di dalam loop agar suatu saat kondisi menjadi false.
    // Jika baris ini lupa, akan terjadi 'infinite loop'!
    hitungan++; // Ini sama dengan hitungan = hitungan + 1;
}

Console.WriteLine("Loop selesai!");
```

**Output:**

```
Ini adalah putaran ke-1
Ini adalah putaran ke-2
Ini adalah putaran ke-3
Ini adalah putaran ke-4
Ini adalah putaran ke-5
Loop selesai!
```

**Kapan digunakan?** Saat Anda tidak tahu pasti berapa kali perulangan akan terjadi. Contohnya: "Terus minta input dari pengguna **selama** inputnya bukan 'exit'".

-----

### \#\# 2. `for` Loop - "Lakukan Sebanyak X Kali"

Loop `for` adalah versi yang lebih terstruktur dan sering digunakan ketika Anda **tahu pasti** berapa kali Anda ingin melakukan perulangan.

**Analogi:** Bayangkan Anda sedang angkat beban. Anda sudah punya rencana pasti: "Saya akan melakukan ini **untuk** 10 repetisi". Anda tahu persis kapan akan mulai dan kapan akan berhenti.

Loop `for` merangkum 3 bagian penting dari `while` (Inisialisasi, Kondisi, dan Update) ke dalam satu baris yang rapi.

Struktur dasarnya:

```csharp
//      (1. Inisialisasi;  2. Kondisi;       3. Update)
for (int i = 1;         i <= 5;          i++)
{
    // Variabel 'i' hanya hidup di dalam loop 'for' ini.
    Console.WriteLine($"Ini adalah putaran ke-{i}");
}

Console.WriteLine("Loop selesai!");
```

Kode ini menghasilkan output yang **sama persis** dengan contoh `while` di atas, tetapi jauh lebih ringkas.

**Kapan digunakan?** Saat Anda tahu jumlah perulangannya. Ini sangat umum untuk memproses data dalam koleksi seperti Array atau List, yang akan kita pelajari selanjutnya.

-----

### ✍️ Latihan untuk Anda: "FizzBuzz Challenge"

Ini adalah tantangan pemrograman klasik yang diberikan kepada para developer baru untuk menguji pemahaman mereka tentang loop dan `if-else`.

**Tugas:**

1.  Buat sebuah `for` loop yang berjalan dari angka **1** sampai **100**.
2.  Di dalam setiap putaran loop, periksa angka saat ini (`i`):
    * **Jika** angkanya habis dibagi 3 DAN habis dibagi 5 (misalnya 15), tampilkan teks: `"FizzBuzz"`
    * **Jika tidak**, periksa lagi: **Jika** angkanya hanya habis dibagi 3 (misalnya 3, 6, 9), tampilkan teks: `"Fizz"`
    * **Jika tidak**, periksa lagi: **Jika** angkanya hanya habis dibagi 5 (misalnya 5, 10, 20), tampilkan teks: `"Buzz"`
    * **Jika tidak memenuhi semua kondisi di atas**, tampilkan angka itu sendiri.

**Petunjuk:** Anda akan membutuhkan operator modulo (`%`). Sebuah angka `x` habis dibagi `y` jika `x % y == 0`. Anda juga akan butuh operator `&&` (AND) untuk kondisi pertama.

**Contoh beberapa baris pertama outputnya:**

```
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
... dan seterusnya sampai 100
```

Ini adalah latihan yang sangat baik karena menggabungkan pelajaran kita sebelumnya tentang `if-else` dengan pelajaran hari ini tentang `for` loop. Selamat mencoba\!
