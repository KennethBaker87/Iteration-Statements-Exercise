using System.Net.Http.Headers;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Count() 
        {
            for (int a = 1000; a >= -1000; a--)
                
            {
                Console.WriteLine(a);
                
            }
            
            
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int b = 3; b < 999; b+=3)
            {
                Console.WriteLine(b);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Twos(int m, int n)
        {
            if (m == n)
            {
                Console.WriteLine($"Numbers {m} and {n} are equal");
            }            
            else
            {
                Console.WriteLine($"Numbers {m} and {n} are NOT equal");
            }
            
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine($"{num1} is positive");
            }

            else
            {
                Console.WriteLine($"{num1} is negative");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void AgeRes()
        {
            Console.WriteLine("What is your age?");
            var age = int.TryParse(Console.ReadLine(), out int age2);
            if (age2 >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You CANNOT vote :(");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("Pick a number");
            var rag = int.TryParse(Console.ReadLine(), out int rag2);
            if (rag2 < -10 || rag2 > 10)
            {
                Console.WriteLine("Number is not in range!");
                
            }
            else
            {
                Console.WriteLine("Your number is in range!!!!");
            }  
            
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {
            int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Console.WriteLine("Pick a number: ");
            var k = int.TryParse(Console.ReadLine(), out int k1);

            for (int i = 0; i < array.Length; i++)
                
            {
                int prod = array[i] * k1;
                Console.WriteLine($"{k1} x {array[i]} = {prod}");
            }

            foreach (int num5 in array)
            {
                int prod = num5 * k1;

            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Count();
            Threes();
            Twos(5, 5);
            EvenOrOdd(6);
            PosOrNeg(6);
            AgeRes();
            Range();
            MultTable();

        }
    }
}
