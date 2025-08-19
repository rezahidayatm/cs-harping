namespace MetodeFungsi;

public class Event
{
    private static bool _trigger1;
    private static bool _trigger2;
    private static bool _trigger3;

    public static void UlangTahun(string? nama, double umur)
    {
        // Cek umur
        if (umur >= 2 && umur < 3 && !_trigger1)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine($"{nama} Sekarang berumur 2 tahun. " +
                              $"Selamat ulang tahun {nama}");
            Console.WriteLine("=================================\n");
            _trigger1 = true;
        }
        else if (umur >= 3.0 && umur < 4.0 && !_trigger2)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine($"{nama} Sekarang berumur 3 tahun. " +
                              $"Selamat ulang tahun {nama}");
            Console.WriteLine("=================================\n");
            _trigger2 = true;
        }
        else if (umur >= 4.0 && umur < 5.0 && !_trigger3)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine($"{nama} Sekarang berumur 4 tahun. " +
                              $"Selamat ulang tahun {nama}");
            Console.WriteLine("=================================\n");
            _trigger3 = true;
        }
    }
}