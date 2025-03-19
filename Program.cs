// See https://aka.ms/new-console-template for more information
using cobaProsesData;

public class Program 
{
    public static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        float hasil = pemrosesData.DapatkanNilaiTerbesar<float>(10, 30, 82);
        Console.WriteLine($"Largest data is {hasil}");
    }
}
