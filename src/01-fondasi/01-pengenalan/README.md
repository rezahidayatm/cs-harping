## 1.1. Pengenalan & Penyiapan Lingkungan

### ### Kategori 1: Perangkat Lunak Inti (Core Software)

Ini adalah fondasi teknis yang wajib ada di mesin pengembangan Anda.

1.  **.NET SDK (Software Development Kit)**
    * **Apa ini?** Ini adalah paket utama dari Microsoft yang berisi semua yang Anda butuhkan untuk membangun dan menjalankan aplikasi .NET. Isinya antara lain *compiler* (yang mengubah kode C# Anda menjadi program), *runtime* (yang menjalankan program Anda), dan pustaka standar (*standard libraries*).
    * **Persiapan:** Pastikan Anda telah menginstal versi .NET SDK terbaru (atau versi LTS - *Long-Term Support* jika Anda menginginkan stabilitas jangka panjang). Anda bisa mengunduhnya dari [situs resmi .NET](https://dotnet.microsoft.com/download). Karena Anda sudah belajar C#, kemungkinan besar ini sudah terpasang. Anda bisa memeriksanya dengan membuka terminal dan mengetik `dotnet --version`.

2.  **IDE (Integrated Development Environment)**
    * **Apa ini?** Ini adalah "bengkel kerja" utama Anda. Sebuah editor teks super canggih yang dirancang khusus untuk menulis, mengelola, menjalankan, dan melakukan *debugging* kode.
    * **Persiapan:** Anda sudah berada di jalur yang tepat dengan menggunakan **JetBrains Rider**. Ini adalah IDE kelas atas yang sangat kuat. Pastikan Rider Anda adalah versi terbaru untuk mendapatkan fitur dan perbaikan bug terkini.
    * **Alternatif Lain (untuk diketahui):**
        * **Visual Studio 2022 Community Edition:** Ini adalah "saudara kandung" Rider dari Microsoft. Gratis, sangat powerful, dan merupakan standar industri untuk pengembangan .NET di Windows.
        * **Visual Studio Code (VS Code):** Editor kode yang lebih ringan dan fleksibel. Dengan ekstensi C# Dev Kit dari Microsoft, ia menjadi sangat mumpuni, meskipun pengalamannya tidak se-"terintegrasi" Rider atau Visual Studio penuh bagi pemula.

3.  **Terminal atau Command Line**
    * **Apa ini?** Antarmuka berbasis teks untuk berinteraksi dengan komputer Anda. Sangat penting untuk menjalankan perintah `dotnet`, Git, dan alat bantu lainnya.
    * **Persiapan:**
        * Jika Anda di Windows, **Windows Terminal** adalah pilihan modern yang sangat baik (bisa diunduh dari Microsoft Store).
        * JetBrains Rider sudah memiliki jendela **Terminal** bawaan yang sangat bagus. Anda bisa menggunakannya untuk semua kebutuhan Anda tanpa harus meninggalkan IDE.

---

### ### Kategori 2: Manajemen Kode & Kolaborasi

Meskipun Anda bekerja sendirian, membiasakan diri dengan ini adalah praktik profesional yang krusial.

1.  **Git (Version Control System)**
    * **Apa ini?** Anggap saja ini seperti "mesin waktu" untuk kode Anda. Git melacak setiap perubahan yang Anda buat, memungkinkan Anda untuk kembali ke versi sebelumnya jika terjadi kesalahan, dan merupakan dasar untuk berkolaborasi dengan orang lain.
    * **Persiapan:** Unduh dan instal Git dari [situs resminya](https://git-scm.com/downloads). Setelah terinstal, Anda bisa menggunakannya dari terminal, dan yang lebih penting, Rider memiliki integrasi Git yang fantastis.

2.  **Akun di Platform Hosting Git (GitHub, GitLab, dll.)**
    * **Apa ini?** Layanan online untuk menyimpan repositori Git Anda. Ini berfungsi sebagai *backup* online dan tempat untuk memamerkan portofolio Anda.
    * **Persiapan:** Buat akun gratis di **GitHub**. Ini adalah platform paling populer untuk proyek *open-source* dan portofolio pribadi. Hubungkan akun GitHub Anda dengan Git di komputer lokal Anda.

---

### ### Kategori 3: Perencanaan & Konsep Proyek

Ini bukan tentang perangkat lunak, tetapi tentang pola pikir. Jangan pernah langsung melompat ke kode tanpa ini.

1.  **Definisi dan Ruang Lingkup Proyek**
    * **Apa ini?** Menjawab pertanyaan-pertanyaan dasar sebelum Anda menulis satu baris kode pun.
    * **Persiapan:** Ambil buku catatan, atau buka aplikasi catatan (seperti Notion, Obsidian, atau bahkan Notepad). Tulis jawaban untuk pertanyaan ini:
        * Apa tujuan utama dari proyek ini? (Contoh: "Membuat aplikasi konsol untuk mengelola daftar tugas sederhana.")
        * Siapa penggunanya? (Jawabannya bisa "hanya saya sendiri".)
        * Fitur-fitur minimal apa saja yang harus ada untuk versi pertama? (Contoh: "Tambah tugas, lihat semua tugas, tandai tugas selesai, hapus tugas.")
        * Teknologi apa yang akan digunakan? (Contoh: "Aplikasi Konsol .NET, C#.")

2.  **Struktur Proyek**
    * **Apa ini?** Merencanakan bagaimana Anda akan mengatur file dan folder.
    * **Persiapan:** Pikirkan tentang struktur yang sudah kita diskusikan sebelumnya. Buat rencana:
        * Nama *solution* (`.sln`): `TodoApp.sln`
        * Nama proyek (`.csproj`): `TodoApp.Console/TodoApp.Console.csproj`
        * Apakah akan ada proyek lain? (Mungkin nanti ada `TodoApp.Logic` untuk logika bisnisnya).

---

### ### Rangkuman Persiapan Anda

Secara ringkas, daftar periksa Anda adalah:

**Perangkat Lunak:**
-   [✅] .NET SDK (Versi terbaru)
-   [✅] JetBrains Rider (Versi terbaru)
-   [✅] Git

**Akun Online:**
-   [✅] Akun GitHub

**Perencanaan:**
-   [✅] Ide jelas tentang apa yang akan dibuat (tujuan & fitur).
-   [✅] Rencana awal untuk struktur folder dan proyek.

Anda sudah memiliki IDE yang tepat. Langkah selanjutnya adalah memastikan .NET SDK dan Git terinstal, membuat repositori baru di GitHub, lalu mulai merencanakan fitur-fitur dasar dari proyek Anda.

Selamat merencanakan! Proses persiapan ini adalah bagian yang sangat penting dan menyenangkan dari perjalanan membangun sesuatu yang baru.
