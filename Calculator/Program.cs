using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number :");

            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number :");

            var num2 = Convert.ToInt32(Console.ReadLine());

            

            int Sum = add(num1, num2);
            int Sub = sub(num1, num2);
            int Mult = mult(num1, num2);
            Console.WriteLine("the sum of 1st number and 2nd number is : " + Sum+"\n");
            Console.WriteLine("the sub of 1st number and 2nd number is : " + Sub + "\n");
            Console.WriteLine("the mult of 1st number and 2nd number is : " + Mult + "\n");
            Console.ReadKey();

        }
         static int add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int sub(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        static int mult(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }



    }
}
