using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104067
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Mahasiswa
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<Course> Courses { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_2311104067.json");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json, options);

        Console.WriteLine($"Name: {data.FirstName} {data.LastName}");
        Console.WriteLine($"Gender: {data.Gender}");
        Console.WriteLine($"Age: {data.Age}");

        if (data.Address != null)
        {
            Console.WriteLine($"Address: {data.Address.StreetAddress}, {data.Address.City}, {data.Address.State}");
        }
        else
        {
            Console.WriteLine("Address: (data tidak tersedia)");
        }

        Console.WriteLine("Course:");
        if (data.Courses != null)
        {
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"- {course.Code}: {course.Name}");
            }
        }
        else
        {
            Console.WriteLine("- Tidak ada data mata kuliah");
        }
    }
}
