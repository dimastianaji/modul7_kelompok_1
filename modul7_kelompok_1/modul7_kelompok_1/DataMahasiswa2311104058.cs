using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_kelompok_1
{
    public class DataMahasiswa2311104058
    {
        public class Address
        {
            [JsonPropertyName("streetAddress")]
            public string StreetAddress { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }
        }

        public class Course
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("gender")]
            public string Gender { get; set; }

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("address")]
            public Address Address { get; set; }

            [JsonPropertyName("courses")]
            public List<Course> Courses { get; set; }
        }


        public void ReadJSON()
        {
            string filePath = @"D:\College\Semester 4\PrakKPL\07_Grammar-Based_Input_Processing_Parsing\JURNAL\modul7_kelompok_1\modul7_kelompok_1\jurnal7_1_2311104058.json";

            string jsonString = File.ReadAllText(filePath);
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama      : {mhs.FirstName} {mhs.LastName}");
            Console.WriteLine($"Gender    : {mhs.Gender}");
            Console.WriteLine($"Usia      : {mhs.Age}");

            if (mhs.Address != null)
            {
                Console.WriteLine($"Alamat    : {mhs.Address.StreetAddress}, {mhs.Address.City}, {mhs.Address.State}");
            }
            else
            {
                Console.WriteLine("Alamat    : (data tidak tersedia)");
            }

            Console.WriteLine("Mata Kuliah:");
            if (mhs.Courses != null)
            {
                foreach (var course in mhs.Courses)
                {
                    Console.WriteLine($"- {course.Code}: {course.Name}");
                }
            }
        }

    }
}
