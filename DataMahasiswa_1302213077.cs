using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_09
{
    internal class DataMahasiswa_1302213077
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public class address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

        }
        public class courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal7_1_1302213077.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa_1302213077 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213077>(dataStr);
            Console.WriteLine($"firstName : {dataMahasiswa.firstName} lastName : {dataMahasiswa.lastName} gender : {dataMahasiswa.gender} age : {dataMahasiswa.age}");
        }
    }
}
