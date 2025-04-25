using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104044
{
    public static void ReadJSON()
    {
        string fileName = "jurnal7_1_2311104044.json";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File tidak ditemukan.");
            return;
        }

        string jsonString = File.ReadAllText(fileName);
        var data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine("Data Mahasiswa:");
        Console.WriteLine($"Nama  : {data.Nama}");
        Console.WriteLine($"NIM   : {data.NIM}");
        Console.WriteLine($"Umur  : {data.Umur}");
        Console.WriteLine($"Kelas : {data.Kelas}");
        Console.WriteLine($"Asal  : {data.Asal}");
    }
}

public class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }
    public int Umur { get; set; }
    public string Kelas { get; set; }
    public string Asal { get; set; }
}
