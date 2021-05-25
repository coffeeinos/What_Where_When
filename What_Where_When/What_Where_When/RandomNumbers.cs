using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Where_When
{
    class RandomNumbers
    {
        public static void RandomFilling(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool repeat = true;
                while (repeat)
                {
                    int counter = 0;
                    int number = 0;
                    number = random.Next(arr.Length);
                    foreach (var item in arr)
                    {
                        if (number != item)
                        {
                            counter++;
                        }
                    }
                    if (counter == arr.Length)
                    {
                        arr[i] = number;
                        repeat = false;
                    }
                }
            }
        }
    }
}
