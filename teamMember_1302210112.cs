using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_09.dataMahasiswa_1302210112;

namespace modul7_kelompok_09
{
    internal class teamMember_1302210112
    {
       
        public class member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }
        public class memberslist
        {
            public List<member> members { get; set; }
        }
        public void readJson()
        {
            string jsonString = File.ReadAllText("jurnal7_1_1302210112.json");
            memberslist member1 = JsonSerializer.Deserialize<memberslist>(jsonString);

            Console.WriteLine("team member");
            int i = 1;
            foreach (member member in member1.members )
            {
                Console.WriteLine("first name : " + member.firstName + "\nlast name : " + member.lastName+"\ngender: "+member.gender+"\nage: "+member.age+"\nnim: "+member.nim);
                i++;
            }
        }
    }
}
