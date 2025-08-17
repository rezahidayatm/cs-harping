/* ==================================================
 * 1.3. OPERATOR ARITMATIKA
 * ==================================================
 * Ini adalah operator yang Anda kenal dari pelajaran
 * matematika. C# bisa berfungsi sebagai kalkulator
 * yang sangat canggih.
 *
 * `+`  **Penjumlahan**
 * `-`  **Pengurangan**
 * `*`  **Perkalian**
 * `/`  **Pembagian**
 * `%`  **Modulo** (Sisa hasil bagi)
 * ==================================================
 */



// Pembeli
string  pembeliNamaDepan    = "Keanu"       ;
string  pembeliNamaBelakang = "Reeves"      ;
int     jumlahUang          = 75000         ;

// Item
string  namaItem1           = "Buku"        ;
string  namaItem2           = "Pensil"      ;
string  namaItem3           = "Penghapus"   ;

// Harga
int     hargaBuku           = 12000         ;
int     hargaPensil         = 3000          ;
int     hargaPenghapus      = 5000          ;

// Operasi
int     pembelian           = 2 * hargaBuku + 3 * hargaPensil + hargaPenghapus;

// Struk
Console.WriteLine(" = Struk Belanja = ")                    ;
Console.WriteLine("-------------------")                    ;
Console.WriteLine($" 2 x {namaItem1} = {2 * hargaBuku}")    ;
Console.WriteLine($" 3 x {namaItem2} = {3 * hargaPensil}")  ;
Console.WriteLine($" 1 x {namaItem3} = {hargaPenghapus}")   ;
Console.WriteLine($" Total = {pembelian} -")                ;
Console.WriteLine("-------------------")                    ;
Console.WriteLine($" Bayar = {jumlahUang}")                 ;
Console.WriteLine($" Sisa  = {jumlahUang - pembelian}")     ;
Console.WriteLine("-------------------")                    ;
Console.WriteLine("Terima kasih telah belanja disini.\n")   ;

// Jalan Cerita
Console.WriteLine($"{pembeliNamaDepan} {pembeliNamaBelakang} ingin membeli "        +
                  $"peralatan tulis untuk sekolah barunya. \nDengan membawa uang "  +
                  $"sejumlah {jumlahUang}, {pembeliNamaDepan} memutuskan untuk\n"   +
                  $"membeli 2 {namaItem1}, 3 {namaItem2}, dan sebuah {namaItem3} "  +
                  $"dengan total harga\n{pembelian}. {pembeliNamaDepan} pun "       +
                  $"membayar dengan uangnya. Oleh karena itu, sisa\nuangnya saat "  + 
                  $"ini adalah {jumlahUang -= pembelian}.\n")                       ; // <-



/* ==================================================
 * Sedikit Tips untuk Programmer Profesional
 * ==================================================
 * Ada satu baris di dalam kode Anda yang ingin saya
 * bahas lebih dalam. Bukan karena salah—kode Anda
 * berjalan dengan sempurna—tetapi karena ini
 * menyentuh sebuah konsep yang penting untuk masa
 * depan.
 *
 * Console.WriteLine($"...sisa uangnya saat ini adalah {jumlahUang -= pembelian}.\n");
 *
 * Di sini, operasi jumlahUang -= pembelian melakukan
 * dua hal sekaligus:
 * 1. Menghitung nilai jumlahUang - pembelian.
 * 2. Mengubah nilai asli dari variabel jumlahUang.
 *
 * Ini disebut ekspresi dengan efek samping
 * (expression with side effects). Untuk program
 * kecil seperti ini, tidak ada masalah. Namun, dalam
 * program yang lebih besar dan kompleks, mengubah
 * nilai variabel di saat yang bersamaan dengan
 * menampilkannya terkadang bisa membuat kode sulit
 * dilacak dan menimbulkan bug yang tidak terduga.
 *
 * Praktik yang sering dianggap lebih "aman" adalah
 * memisahkan antara perhitungan dan pengubahan nilai.
 *
 * Pola yang Disarankan:
 * 1. Hitung dulu sisanya dan simpan di variabel baru.
 *    int sisaUang = jumlahUang - pembelian;
 * 2. Tampilkan variabel baru yang berisi hasil
 *    perhitungan.
 *    Console.WriteLine($"Oleh karena itu, sisa uangnya saat ini adalah {sisaUang}.\n");
 * 3. (Jika perlu) Baru perbarui nilai variabel asli
 *    setelahnya.
 *    jumlahUang = sisaUang; // atau jumlahUang -= pembelian;
 * ==================================================
*/