using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul7_kelompok_09
{
    class GlossaryItem1302200003
    {
        public GlossaryClass glossary { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal7_3_1302200003.json";

            string jsonString = File.ReadAllText(fileName);
            GlossaryItem1302200003 jsonData = JsonSerializer.Deserialize<GlossaryItem1302200003>(jsonString);

            this.glossary = jsonData.glossary;

            Console.WriteLine("Memulai mengeluarkan data Gloss Entry");
            jsonData.glossary.GlossDiv.GlossList.GlossEntry.info();
        }
    }

    class GlossaryClass
    {
        public string title { get; set; }
        public GlossDivClass GlossDiv { get; set; }
    }

    class GlossDivClass
    {
        public string title { set; get; }
        public GlossListClass GlossList { get; set; }
    }
    class GlossListClass
    {
        public GlossEntryClass GlossEntry { get; set; }
    }

    class GlossEntryClass
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDefClass GlossDef { get; set; }
        public string GlossSee { get; set; }
        public void info()
        {
            Console.WriteLine(ID);
            Console.WriteLine(SortAs);
            Console.WriteLine(GlossTerm);
            Console.WriteLine(Acronym);
            Console.WriteLine(Abbrev);
            Console.WriteLine(GlossDef.para);
            foreach (var item in GlossDef.GlossSeeAlso)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GlossSee);

        }
    }

    class GlossDefClass
    {
        public string para { set; get; }
        public string[] GlossSeeAlso { get; set; }
    }
}