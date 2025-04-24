using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104074
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public void ReadJSON(string path)
    {
        try
        {
            string jsonString = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<DataMahasiswa2311104074>(jsonString);

            if (data != null)
            {
                Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
                Console.WriteLine($"Gender: {data.gender}");
                Console.WriteLine($"Age: {data.age}");
                Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.city}, {data.address.state}");
                Console.WriteLine("Mata Kuliah:");
                foreach (var course in data.courses)
                {
                    Console.WriteLine($"- {course.code}: {course.name}");
                }
            }
            else
            {
                Console.WriteLine("Data deserialized null");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error: {ex.Message}");
        }
    }
}

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}
