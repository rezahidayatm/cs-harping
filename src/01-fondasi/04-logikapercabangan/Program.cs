/* ==================================================
 * 1.4. Struktur Kontrol (Logika Percabangan)
 * ==================================================
 * Bayangkan program Anda sedang berjalan dan tiba di
 * sebuah persimpangan. Ia harus bertanya, "Apakah
 * saya harus belok kiri atau kanan?" Pernyataan
 * `if-else` adalah rambu lalu lintas yang
 * memberitahu program jalan mana yang harus diambil
 * berdasarkan sebuah kondisi.
 * ==================================================
 */



// Data admin
string nama = "Keanu Reeves";
string username = "keanureeves";
string password = "rahasiarahasia";

// Program
Console.WriteLine("Bank Sederhana");
Console.WriteLine("--------------\n");
Console.WriteLine("Tekan enter untuk melanjutkan. Atau, tekan 1 untuk masuk ke halaman admin.");
Console.Write("> ");

bool halamanAdmin = false;
string? input = Console.ReadLine();

if (input is "1")
{
    halamanAdmin = true;
}

if (halamanAdmin)
{
    Console.WriteLine("Silahkan masukkan username admin anda.");
    Console.Write("> ");
    string? inputUsernameAdmin = Console.ReadLine();

    Console.WriteLine("Silahkan masukkan password admin anda.");
    Console.Write("> ");
    string? inputPasswordAdmin = Console.ReadLine();

    if (inputUsernameAdmin == username && inputPasswordAdmin == password) // Jika input benar.
    {
        Console.WriteLine($"Selamat datang {nama}. Silahkan pilih aksi: ...");
    }
    else if (inputPasswordAdmin != password) // Jika password salah.         // <-
    {
        Console.WriteLine("Password salah!");
    }
    else // Selain itu.
    {
        Console.WriteLine("Username tidak ditemukan!");
    }

    return; // Keluar.
}

Console.WriteLine("Selamat datang nasabah. Silahkan masukkan username nasabah anda. ...");



/* ==================================================
 * Kode Anda sudah hampir sempurna. Namun, ada satu
 * jebakan logika kecil di bagian else if Anda yang
 * seringkali menjebak bahkan programmer berpengalaman
 * sekalipun. Mari kita telusuri alur berpikir komputer.
 *
 * Inilah logika Anda:

 if (inputUsernameAdmin == username && inputPasswordAdmin == password) // 1. Cek jika keduanya benar
 {
     // ...
 }
 else if (inputPasswordAdmin != password) // 2. Cek jika password salah
 {
     Console.WriteLine("Password salah!");
 }
 else    // 3. Selain itu
 {
     Console.WriteLine("Username tidak ditemukan!");
 }

 * Sekarang, mari kita simulasikan apa yang terjadi
 * jika pengguna memasukkan username yang salah DAN
 * password yang salah:
 *
 * 1. Komputer memeriksa if pertama. inputUsername
 *    salah, jadi false && false hasilnya false. Komputer
 *    lanjut ke else if.
 * 2. Komputer memeriksa else if. Kondisinya adalah
 *    inputPasswordAdmin != password. Karena pengguna
 *    memasukkan password yang salah, kondisi ini
 *    bernilai true!
 * 3. Akibatnya, program akan mencetak "Password
 *    salah!", padahal seharusnya yang lebih tepat adalah
 *    "Username tidak ditemukan!", karena username-nya
 *    saja sudah tidak cocok.
 *
 * Logika yang benar adalah: kita hanya perlu memeriksa
 * password jika kita sudah tahu username-nya benar.
 *
 * Berikut adalah struktur logika yang lebih akurat:

 if (inputUsernameAdmin == username && inputPasswordAdmin == password)
 {
    // Jika kita di sini, artinya username DAN password sudah pasti benar.
    Console.WriteLine($"Selamat datang {nama}. Silahkan pilih aksi: ...");
 }
 else if (inputUsernameAdmin == username) // <-- Kuncinya di sini!
 {
    // Jika kita sampai di sini, itu berarti kondisi `if` pertama gagal.
    // TAPI, username-nya COCOK.
    // Satu-satunya alasan `if` pertama gagal adalah karena PASSWORD PASTI SALAH.
    Console.WriteLine("Password salah!");
 }
 else
 {
    // Jika kita sampai di sini, itu berarti username saja sudah tidak cocok dari awal.
    // Kita tidak perlu lagi peduli dengan passwordnya.
    Console.WriteLine("Username tidak ditemukan!");
 }

 * Dengan struktur ini, pengecekan menjadi lebih
 * terurut dan akurat. Program akan memprioritaskan
 * kesalahan username sebelum memeriksa password.
 * ==================================================
 */