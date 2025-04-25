using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104044
{
    public string nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_2311104044.json");
        DataMahasiswa2311104044 data = JsonSerializer.Deserialize<DataMahasiswa2311104044>(jsonString);
        Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}
