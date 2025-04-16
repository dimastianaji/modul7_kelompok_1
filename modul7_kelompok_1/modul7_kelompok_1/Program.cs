using modul7_kelompok_1;

class Program
{
    static void Main(string[] args)
    {
        var data = new DataMahasiswa2311104058();
        data.ReadJSON();

        Console.WriteLine(); 

        TeamMembers2311104058.ReadJSON();

        Console.WriteLine();

        GlossaryItem2311104058.ReadJSON();
    }
}
