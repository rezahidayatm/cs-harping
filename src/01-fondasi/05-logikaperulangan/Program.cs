/* ==================================================
 * 1.5. Struktur Kontrol (Logika Perulangan)
 * ==================================================
 * Perulangan atau Loop adalah sebuah instruksi untuk
 * menyuruh program menjalankan blok kode yang sama
 * berulang kali sampai sebuah kondisi tertentu
 * terpenuhi.
 * ==================================================
 */



Console.WriteLine("\n ------------------------ ");
Console.WriteLine(" == FizzBuzz Challenge == ")  ;
Console.WriteLine(" ------------------------ \n");

int fizzBuzz = 0;
int fizz     = 0;
int buzz     = 0;

for (int i = 1; i <= 100; i++)
{
    
    if (i % 3 is 0 && i % 5 is 0)
    {
        Console.WriteLine(" ========");
        Console.WriteLine(" FizzBuzz");
        Console.WriteLine(" ========");
        fizzBuzz++;
        continue;
    }
    
    if (i % 3 is 0)
    {
        Console.WriteLine(" ********");
        Console.WriteLine(" * Fizz *");
        Console.WriteLine(" ********");
        fizz++;
        continue;
    }

    if (i % 5 is 0)
    {
        Console.WriteLine(" ++++++++");
        Console.WriteLine(" + Buzz +");
        Console.WriteLine(" ++++++++");
        buzz++;
        continue;
    }
    
    Console.WriteLine($" - {i} -");
    
}
Console.WriteLine("\n ------------------------- ")       ;
Console.WriteLine(" |         Total         |")          ;
Console.WriteLine(" ------------------------- ")         ;
Console.WriteLine($" | FizzBuzz  = {fizzBuzz}         |");
Console.WriteLine($" | Fizz      = {fizz}        |")     ;
Console.WriteLine($" | Buzz      = {buzz}        |" )    ;
Console.WriteLine(" -------------------------    ")      ;



/* ==================================================
 * Pelajaran Penting:
 * Readability vs. Micro-Optimization
 * ==================================================
 * Ini membawa kita pada salah satu pelajaran paling
 * penting dalam pengembangan perangkat lunak
 * profesional:
 *
 * Untuk sebagian besar kasus, keterbacaan kode
 * (Readability) jauh lebih penting daripada
 * optimalisasi mikro (micro-optimization).
 *
 * Mari bandingkan lagi kedua pendekatan:
 *
 * 1. Solusi Anda
 *  a. Cara kerja: Cek setiap kondisi secara
 *     independen, dan lompat jika salah satunya
 *     benar.
 *  b. Kelebihan: Sangat cerdas dan menunjukkan
 *     pemahaman tentang alur kontrol loop.
 *
 * 2. Solusi if-else if-else

 if (i % 3 == 0 && i % 5 == 0)
 {
    Console.WriteLine("FizzBuzz");
 }
 else if (i % 3 == 0)
 {
    Console.WriteLine("Fizz");
 }
 else if (i % 5 == 0)
 {
    Console.WriteLine("Buzz");
 }
 else
 {
    Console.WriteLine(i);
 }
 
 *  a. Cara kerja: Cek kondisi secara berurutan.
 *     Begitu satu ditemukan benar, sisanya diabaikan.
 *  b. Kelebihan: Bagi banyak programmer, ini secara
 *     eksplisit menyatakan "hanya satu dari pilihan
 *     ini yang akan terjadi", yang membuat niat
 *     (intent) dari kode tersebut sangat jelas dan
 *     mudah dibaca.
 *
 * Keduanya adalah cara yang benar untuk
 * menyelesaikan masalah ini. Tidak ada yang lebih
 * baik secara absolut, tetapi keduanya memiliki
 * sedikit "rasa" yang berbeda.
 * 1. if-else if-else: Struktur ini secara eksplisit
 *    memberitahu pembaca kode bahwa "hanya salah satu
 *    dari blok-blok ini yang akan pernah dijalankan".
 *    Ini sering dianggap sedikit lebih mudah dibaca
 *    untuk masalah di mana pilihannya saling eksklusif
 *    (seperti FizzBuzz).
 * 2. if dengan continue (Cara Anda): Struktur ini
 *    sangat kuat dalam loop yang lebih kompleks. Ini
 *    berguna ketika ada beberapa kondisi independen
 *    yang ingin Anda periksa, dan jika salah satunya
 *    terpenuhi, Anda ingin segera beralih ke item
 *    berikutnya.
 * ==================================================
 */