using System;

namespace Lesson1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; //unassigned

            number = 10;

            Console.WriteLine(number);


            number = 11;

            Console.WriteLine(number);


            number = 456;

            Console.WriteLine(number);


            //var result = true;

            //var result = number % 2==0;

            bool result;
            if (number % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }


            Console.WriteLine(result);

            int student_count; // snake case
            int StudentCount; // pascal case
            int studentCount; // camel case
            // student-count // kabab case

            int avgPointOfStudents = 14;

            //======================================================================
            Console.WriteLine("==========================================================");

            int num;
            num = 45 + 10;
            num = 45 - 10;
            num = 45 * 10;
            num = 45 / 10;
            num = 45 % 10;

            num = 100;

            int sum = ++num + 10 + num;

            Console.WriteLine(sum);

            num = 10;

            num += 20; // num=num+20
            num -= 20; // num = num-20;
            num *= 20; // num = num*20;
            num /= 20; // num = num/20;
            num %= 20; // num = num%20;

            num = 10;

            var check = num != 10;//false
            check = num == 10; //true;
            check = num >= 10;//true; 
            check = num <= 10; //true;
            check = num == 10; //true;

            var newCheck = !(num>20); //true

            num = 9;

            check = num > 10 && num<15;
            check = num < 10 || num > 15;

            num = 8;
            check = (num > 10 && num % 3 == 0) || (num < 10 && num % 2 == 0);

        }
    }
}
