using System;

namespace AssignmentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = 10;
            num2 = ++num1;
            Console.WriteLine("Assigning num2 by pre-increment");
            Console.WriteLine("num1: {0} \n num2: {1}", num1,num2);

            num2 = num1++;
            Console.WriteLine("Assigning num2 by pre-increment");
            Console.WriteLine("num1: {0} \n num2: {1}", num1, num2);

        }
    }
}
