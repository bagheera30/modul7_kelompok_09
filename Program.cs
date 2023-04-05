using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul7_kelompok_09;

class main
{
    public static void Main()
    {
        DataMahasiswa1302200003 mhs1 = new DataMahasiswa1302200003();
        mhs1.ReadJSON();
        Console.WriteLine();

        TeamMember1302200003 mhs2 = new TeamMember1302200003();
        mhs2.ReadJSON();
        Console.WriteLine();
    }

}
