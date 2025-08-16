/* ==================================================
 * 1.2. Variabel
 * ==================================================
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



string judulFilm      = "John Wick";
int    tahunRilis     = 2014;
double ratingIMDB     = 7.5;
bool   sudahNonton    = true;
string sinopsisIMDB   = "John Wick is a former hitman grieving "    +
                        "the loss of his true love. When his home " +
                        "is broken into, robbed, and his dog "      +
                        "killed, he is forced to return to action " +
                        "to exact revenge.";

Console.WriteLine(       "--- Film Favorit ---"       );
Console.WriteLine( $"Judul Film   : {judulFilm}"      );
Console.WriteLine( $"Tahun Rilis  : {tahunRilis}"     );
Console.WriteLine( $"Rating IMDB  : {ratingIMDB}/10"  );
Console.WriteLine( $"Sudah Nonton : {sudahNonton}"    );
Console.WriteLine( $"Judul Film   : {sinopsisIMDB}"   ); // <-



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
