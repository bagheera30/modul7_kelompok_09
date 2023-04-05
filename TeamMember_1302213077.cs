using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_09
{
    class TeamMember_1302213077
    {
        public TeamMember[] members { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal7_2_1302213077.json";

            string jsonString = File.ReadAllText(fileName);
            TeamMember_1302213077 jsonData = JsonSerializer.Deserialize<TeamMember_1302213077>(jsonString);

            this.members = jsonData.members;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Team member list:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " (" + this.age + " " + this.gender + ")");
        }
    }
}
