## 2.1. Method/Fungsi

Ini adalah lompatan besar. Di Fase 1, kita belajar cara menulis instruksi—seperti belajar kata-kata dan kalimat. Di Fase
2 ini, kita akan belajar cara **mendesain dan membangun sistem**—seperti belajar menulis sebuah cerita atau esai yang
terstruktur.

Kita akan memulai dengan topik yang menjadi jantung dari C\# dan pemrograman modern: **Class dan Object**.

-----

### \#\# Pelajaran 5: Class dan Object - Cetak Biru dan Bangunan

Sampai sekarang, kita menggunakan tipe data sederhana seperti `int` dan `string`. Tapi bagaimana jika kita ingin
merepresentasikan sesuatu yang lebih kompleks, seperti "Mobil", "Pemain", atau "Produk"? Sesuatu yang punya **data** (
seperti warna, kecepatan) sekaligus **perilaku** (seperti bisa `maju()` atau `rem()`).

Di sinilah **Class** dan **Object** berperan.

#### **Class adalah Cetak Biru (Blueprint)** blueprints

Sebuah **Class** adalah sebuah **template** atau **cetak biru**. Ia tidak melakukan apa-apa. Ia hanya sebuah desain yang
mendefinisikan:

* **Properti (Properties):** Data atau atribut apa yang akan dimiliki oleh objek dari class ini? (Contoh: Mobil punya
  `Warna`, `JumlahPintu`, `KecepatanMaksimal`).
* **Metode (Methods):** Perilaku atau aksi apa yang bisa dilakukan? (Contoh: Mobil bisa `NyalakanMesin()`, `Gas()`,
  `Rem()`).

Anda tidak bisa mengendarai sebuah cetak biru mobil.

#### **Object adalah Bangunan Nyata (Instance)**

Sebuah **Object** adalah **hasil nyata** yang dibuat dari sebuah `Class`. Ia adalah sebuah **instance** (perwujudan)
dari cetak biru tersebut.

Dari satu `Class` (cetak biru) `Mobil`, Anda bisa membuat **banyak Object** (mobil nyata): mobil merah, mobil biru,
mobil hitam. Masing-masing adalah objek yang independen dengan propertinya sendiri (warnanya beda-beda), tetapi mereka
semua berbagi perilaku yang sama (semua bisa di-gas).

-----

### \#\# Anatomi Sebuah Class: Mari Kita Buat Cetak Biru `Mobil`

Mari kita lihat bagaimana sebuah `Class` ditulis dalam kode.

```csharp
// Ini adalah cetak birunya, biasanya ditaruh di filenya sendiri (misal: Mobil.cs)
public class Mobil
{
    // 1. PROPERTI: Data yang dimiliki setiap mobil.
    // 'get' artinya nilainya bisa dibaca.
    // 'set' artinya nilainya bisa diubah.
    public string Warna { get; set; }
    public int Kecepatan { get; private set; } // Kecepatan hanya bisa diubah dari dalam class ini.

    // 2. CONSTRUCTOR: Method spesial yang dijalankan saat sebuah object Mobil BARU dibuat.
    // Tugasnya adalah menyiapkan kondisi awal objek.
    public Mobil(string warnaAwal)
    {
        Warna = warnaAwal;
        Kecepatan = 0; // Setiap mobil baru kecepatannya dimulai dari 0.
        Console.WriteLine($"Sebuah mobil berwarna {Warna} telah dibuat!");
    }

    // 3. METODE: Aksi atau perilaku yang bisa dilakukan mobil.
    public void Gas()
    {
        Kecepatan += 10; // Menambah kecepatan
        Console.WriteLine($"Mobil {Warna} melaju. Kecepatan sekarang: {Kecepatan} km/jam.");
    }

    public void Rem()
    {
        Kecepatan -= 5; // Mengurangi kecepatan
        Console.WriteLine($"Mobil {Warna} melambat. Kecepatan sekarang: {Kecepatan} km/jam.");
    }
}
```

### \#\# Menggunakan Class untuk Membuat Object

Sekarang kita punya cetak birunya, mari kita "bangun" beberapa mobil di file `Program.cs` kita.

```csharp
// Di dalam file Program.cs

// Membuat object (instance) pertama dari class Mobil.
// Kita panggil Constructor-nya dan memberikan "Merah" sebagai warna awal.
Mobil mobilSport = new Mobil("Merah");

// Membuat object kedua. Ini adalah mobil yang benar-benar terpisah.
Mobil mobilKeluarga = new Mobil("Biru");

Console.WriteLine("\n--- Aksi Mobil Sport ---");
// Mengakses properti dan memanggil metode menggunakan tanda titik '.'
mobilSport.Gas();
mobilSport.Gas();
mobilSport.Rem();

Console.WriteLine("\n--- Aksi Mobil Keluarga ---");
mobilKeluarga.Gas();

// Anda bisa lihat bahwa kecepatan mobilSport dan mobilKeluarga berbeda,
// karena mereka adalah object yang independen.
Console.WriteLine($"\nKecepatan akhir mobil sport: {mobilSport.Kecepatan} km/jam");
Console.WriteLine($"Kecepatan akhir mobil keluarga: {mobilKeluarga.Kecepatan} km/jam");
```

-----

### ✍️ Latihan untuk Anda: "Class Kucing"

Saatnya Anda mencoba membuat cetak biru sendiri\!

**Tugas:**

1. Buat sebuah `class` baru bernama `Kucing`.
2. Berikan `class` tersebut tiga **properti**: `Nama` (string), `Warna` (string), dan `Umur` (int).
3. Buat sebuah **constructor** yang menerima `nama` dan `warna` saat kucing baru dibuat. Set `Umur` awalnya menjadi `1`.
4. Buat dua **metode**:
    * `void Makan(string makanan)`: Harus menampilkan pesan seperti
      `"[Nama Kucing] sedang makan [makanan] dengan lahap."`
    * `void Tidur()`: Harus menampilkan pesan seperti `"[Nama Kucing] sedang tidur pulas."`
5. Di `Program.cs`, buatlah **dua object** kucing yang berbeda (misalnya, "Oyen" dan "Cimeng"). Panggil metode `Makan()`
   dan `Tidur()` dari masing-masing objek untuk menunjukkan bahwa mereka berperilaku sesuai desain Anda.

Ini adalah langkah besar, jadi jangan ragu untuk bertanya jika ada bagian yang membingungkan. Selamat membangun\!