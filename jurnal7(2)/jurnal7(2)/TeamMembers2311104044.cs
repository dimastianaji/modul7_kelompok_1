using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

public class TeamMembers2311104044
{
    public static void ReadJSON()
    {
        string fileName = "jurnal7_2_2311104044.json";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File tidak ditemukan.");
            return;
        }

        string jsonString = File.ReadAllText(fileName);
        var wrapper = JsonSerializer.Deserialize<TeamWrapper>(jsonString);

        if (wrapper == null || wrapper.Members == null)
        {
            Console.WriteLine("Data kosong atau tidak bisa dideserialisasi.");
            return;
        }

        var data = wrapper.Members;

        Console.WriteLine("Team member list:");
        foreach (var member in data)
        {
            Console.WriteLine($"{member.NIM} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
        }
    }
}

public class TeamWrapper
{
    [JsonPropertyName("members")]
    public List<TeamMember> Members { get; set; }
}

public class TeamMember
{
    [JsonPropertyName("nim")]
    public string NIM { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }
}
