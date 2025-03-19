using System;

namespace cobaBasisData
{
    public class SimpleDataBase<T> 
    {
        private List<T> Storeddata;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            Storeddata = new List<T>();
            inputDate = new List<DateTime>();
        }

        public void AddData(T data)
        {
            this.Storeddata.Add(data);
            this.inputDate.Add(DateTime.Now);
        }

        public void ShowData()
        {
            for (int i = 0; i < Storeddata.Count; i++)
            {
                Console.WriteLine("Data " + i+1 + "berisi: " + Storeddata[i] + ", yang disimpan pada waktu UTC: " + inputDate[i]);
            }
        }
    }
}
