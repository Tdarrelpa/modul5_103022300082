// See https://aka.ms/new-console-template for more information
using cobaProsesData;
using cobaBasisData;

public class Program 
{
    public static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        float hasil = pemrosesData.DapatkanNilaiTerbesar<float>(10, 30, 82);
        Console.WriteLine($"Largest data is {hasil}");

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddData(12);
        db.AddData(34);
        db.AddData(56);
        db.ShowData();
    }
}
