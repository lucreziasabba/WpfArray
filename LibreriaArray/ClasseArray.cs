using System;

namespace LibreriaArray
{
    public class ClasseArray
    {
        public static void RiempiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                int x = rnd.Next();
                array[i] = x;
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
