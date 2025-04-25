using System;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\fahmi\modul7_kelompok_1\TP_modul_7_2311104074\TP_modul_7_2311104074\jurnal7_1_2311104074.json";
        var data = new DataMahasiswa2311104074();
        data.ReadJSON(path);
    }
}
