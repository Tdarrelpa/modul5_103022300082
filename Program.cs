// See https://aka.ms/new-console-template for more information\
using cobaBasisData;

public class Program 
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddData(12);
        db.AddData(34);
        db.AddData(56);
        db.ShowData();
    }
}
