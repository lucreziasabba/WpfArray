using System;

namespace LibreriaArray
{
    public class ClasseArray
    {
        public static void RiempiArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
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
