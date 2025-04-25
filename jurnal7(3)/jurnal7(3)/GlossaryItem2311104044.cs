using System;
using System.IO;
using System.Text.Json;

public class GlossaryItem2311104044
{
    public static void ReadJSON()
    {
        string fileName = "jurnal7_3_2311104044.json";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File tidak ditemukan.");
            return;
        }

        string jsonString = File.ReadAllText(fileName);
        var wrapper = JsonSerializer.Deserialize<GlossaryWrapper>(jsonString);

        if (wrapper == null || wrapper.glossary == null ||
            wrapper.glossary.GlossDiv == null ||
            wrapper.glossary.GlossDiv.GlossList == null ||
            wrapper.glossary.GlossDiv.GlossList.GlossEntry == null)
        {
            Console.WriteLine("Data glossary tidak lengkap.");
            return;
        }

        var entry = wrapper.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("Glossary Entry:");
        Console.WriteLine($"ID         : {entry.ID}");
        Console.WriteLine($"SortAs     : {entry.SortAs}");
        Console.WriteLine($"GlossTerm  : {entry.GlossTerm}");
        Console.WriteLine($"Acronym    : {entry.Acronym}");
        Console.WriteLine($"Abbrev     : {entry.Abbrev}");
        Console.WriteLine($"Title      : {entry.Title}");
        Console.WriteLine($"GlossSee   : {entry.GlossSee}");
    }
}

// Wrapper untuk bagian "glossary"
public class GlossaryWrapper
{
    public Glossary glossary { get; set; }
}

// Kelas-kelas turunan
public class Glossary
{
    public GlossDiv GlossDiv { get; set; }
}

public class GlossDiv
{
    public GlossList GlossList { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public string Title { get; set; }
    public string GlossSee { get; set; }
}
