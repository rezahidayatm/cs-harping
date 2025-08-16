/* ==================================================
 * 1.2. Variabel
 * Bayangkan Anda sedang merapikan sebuah ruangan.
 * Anda pasti butuh beberapa kotak untuk menyimpan
 * barang-barang Anda, dan setiap kotak diberi label
 * agar Anda tahu isinya.
 * 
 * Dalam pemrograman, Variabel adalah persis seperti
 * kotak penyimpanan berlabel itu. Fungsinya adalah
 * untuk menyimpan sebuah nilai (data) di dalam
 * memori komputer agar bisa kita gunakan nanti.
 * ==================================================
 */

/* // Kita akan mendeklarasikan beberapa variabel untuk menyimpan datadiri
 * // Ini adalah komentar, baris yang diawali '//' akan diabaikan oleh komputer
 *
 * // 1. Variabel untuk menyimpan nama (menggunakan string)
 * string nama = "Budi Setiawan";
 *
 * // 2. Variabel untuk menyimpan umur (menggunakan int)
 * int umur = 30;
 *
 * // 3. Variabel untuk menyimpan tinggi badan dalam meter (menggunakan double)
 * double tinggiDalamMeter = 1.72;
 * 
 * // 4. Variabel untuk status pernikahan (menggunakan bool)
 * bool sudahMenikah = true;
 *
 * // Sekarang, kita tampilkan semua informasi ini ke konsol
 * Console.WriteLine("--- Biodata Diri ---");
 * Console.WriteLine($"Nama Lengkap: {nama}");
 * Console.WriteLine($"Umur: {umur} tahun");
 * Console.WriteLine($"Tinggi Badan: {tinggiDalamMeter} meter");
 * Console.WriteLine($"Status Pernikahan: {sudahMenikah}");
*/



string judulFilm    = "John Wick";
int    tahunRilis   = 2014;
double ratingIMDB   = 7.5;
bool   sudahNonton  = true;
string sinopsisIMDB = "John Wick is a former hitman grieving "    +
                      "the loss of his true love. When his home " +
                      "is broken into, robbed, and his dog "      +
                      "killed, he is forced to return to action " +
                      "to exact revenge.";

Console.WriteLine(      "--- Film Favorit ---"       );
Console.WriteLine( $"Judul Film   : {judulFilm}"     );
Console.WriteLine( $"Tahun Rilis  : {tahunRilis}"    );
Console.WriteLine( $"Rating IMDB  : {ratingIMDB}/10" );
Console.WriteLine( $"Sudah Nonton : {sudahNonton}"   );
Console.WriteLine( $"Judul Film   : {sinopsisIMDB}"  ); // <-



/*
 * KESALAHAN.
 * // Di baris terakhir kode Anda:
 * Console.WriteLine( $"Judul Film   : {sinopsisIMDB}"  ); 
 */

/* ==================================================
 * Tips Menangani Teks Panjang (Multiline String)
 * ==================================================
 * string sinopsisIMDB = @"John Wick is a former
 * hitman grieving the loss of his true love. When
 * his home is broken into, robbed, and his dog
 * killed, he is forced to return to action to exact
 * revenge.";
 * ==================================================
 */