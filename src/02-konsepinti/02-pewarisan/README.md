## 2.2. Inheritance (Pewarisan)

Selamat datang di **Pelajaran 7: Inheritance (Pewarisan)**.

-----

### \#\# Apa itu Inheritance?

Bayangkan Anda memiliki `class Kucing` yang sudah Anda buat. Lalu, Anda ingin membuat `class Harimau`. Anda akan sadar bahwa Harimau dan Kucing punya banyak kesamaan: keduanya punya nama, umur, bisa makan, dan tidur. Apakah kita harus menyalin-tempel semua kode dari `class Kucing` ke `class Harimau`? Tentu tidak\!

**Inheritance** adalah mekanisme di C\# yang memungkinkan kita membuat sebuah *class baru* (anak) yang **mewarisi** semua properti dan metode dari *class yang sudah ada* (induk).

Ini menciptakan hubungan "adalah sebuah" (**is a**). Contoh: `Kucing` **adalah sebuah** `Hewan`. `Harimau` **adalah sebuah** `Hewan`.

**Keuntungan Utama:**

  * **Code Reusability:** Anda tidak perlu menulis ulang kode yang sama berkali-kali.
  * **Organisasi:** Anda bisa membuat hierarki kelas yang logis dan mudah dikelola.

-----

### \#\# Mari Membangun Hierarki Hewan

Kita akan membuat cetak biru umum untuk semua hewan, lalu membuat hewan-hewan spesifik yang mewarisi sifat-sifat umum tersebut.

#### **Langkah 1: Membuat Class Induk (Base Class)**

Kita buat class `Hewan`. Class ini akan berisi semua hal yang **dimiliki oleh semua hewan** di dalam program kita.

```csharp
// === File: Hewan.cs ===
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; protected set; } // 'protected' berarti hanya class ini dan turunannya yang bisa mengubah.

    // Constructor untuk class Hewan
    public Hewan(string nama)
    {
        Nama = nama;
        Umur = 1;
        Console.WriteLine($"Seekor hewan bernama {Nama} telah lahir.");
    }

    // Metode yang dimiliki semua hewan
    public void Makan()
    {
        Console.WriteLine($"{Nama} sedang makan.");
    }

    public void Tidur()
    {
        Console.WriteLine($"{Nama} sedang tidur.");
    }
    
    // 'virtual' berarti metode ini BOLEH diubah (di-override) oleh class anak.
    public virtual void Bersuara()
    {
        Console.WriteLine($"{Nama} mengeluarkan suara...");
    }
}
```

#### **Langkah 2: Membuat Class Anak (Derived Class)**

Sekarang, kita buat `class Kucing` yang mewarisi dari `Hewan`.

```csharp
// === File: Kucing.cs ===

// Tanda ':' menunjukkan bahwa Kucing mewarisi dari Hewan
public class Kucing : Hewan
{
    // Constructor untuk Kucing
    // ': base(nama)' artinya "oper nilai 'nama' ini ke constructor class induk (Hewan)"
    public Kucing(string nama) : base(nama)
    {
        Console.WriteLine($"Dan ternyata dia adalah seekor kucing!");
    }

    // 'override' digunakan untuk memberikan implementasi baru pada metode 'virtual' dari induknya.
    public override void Bersuara()
    {
        Console.WriteLine($"{Nama} berkata: Meow!");
    }
    
    // Metode yang hanya dimiliki oleh Kucing
    public void MengejarLaser()
    {
        Console.WriteLine($"{Nama} sedang asyik mengejar titik laser.");
    }
}
```

#### **Langkah 3: Melihat Aksi di `Program.cs`**

```csharp
// === File: Program.cs ===

// Membuat object dari class anak
Kucing oyen = new Kucing("Oyen");

Console.WriteLine("\n--- Aksi Kucing Oyen ---");

// Memanggil metode yang DIWARISI dari Hewan
oyen.Makan(); 
oyen.Tidur();

// Memanggil metode yang di-OVERRIDE oleh Kucing
oyen.Bersuara(); 

// Memanggil metode SPESIFIK milik Kucing
oyen.MengejarLaser(); 
```

**Outputnya akan menjadi:**

```
Seekor hewan bernama Oyen telah lahir.
Dan ternyata dia adalah seekor kucing!

--- Aksi Kucing Oyen ---
Oyen sedang makan.
Oyen sedang tidur.
Oyen berkata: Meow!
Oyen sedang asyik mengejar titik laser.
```

Lihat? `object oyen` bisa mengakses metode dari `Hewan` dan juga metode spesifik dari `Kucing`.

-----

### ✍️ Latihan untuk Anda: "Buat Class Anjing"

Sekarang giliran Anda untuk memperluas hierarki ini.

**Tugas:**

1.  Buat `class` baru bernama `Anjing` yang juga mewarisi dari `Hewan`.
2.  Pastikan `constructor`-nya memanggil `constructor` `base` (induk), sama seperti `Kucing`.
3.  **Override** metode `Bersuara()` agar menampilkan pesan seperti `"[Nama Anjing] berkata: Guk! Guk!"`.
4.  Tambahkan satu metode **spesifik** untuk `Anjing`, misalnya `void AmbilTongkat()`.
5.  Di `Program.cs`, buatlah sebuah `object` `Anjing` baru dan panggil semua metodenya (yang diwarisi, di-override, dan yang spesifik) untuk membuktikan semuanya bekerja.

Di pelajaran selanjutnya, kita akan melihat keajaiban sesungguhnya dari Inheritance saat kita membahas **Polimorfisme**—bagaimana kita bisa memasukkan `Kucing` dan `Anjing` ke dalam satu `List<Hewan>`\!