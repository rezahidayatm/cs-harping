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



// Ambil data
using MetodeFungsi;

Kucing kucing = new Kucing();

// Tambah data baru
Console.WriteLine("\nAdopsi Kucing Baru\n");

Console.WriteLine("\nNamanya siapa?.");
Console.Write("> ");

string? namaBaru = Console.ReadLine();
kucing.Nama = namaBaru;

Console.WriteLine("\nWarnanya apa?.");
Console.Write("> ");

string? warnaBaru = Console.ReadLine();
kucing.Warna = warnaBaru;

// Value awal
int balance = 100;
kucing.Energi = 50;
kucing.Umur = 1;

Console.WriteLine($"\nSelamat datang {kucing.Nama}. Kucing {kucing.Warna} ini " +
                  $"berumur {kucing.Umur} tahun. dia akan menemani kamu bermai" +
                  $"n.\n");

// Mulai loop
bool triggerInfo = false;
while (true)
{
    // Cek event
    Event.UlangTahun(kucing.Nama, kucing.Umur);

    // Info pertama kali main
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