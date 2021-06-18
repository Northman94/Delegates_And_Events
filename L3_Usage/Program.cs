using System;

namespace L3_Usage
{
    class MainClass
    {
        delegate bool Comparer(string a, string b);
        //  true if a > b;
        // false if b > a;

        public static void Main(string[] args)
        {
            string[] array1 = { "Teeest", "T", "Tst", "Test", "Te", "Teeerer"};

            Sort(array1, LengthComparer);


            foreach (var elmnt in array1)
            {
                Console.WriteLine(elmnt);
            }
        }


        static bool LengthComparer(string a, string b)
        {
            return a.Length > b.Length;
            //  true if a > b;
            // false if b > a;
        }


        //BubbleSort метод принимающий string Array и метод с Принципом его сортировки (bool)
        //Сравнение первой и последующих с первой.
        static void Sort(string[] array, Comparer bubble)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    foreach (var item in array)
                    {
                        Console.WriteLine(item);
                    }

                    if (bubble(array[i], array[j]))
                    {
                        string t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }

                    Console.WriteLine("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
