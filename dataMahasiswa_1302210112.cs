using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_09.dataMahasiswa_1302210112;



namespace modul7_kelompok_09
{
    internal class dataMahasiswa_1302210112
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; } 
        public addres address { get; set; }
        public List<Course> courses { get; set; }

        public class addres
        {
            public addres() { }
            public string streetAddress { get; set;}
            public string city { get; set;}
            public string state { get; set;}
        }
        public class Course {
            public Course() { }
            public string code { get; set;}
            public string name { get; set;}
        }
        public void readJson()
        {
            string js = File.ReadAllText("jurnal7_1_1302210112.json");
            dataMahasiswa_1302210112 data=JsonSerializer.Deserialize<dataMahasiswa_1302210112>(js);

            Console.WriteLine("first name : " + data.firstName + "\nlast name : "+data.lastName+"\ngender : "+data.gender+"\nage : "+data.age+ "\nstreetAddress : "+data.address.streetAddress+"\ncity : "+data.address.city+"\nstate : "+data.address.state);
            Console.WriteLine("Daftar Mata Kuliah yang diambil:");
            int i = 1;
            foreach (Course course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
