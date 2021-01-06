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
            int max = 0;
            int min = 100;
            int toplam = 0;
            int ortalama = 0;
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

            ortalama = toplam / theArray.Length;
        }
    }
}
