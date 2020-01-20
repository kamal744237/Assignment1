using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#A
            // this is an edit on github
            Console.WriteLine("hello");
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            //#B
            Console.WriteLine("enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int multiply = num1 * num2;
            int division = num1 / num2;
            Console.WriteLine("the sum is " + sum);
            Console.WriteLine("multiplication of two numbers is " + multiply);
            Console.WriteLine("division of two numbers is " + division);

            //#C
            int a = 4;
            int b = 5;
            Console.WriteLine("the first number is " + a);
            Console.WriteLine("the second number is " + b);
            int c = 4;
            a = b;
            b = c;
            Console.WriteLine("after swapping the first number is " + a);
            Console.WriteLine("after swapping the second number is " + b);

            //#D
            Console.WriteLine("enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int multiplication = n1 * n2 * n3;
            Console.WriteLine("the multiplication of three numbers is " + multiplication);

            //#E
            Console.WriteLine("enter a number:");
            int numE = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = numE * i;
                Console.WriteLine(result);
            }


            //#F
            Console.WriteLine("enter first number:");
            int n1f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int n2f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number:");
            int n3f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter fourth number:");
            int n4f = Convert.ToInt32(Console.ReadLine());

            int average = (n1f * n2f * n3f * n4f) / 2;
            Console.WriteLine("average of four numbers" + average);

            //#G

            Console.WriteLine("what is your age:");
            int n1g = Convert.ToInt32(Console.ReadLine());
            if (n1g < 20)
            {
                Console.WriteLine(name + "you are teenager");
            }
            else
            {
                Console.WriteLine(name + "you look mature");
            }

            //#H
            Console.WriteLine("enter first number:");
            int n1h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int n2h = Convert.ToInt32(Console.ReadLine());

            int sumh = n1h + n2h;

            if (n1h == n2h)
            {
                int sumhh = 3 * sumh;
            }
            else
            {
                Console.WriteLine(sumh);
            }

            //#I
            Console.WriteLine("enter a number");
            int ni = Convert.ToInt32(Console.ReadLine());
            if (ni > 20 && ni < 100)
            {
                Console.WriteLine("this is a integer between 20 and 100");
            }
            else
            {
                Console.WriteLine("not a integer");
            }

            //#J
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                s = s + i;

                Console.WriteLine(i);
            }
            Console.WriteLine("sum is" + s);


            //#K
            int ik = 1;
            int sk = 0;
            while (ik <= 10)
            {
                sk += ik;
                ik++;
            }
            Console.WriteLine("the sum is" + sk);



            //#L
            Console.WriteLine("enter first number:");
            int n1l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int n2l = Convert.ToInt32(Console.ReadLine());

            if (n1h == n2h)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("numbers are not equal");
            }

            //#M
            Console.WriteLine("enter first number:");
            int k1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int k2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number:");
            int k3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(k1, k2), k3));

            //#b1
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            long ssum = 0;
            int number = 0;
            int n = 2;
            while (number < 500)
            {
                if (isPrime(n))
                {
                    ssum += n;
                    number++;
                }
                n++;
            }

            Console.WriteLine(ssum.ToString());




            //#b2

            string firstname = "kamaljeet";
            firstname = firstname.Substring(0, firstname.Length - 2) + "__";
            Console.WriteLine(firstname);

            //#b3

            string a = "kamaljeet";
            string newa = abc.Substring(5, 2);
            Console.WriteLine(newa);

            //#b4
            Console.WriteLine("enter numbers:");
            int naturalnumber = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            for (j = 1; j <= naturalnumber; j++)
            {
                Console.WriteLine(j);
            }

            //b#5
            Console.WriteLine("enter something");
            string b5string = Console.ReadLine();
            int countSpace = b5string.Count(Char.IsWhiteSpace);
            Console.WriteLine("Number of spaces in string are = " + countSpace);


            Console.ReadLine();
        }




        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
