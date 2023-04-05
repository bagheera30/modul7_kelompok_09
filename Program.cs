// See https://aka.ms/new-console-template for more information
using modul7_kelompok_09;

class main
{
    public static void Main()
    {
        DataMahasiswa_1302213077 Mhs = new DataMahasiswa_1302213077();
        Mhs.ReadJSON();

        TeamMember_1302213077 Member = new TeamMember_1302213077();
        Member.ReadJSON();
    }
}