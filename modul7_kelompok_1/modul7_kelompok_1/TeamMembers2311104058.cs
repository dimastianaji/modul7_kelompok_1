using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace modul7_kelompok_1
{
    public class TeamMembers2311104058
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class MemberList
        {
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_2311104058.json";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File tidak ditemukan.");
                return;
            }

            string jsonContent = File.ReadAllText(filePath);
            MemberList team = JsonConvert.DeserializeObject<MemberList>(jsonContent);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
