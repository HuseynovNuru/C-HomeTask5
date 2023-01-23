using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace CHomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededi 10 vahid artirma
            int num = 44;
            Addten(ref num);
            Console.WriteLine(num);


            //0-100 arasi reqem
            int number = 63;
            Reqem(ref number);
            Console.WriteLine(number);


            //Verilmis siyahida cut ededleri tapan metod
            int[]nums = { 4, 3, 2, 5, 6, 8, 9 };

            Cutededler(ref nums);
            Console.WriteLine(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }
        //Verilmis ededi 10 vahid artirma
        static void Addten(ref int num)
        {
            num += 10;
        }
       
        
        //0-100 arasi reqem
        static void Reqem(ref int number)
        {
            if(number < 0)
            {
                number = 0;
            }
            else if(number > 100)
            {
                number = 100;
            }
        }


        //Verilmis siyahida cut ededleri tapan metod
        static void Cutededler(ref int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    count++;
            }
            int[] arrNew = new int[count];

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    arrNew[j] = nums[i];
                    j++;
                }
            }
            nums = arrNew;
        }
    } 
    
}
