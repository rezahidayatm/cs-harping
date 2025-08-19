/* ==================================================
 * 2.1. Method/Fungsi
 * ==================================================
 * Ini adalah lompatan besar. Di Fase 1, kita belajar
 * cara menulis instruksi—seperti belajar kata-kata
 * dan kalimat. Di Fase 2 ini, kita akan belajar cara
 * mendesain dan membangun sistem—seperti belajar
 * menulis sebuah cerita atau esai yang terstruktur.
 * ==================================================
 */



// Tambah data baru
Console.WriteLine("\nAdopsi Kucing Baru\n");

Console.WriteLine("\nNamanya siapa?.");
Console.Write("> ");

string? namaBaru = Console.ReadLine();

Console.WriteLine("\nWarnanya apa?.");
Console.Write("> ");

string? warnaBaru = Console.ReadLine();

// Set data
Kucing kucing = new Kucing(namaBaru, warnaBaru);

// Balance awal
int balance = 100;

Console.WriteLine($"\nSelamat datang {kucing.Nama}. Kucing {kucing.Warna} ini " +
                  $"berumur {kucing.Umur} tahun. dia akan menemani kamu bermai" +
                  $"n.\n");

// Mulai loop
bool triggerInfo = false;
while (true)
{
    // Info pertama kali
    if (!triggerInfo)
    {
        Console.WriteLine($"\nKamu akan diberikan balance sebesar " +
                          $"100 untuk pertama kali. \nBalance akan" +
                          $" bertambah jika kucingmu tidur.\n");
        triggerInfo = true;
    }

    Console.WriteLine($"\nNama: {kucing.Nama}");
    Console.WriteLine($"Warna: {kucing.Warna}");
    Console.WriteLine($"Umur: {kucing.Umur}");
    Console.WriteLine($"Energi: {kucing.Energi}");
    Console.WriteLine($"Balance: {balance}\n");

    Console.WriteLine("\nPilih aksi:");
    Console.WriteLine("1. Beri makan");
    Console.WriteLine("2. Main");
    Console.WriteLine("3. Tidur");
    Console.WriteLine("4. Info");
    Console.Write("> ");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            balance -= kucing.Makan(balance);
            break;
        case "2":
            kucing.Bermain();
            break;
        case "3":
            balance += kucing.Tidur();
            break;
        case "4":
            triggerInfo = false;
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Pilihan tidak ada.");
            break;
    }
}


/* ==================================================
 * Output:
 * 
 * Nama: Mei
 * Warna: Oyen
 * Umur: 1,2000000000000002
 * Energi: 100
 * Balance: 64
 *
 * ini terjadi karena cara komputer, yang berpikir
 * dalam biner (basis-2), mencoba merepresentasikan
 * angka desimal (basis-10) seperti 0.1 atau 0.2
 *
 * Komputer berpikir dalam biner (basis-2). Seperti
 * memotong pizza menjadi 2, 4, 8, 16 bagian,
 * komputer sangat hebat dalam merepresentasikan
 * angka seperti 0.5 (1/2), 0.25 (1/4), dan 0.125
 * (1/8) dengan sempurna.
 *
 * Kita berpikir dalam desimal (basis-10). Angka yang
 * terlihat sederhana bagi kita, seperti 0.1 (1/10),
 * adalah angka yang "aneh" bagi komputer. Dalam
 * biner, 0.1 adalah angka desimal yang berulang
 * tanpa akhir (mirip seperti 1/3 menjadi 0.33333...
 * bagi kita).
 *
 *  Bagaimana Cara Mengatasinya?
 *
 * Ini bukan bug dalam kode Anda, melainkan sifat
 * dari tipe data double yang Anda gunakan. Ada dua
 * solusi umum untuk ini:
 *
 * 1. Format Tampilan (Paling Umum)
 * 
 
 // "F1" artinya "format sebagai angka desimal dengan 1 angka di belakang koma"
 Console.WriteLine($"Umur: {kucing.Umur:F1}"); // Output: Umur: 1,2

 // atau "N1" (format angka standar dengan 1 angka di belakang koma)
 Console.WriteLine($"Umur: {kucing.Umur:N1}"); // Output: Umur: 1,2
 
 *
 * 2. Gunakan Tipe Data decimal (Untuk Keuangan)
 * 
 
 // Deklarasi menggunakan 'decimal'
 public decimal Umur { get; private set; }

 // Inisialisasi di constructor
 Umur = 1.0m; // 'm' menandakan ini adalah angka decimal

 // Penambahan
 Umur += 0.1m; // Sekarang hasilnya akan selalu presisi (1.1, 1.2, dst.)
 
 *
 * double: Sangat cepat, bagus untuk sains, grafis,
 * dan game di mana kecepatan lebih penting daripada
 * presisi absolut.
 * decimal: Sedikit lebih lambat, tetapi sangat
 * presisi. Tipe data ini wajib digunakan untuk
 * aplikasi keuangan, perbankan, atau apa pun yang
 * berhubungan dengan uang untuk menghindari
 * kesalahan pembulatan.
 * ==================================================
 */