using System;
using System.Reflection.Metadata.Ecma335;

namespace Lesson1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = 4; // int
            //var number = 4.5; //double

            byte number1 = 10; //0 to 255
            sbyte number2 = -128; //-128 to 127

            short number3 = 3245; // -32,768 to 32,767
            ushort number4 = 3456; // 0 to  65,535

            int number5 = 235443556;//-2,147,483,648 to 2,147,483,647
            uint number6 = 3454; //0 to 4,294,967,295

            long number7 = 34453545534353; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong number8 = 3455465465654; //0 to 18,446,744,073,709,551,615

            float number9 = 45.6f;
            double number10 = 45.6;
            decimal number11 = 45.6m;

            string word = "Salam 302";
            char letter = 'L';

            bool check = false;

            Console.WriteLine(check);
            check = 10 > 5;

            Console.WriteLine(check);
        }
    }
}
