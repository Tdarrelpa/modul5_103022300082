using System;

namespace cobaProsesData 
{
    public class PemrosesData 
    {   
        public T DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic temp1 = data1;
            dynamic temp2 = data2;
            dynamic temp3 = data3;

            dynamic? Largest = temp1;
            if (Largest <= temp2)
            {
                Largest = temp2;
            }

            if (Largest <= temp3)
            {
                Largest = temp3;
            }
            return Largest;
        }
    }
}
