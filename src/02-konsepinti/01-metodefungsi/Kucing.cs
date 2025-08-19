public class Kucing
{
    public string? Nama { get; set; }
    public string? Warna { get; set; }
    public double Umur { get; private set; }
    public double Energi { get; private set; }

    public Kucing(string? inputNama, string? inputWarna)
    {
        Nama = inputNama;
        Warna = inputWarna;
        Umur = 1;
        Energi = 50;

        // Easter Egg
        if (Warna is "Orange" or "Oyen" or  "Oranye")
        {
            Console.WriteLine($"Kucing {Warna}? Kucing ini terkenal " +
                              $"nakal lho.");
        }
    }

    public int Makan(int balance)
    {
        Console.WriteLine("\nMakan apa hari ini?");
        Console.WriteLine("1. Daging (-18 balance)");
        Console.WriteLine("2. Ikan (-12 balance)");
        Console.WriteLine("0. Kembali");
        Console.Write("> ");

        // Balance
        int biaya = 0;
        if (Energi > 90)
        {
            Console.WriteLine($"\n{Nama} tidak ingin makan. {Nama} sudah kenyang.\n");
            return biaya;
        }

        string? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                biaya = 18;
                if (balance >= biaya)
                {
                    Umur += 0.1;
                    Energi += 35;
                    Console.WriteLine($"\n{Nama} memakan daging dengan lahap.");
                    Console.WriteLine($"{Nama} merasa senang. :)\n");

                    if (Energi > 100)
                    {
                        Energi = 100;
                    }

                    return biaya;
                }

                Console.WriteLine("\nBalance kamu tidak cukup.\n");
                break;
            case "2":
                biaya = 12;
                if (balance >= biaya)
                {
                    Umur += 0.1;
                    Energi += 20;
                    Console.WriteLine($"\n{Nama} memakan ikan dengan lahap.");
                    Console.WriteLine($"{Nama} merasa senang. :)\n");

                    if (Energi > 100)
                    {
                        Energi = 100;
                    }

                    return biaya;
                }

                Console.WriteLine("\nBalance kamu tidak cukup.\n");
                break;
            case "0":
                break;
            default:
                Console.WriteLine("\nPilihan tidak ada.\n");
                break;
        }

        return biaya;
    }

    public void Bermain()
    {
        Console.WriteLine("\nMain apa hari ini?");
        Console.WriteLine("1. Kejar bola (-25 Energi)");
        Console.WriteLine("2. Gendong (-15 Energi)");
        Console.WriteLine("0. Kembali");
        Console.Write("> ");

        // Energi
        double biaya;
        string? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                biaya = 25;
                if (Energi >= biaya)
                {
                    Umur += 0.1;
                    Energi -= biaya;
                    Console.WriteLine($"\n{Nama} berlari-lari riang.\n");
                    break;
                }

                Console.WriteLine($"\n{Nama} tidak punya mood untuk bermain. :(\n");
                break;
            case "2":
                biaya = 15;
                if (Energi >= biaya)
                {
                    Umur += 0.1;
                    Energi -= biaya;
                    Console.WriteLine($"\n{Nama} merasa nyaman.\n");
                    break;
                }

                Console.WriteLine($"\n{Nama} tidak punya mood untuk bermain. :(\n");
                break;
            case "0":
                break;
            default:
                Console.WriteLine("\nPilihan tidak ada.\n");
                break;
        }
    }

    public int Tidur()
    {
        Umur += 0.2;
        Energi += 30;
        Console.WriteLine($"\n{Nama} sedang tertidur pulas.\n");
        if (Energi > 100) Energi = 100;

        // Balance
        return 30;
    }
}