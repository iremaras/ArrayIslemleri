using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = { 32, 79, 68, 97, 60, 98, 3 };
            int max = int.MinValue;
            int min = int.MaxValue;
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] > max)
                {
                    max = theArray[i];
                }
                if (theArray[i] < min)
                {
                    min = theArray[i];
                }

                toplam += theArray[i];
            }

            ortalama = (double)toplam / theArray.Length;
            Console.WriteLine($"Array'de\nen büyük sayı: {max}\nen küçük sayı: {min}\nortalama: {ortalama} ");
            Console.ReadLine();
        }
    }
}
