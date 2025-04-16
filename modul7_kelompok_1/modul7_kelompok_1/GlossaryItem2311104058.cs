using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    public class GlossaryItem2311104058
    {
        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
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
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class Root
        {
            public Glossary glossary { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = @"D:\College\Semester 4\PrakKPL\07_Grammar-Based_Input_Processing_Parsing\JURNAL\modul7_kelompok_1\modul7_kelompok_1\jurnal7_3_2311104058.json";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File tidak ditemukan.");
                return;
            }

            string jsonContent = File.ReadAllText(filePath);
            Root data = JsonConvert.DeserializeObject<Root>(jsonContent);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("GlossEntry Details:");
            Console.WriteLine($"ID         : {entry.ID}");
            Console.WriteLine($"GlossTerm  : {entry.GlossTerm}");
            Console.WriteLine($"Acronym    : {entry.Acronym}");
            Console.WriteLine($"Abbrev     : {entry.Abbrev}");
            Console.WriteLine($"GlossDef   : {entry.GlossDef.para}");
            Console.WriteLine($"GlossSee   : {entry.GlossSee}");
            Console.WriteLine("GlossSeeAlso:");
            foreach (var item in entry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
