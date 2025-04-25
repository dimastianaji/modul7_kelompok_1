using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Matkul
{
    public string kode { get; set; }
    public string nama { get; set; }
}

public class KuliahMahasiswa2311104044
{
    public List<Matkul> mataKuliah { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_2311104044.json");
        KuliahMahasiswa2311104044 data = JsonSerializer.Deserialize<KuliahMahasiswa2311104044>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in data.mataKuliah)
        {
            Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
            i++;
        }
    }
}
