using System;

namespace Application
{
    class MainClass
    {
       public static void Main(string[] args)
        {
           
        }

        static bool Dividible (int [] arr)
        {
            bool flag = false;
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                if (sum % 2 == 0)
                    flag = true;
                else
                    flag = false;
            }
            return flag;
        }
        /*static void Pyramids(int hundurluk)
       {
           for (int i = 1; i <= hundurluk; i++)
           {
               for (int j = 1; j <= i ; j++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }

       }
       */

    }
}
