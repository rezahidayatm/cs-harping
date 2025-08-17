/* ==================================================
 * 1.6 Koleksi Data Sederhana
 * ==================================================
 * Bayangkan sejauh ini variabel kita (int, string,
 * dll.) adalah sebuah laci tunggal. Anda hanya bisa
 * menyimpan satu barang di dalamnya. Sekarang,
 * bagaimana jika Anda ingin menyimpan seluruh set
 * pakaian atau koleksi buku? Anda butuh lemari atau
 * rak buku.
 * 
 * Dalam C#, "lemari" atau "rak buku" itu disebut
 * Koleksi (Collection). Ini adalah variabel spesial
 * yang bisa menampung banyak nilai sekaligus. Dua
 * koleksi paling dasar dan penting adalah Array dan
 * List.
 * ==================================================
 */



// Sediakan tempat untuk playlist.
List<string> playlist = [];

// Preadd playlist.
playlist.Add("The Subway")    ;
playlist.Add("Pink Pony Club");
playlist.Add("The Giver")     ;

// Program dimulai.
Console.WriteLine("== Pemutar Lagu ==\n");

while (true)
{
    
    Console.WriteLine("Pilih Aksi")      ;
    Console.WriteLine("1. Mainkan")      ;
    Console.WriteLine("2. Berhenti")     ;
    Console.WriteLine("3. Jeda")         ;
    Console.WriteLine("4. Edit Playlist");
    Console.WriteLine("0. Keluar")       ;
    Console.Write("> ")                  ;
    
    string? input = Console.ReadLine();
    
    switch (input)
    {
        
        case "1" :
            Console.WriteLine("\nLagu dimainkan...\n");
            break;
        case "2" :
            Console.WriteLine("\nLagu berhenti...\n");
            break;
        case "3" : 
            Console.WriteLine("\nLagu dijeda...\n");
            break;
        case "4" :

            while (true)
            {
                
                Console.WriteLine("Edit Playlist:")    ;
                Console.WriteLine("1. Lihat playlist") ;
                Console.WriteLine("2. Tambah Playlist");
                Console.WriteLine("3. Hapus Playlist") ;
                Console.WriteLine("0. Keluar")         ;
                Console.Write("> ")                    ;
                
                input = Console.ReadLine();
                
                switch (input)
                {
                    
                    case "1" :
                        
                        Console.WriteLine("\nDaftar Playlist anda:\n");
                        
                        foreach (string item in playlist)
                        {
                            int i = 1;                          // <-
                            
                            Console.WriteLine($"{i}. {item}");
                            i++;
                            
                        }
                        
                        Console.WriteLine($"\nTotal: {playlist.Count}\n");
                        continue;
                        
                    case "2" : 
                        
                        Console.WriteLine("Lagu di playlist");
                        
                        foreach (string item in playlist)
                        {
                            Console.WriteLine($"-. {item}");
                        }
                        
                        Console.WriteLine("\nTambah lagu: ");
                        Console.Write("> ")                 ;
                        
                        string? judulLaguBaru = Console.ReadLine();
                        

                        if (!playlist.Contains(judulLaguBaru))
                        {
                            playlist.Add(judulLaguBaru);
                                                    
                            Console.WriteLine($"\nanda berhasil menambahkan {judulLaguBaru} ke playlist.");
                            
                            foreach (string item in playlist)
                            {
                                Console.WriteLine($"-. {item}");
                            }
                            
                            Console.WriteLine($"Total semua lagu: {playlist.Count}\n");
                        }
                        else
                        {
                            Console.WriteLine("\nLagu sudah ada\n");
                        }
                        continue;
                        
                    case "3":
                        
                        Console.WriteLine("Lagu di playlist");
                        
                        foreach (string item in playlist)
                        {
                            Console.WriteLine($"-. {item}");
                        }
                        
                        Console.WriteLine("\nHapus Lagu:");
                        Console.Write("> ")               ;
                        
                        string? judulLaguHapus = Console.ReadLine();
                        
                        if (playlist.Contains(judulLaguHapus))
                        { 
                            playlist.Remove(judulLaguHapus);
                            
                            Console.WriteLine($"\nanda berhasil menghapus {judulLaguHapus} dari playlist.");
                            
                            foreach (string item in playlist)
                            {
                                Console.WriteLine($"-. {item}");
                            }
                            
                            Console.WriteLine($"Total semua lagu: {playlist.Count}\n");
                        }
                        else
                        {
                            Console.WriteLine("\nLagu tidak ada\n");
                        }
                        continue;
                        
                    case "0" :
                        break;
                    default  :
                        Console.WriteLine("\nPilihan tidak tersedia\n");
                        continue;
                        
                }
                break;
            }
            break;
        
        case "0"  : 
            return;
        default   :
            Console.WriteLine("\nPilihan tidak tersedia\n");
            break;
            
    }
}



/* ==================================================
 * Sedikit Tantangan: Mencari Bug
 * ==================================================
 * Lihatlah potongan kode ini dari bagian "Lihat
 * playlist":
 
 foreach (string item in playlist)
 {
     int i = 1; // <-- Perhatikan baris ini
        
     Console.WriteLine($"{i}. {item}");
     i++;
 }
 
 * Pertanyaan: Apa yang akan terjadi pada nilai i
 * setiap kali loop ini berputar ke lagu berikutnya?
 *
 * Jawaban: Variabel int i = 1; dideklarasikan di
 * dalam loop. Artinya, setiap kali loop memulai
 * putaran baru untuk lagu berikutnya, i akan selalu
 * dibuat ulang dan di-reset kembali menjadi 1.
 * Hasilnya, output Anda akan selalu menampilkan "1."
 * untuk setiap lagu.
 *
 * Solusi yang Benar:
 * Deklarasikan variabel penghitung sebelum loop dimulai.
 
 Console.WriteLine("\nDaftar Playlist anda:\n");

 int nomorLagu = 1; // Deklarasikan di luar loop
 foreach (string item in playlist)
 {
     Console.WriteLine($"{nomorLagu}. {item}");
     nomorLagu++; // Cukup naikkan nilainya di dalam loop
 }
 
 Console.WriteLine($"\nTotal: {playlist.Count}\n");
 
 * Solusi Alternatif (Menggunakan for loop):
 * Untuk kasus di mana Anda butuh nomor indeks, for
 * loop seringkali menjadi pilihan yang lebih alami
 * karena ia sudah memiliki penghitung bawaan.
 
 Console.WriteLine("\nDaftar Playlist anda:\n");

 for (int i = 0; i < playlist.Count; i++)
 {
     // i dimulai dari 0, jadi kita tambah 1 untuk tampilan
     Console.WriteLine($"{i + 1}. {playlist[i]}"); 
 }
 
 Console.WriteLine($"\nTotal: {playlist.Count}\n");
 
 * ==================================================
 */