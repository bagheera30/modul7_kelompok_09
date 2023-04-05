using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_09
{
    internal class DataMahasiswa1302200003
    {
        public class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }

            public class address
            {
                public string streetAdress { get; set; }
                public string city { get; set; }
                public string state { get; set; }
            }

            public class course
            {
                public string code { get; set; }
                public string name { get; set; }
            }
        }

        public void ReadJSON()
        {
            string file = "jurnal7_1_1302200003.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);
            Console.WriteLine($"First Name {dataMahasiswa.firstName} Last Name {dataMahasiswa.lastName} Gender {dataMahasiswa.gender} ");
        }

    }
}
