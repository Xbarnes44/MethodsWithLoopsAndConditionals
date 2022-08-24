using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoops
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = -1000;
            while(num<= 1000)
            {
                
                 Console.WriteLine($"{num}");
                 num++;
            }

            
            for (int num2 = 3; num2 <= 999; num2+= 3)
            {

                Console.WriteLine($"{num2}");
                

            }

            Console.WriteLine("Write a number");
            int randomNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Write another number");
            int randomNum2 = int.Parse(Console.ReadLine());

            if(randomNum1 != randomNum2)
            {
                Console.WriteLine("These numbers are not the same");
            }
            else
            {
                Console.WriteLine("Congrats these numbers are the same!");
            }

            Console.WriteLine("Write a number");
            int even = int.Parse(Console.ReadLine());
            if (even % 2 ==  0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            Console.WriteLine("Write a number");
            int positive = int.Parse(Console.ReadLine());

            if(positive >= 0)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
            Console.WriteLine("To complete regristation for the MA voting process please input your age");
           int votingAge =  int.Parse(Console.ReadLine());  

            if(votingAge >= 18)
            {
                Console.WriteLine("You approved for voting");
            }
            else
            {
                Console.WriteLine("You are too young to continue the voting process");
            }

            Console.WriteLine("Write a number");
            int range = int.Parse(Console.ReadLine());

            if (range > -10 && range< 10)
            {
                Console.WriteLine("Your number is in range");
            }
            else
            {
                Console.WriteLine("Your number is out of range");
            }

            int mul1 = 12;
            Console.WriteLine("Any number you input will give you that number multiplied by 12");
            int mul2 = int.Parse(Console.ReadLine());

            var product = Multiply(mul1, mul2);
            Console.WriteLine($"{product}");


        }

        public static int Multiply(int mul1, int mul2)
        {
            return mul1 * mul2;
        }
    }
}
    
    
    
    
    
    