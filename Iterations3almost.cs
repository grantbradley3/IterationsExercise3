using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Thousands();
            ByThrees();
            var isEqual = EqualCheck(1, 5);
            Console.WriteLine($"is equal: {isEqual}");
            EvenOrOdd(5);
            IsItPositive(5);
            CanVote(5);
            InRange(5);
            Multiple(5);
        }
        public static void Thousands()
        {
            for(int x = 1000; x>= -1000; x--)
            {
                Console.WriteLine(x);
            }
        }
        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool EqualCheck(int a,int b)
        {
            if (a == b)
            {
                return true;
               
            }
            else
            {
                return false;   
            }
        }
        public static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
               Console.WriteLine($"That is an even number");

            }
            else
            {
               Console.WriteLine($"That is an odd number");
            }
        }
        public static void IsItPositive(int number)
        {
            if(number>0)
            {
                Console.WriteLine($"This number is positive");
            }   
            else
            {
                Console.WriteLine($"This is not a positive number");
            }

        }
        public static bool CanVote(int age)
        
        {
            if (age >= 18)
            {
                Console.WriteLine($"This person is old enough to vote");
                return true;
            }
            else
            {
                Console.WriteLine($"You are too young try again in {18 - age} years");
                return false;
            }
        }
        public static bool InRange(int digit)
        {
            if(digit < 10 && digit > -10)
            {
                Console.WriteLine("You are in range");
                return true;    
            }
            else
            {
                Console.WriteLine("You are out of range");
                return false;
            }
        }
        public static void Multiple(int n)
        {
            for(int m = 1; m<=12; m++)
            {
                Console.WriteLine($"{n} times {m} equals {n * m}");
            }
        }
        
    }
}
//LukeWarm Section: Create methods below
//Write a method that will print to the console all numbers 1000 through - 1000

//Write a method that will print to the console numbers 3 through 999 by 3 each time

//Write a method to accept two integers as parameterss and check whether they are equal or not

//Write a method to check whether a given number is even or odd

//Write a method to check whether a given number is positive or negative

//Write a method to read the age of a candidate and determine whether they can vote.
//Hint: Use Parse or the safer TryParse() for an extra challenge
//Parse()
//TryParse()

//Heatin Up Section:
//Write a method to check if an integer(from the user) is in the range -10 to 10

//Write a method to display the multiplication table(from 1 to 12) of a given integer


//Call the methods to test them in the Main method below
