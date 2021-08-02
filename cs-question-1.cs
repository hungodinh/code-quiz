/* What will the output of the following program be?
    1. 10 16
    2. 10 36
    3. Error
    4. 10 24
*/

using System;
namespace TestProgram
{
    class Program
    {
        static void fun1(ref int k)
        {
            k = k + k;
        }

        static void fun2(out int z)
        {
            z = 6;
            z = z * z;
        }
        
        public static void Main(string[] args)
        {
            int i = 5;
            int j = 4;
            fun1(ref i);
            fun2(out j);
            Console.WriteLine(i + " " +j);
            Console.ReadLine();
        }
    }
}
