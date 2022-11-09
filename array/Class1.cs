using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Array
    {
        public int[] Dinc(int[] arra)
        {
            Random random = new Random();
            for (int i = 0; i < arra.Length; i++)
            {
                arra[i] = random.Next(-10, 10);
            }
            foreach (var item in arra)
            {
                Console.WriteLine(item+"\t");
            }
            return arra;
        }
        public string Finc(int[] arra)
        {
            int first = arra[0];
            for (int i = 0; i < arra.Length; i++)
            {
                if (first > arra[i])
                {
                    first = arra[i];

                }
            }
            return $"мин.элемент: {first}";
        }
        public int Ginc(int[] arra)
        {
            int maxIndex = 0;
            int first = arra[0];
            for (int i = 0; i < arra.Length; i++)
            {
                if (first < arra[i])
                {
                    first = arra[i];
                    maxIndex = i;

                }
            }
            return maxIndex;
        }
        public bool Sinc(int[] arra)
        {
            Console.WriteLine("Введите любое число: ");
            int first = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arra.Length; i++)
            {
                if (first == arra[i])
                {
                    return true;
                }

                else
                {
                    return false; 
                }
            }
            return false;
        }
        public int Rinc(int[] arra)
        {
            int sum = arra.Sum();
            return sum;
        }
    }
}