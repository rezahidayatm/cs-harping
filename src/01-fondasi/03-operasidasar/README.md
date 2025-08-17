### 1. Operator Aritmetika (Matematika) ➕➖✖️➗

Ini adalah operator yang Anda kenal dari pelajaran matematika. C\# bisa berfungsi sebagai kalkulator yang sangat canggih.

* `+`  **Penjumlahan**
* `-`  **Pengurangan**
* `*`  **Perkalian**
* `/`  **Pembagian**
* `%`  **Modulo** (Sisa hasil bagi)

**Apa itu Modulo (`%`)?**
Operator ini akan memberikan sisa dari sebuah operasi pembagian. Ini sangat berguna\!
Contoh: `10 % 3` akan menghasilkan `1`, karena 10 dibagi 3 adalah 3 dengan **sisa 1**.
Contoh lain: `12 % 2` akan menghasilkan `0`, karena 12 habis dibagi 2.

```csharp
int a = 10;
int b = 3;

Console.WriteLine($"Penjumlahan: {a + b}");   // Output: 13
Console.WriteLine($"Pengurangan: {a - b}");   // Output: 7
Console.WriteLine($"Perkalian: {a * b}");     // Output: 30
Console.WriteLine($"Pembagian: {a / b}");       // Output: 3 (karena int tidak punya koma)
Console.WriteLine($"Modulo (Sisa Bagi): {a % b}"); // Output: 1
```

**Penting:** Jika Anda membagi dua buah `int`, hasilnya akan selalu `int` (bagian desimalnya akan dihilangkan). Jika Anda ingin hasil yang presisi, pastikan salah satu angkanya adalah `double`.
Contoh: `10.0 / 3` akan menghasilkan `3.333...`.

-----

### 2. Penggabungan String (Concatenation) 🔗

Anda sudah pernah melihat ini, yaitu cara menggabungkan beberapa teks menjadi satu.

**Cara Klasik (dengan `+`)**

```csharp
string namaDepan = "Keanu";
string namaBelakang = "Reeves";
string spasi = " ";

string namaLengkap = namaDepan + spasi + namaBelakang;
Console.WriteLine(namaLengkap); // Output: Keanu Reeves
```

**Cara Modern & Direkomendasikan (dengan String Interpolation `$`)**
Cara ini jauh lebih mudah dibaca dan ditulis. Selalu utamakan cara ini\!

```csharp
string namaLengkapModern = $"{namaDepan} {namaBelakang}";
Console.WriteLine(namaLengkapModern); // Output: Keanu Reeves
```

-----

### 3. Operator Penugasan Singkat (Shorthand) `+=`

Seringkali kita ingin mengubah nilai sebuah variabel berdasarkan nilainya saat ini (misalnya, menambah skor).

**Cara Panjang:**

```csharp
int skor = 100;
skor = skor + 10; // skor sekarang menjadi 110
```

**Cara Singkat (Shorthand):**
C\# menyediakan jalan pintas yang lebih rapi untuk operasi seperti ini.

```csharp
int skor = 100;
skor += 10; // Ini artinya sama dengan skor = skor + 10. Skor sekarang 110.

int sisaAmunisi = 50;
sisaAmunisi -= 5; // sisaAmunisi sekarang 45.
```

Ini berlaku untuk semua operator aritmetika (`+=`, `-=`, `*=`, `/=`).

**Pintasan Paling Umum: Increment (`++`) dan Decrement (`--`)**
Untuk menambah atau mengurangi nilai **sebanyak 1**, ada cara yang lebih singkat lagi.

```csharp
int nyawaPemain = 3;
nyawaPemain--; // Mengurangi 1. nyawaPemain sekarang 2.

int level = 9;
level++; // Menambah 1. level sekarang 10.
```

-----

### 4. Urutan Operasi (Order of Operations)

Sama seperti di matematika, C\# mengikuti urutan operasi (biasa dikenal sebagai **PEMDAS/BODMAS**). Perkalian (`*`) dan pembagian (`/`) akan selalu didahulukan sebelum penjumlahan (`+`) dan pengurangan (`-`).

Gunakan tanda kurung `()` untuk mengontrol urutan eksekusi.

```csharp
// Perkalian dulu: 5 + (2 * 10) = 5 + 20 = 25
int hasil1 = 5 + 2 * 10; 
Console.WriteLine(hasil1); // Output: 25

// Tanda kurung dulu: (5 + 2) * 10 = 7 * 10 = 70
int hasil2 = (5 + 2) * 10;
Console.WriteLine(hasil2); // Output: 70
```

-----

### ✍️ Latihan untuk Anda: "Struk Belanja Sederhana"

Saatnya praktik\! Buatlah sebuah program konsol baru untuk mensimulasikan perhitungan belanja.

**Tugas:**

1.  Buat variabel untuk menyimpan harga dua item, misalnya `hargaBuku` (`double`) dan `hargaPensil` (`double`).
2.  Buat variabel untuk menyimpan jumlah item yang dibeli, misalnya `jumlahBuku` (`int`) dan `jumlahPensil` (`int`).
3.  Hitung total harga untuk masing-masing item (harga \* jumlah). Simpan dalam variabel baru.
4.  Hitung total keseluruhan belanjaan (total harga buku + total harga pensil).
5.  Tampilkan hasilnya dalam format struk yang rapi ke konsol, seperti contoh di bawah ini.

**Contoh Output yang Diharapkan:**

```
--- STRUK BELANJA ---
- Buku (3 x 50000): 150000
- Pensil (2 x 5000): 10000
-----------------------
TOTAL BELANJA: 160000
```

Ini akan melatih kemampuan Anda menggunakan operator aritmetika dan memformat string. Selamat mencoba, dan jangan ragu bertanya jika ada kendala\!