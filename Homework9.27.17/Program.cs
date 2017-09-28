using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9._27._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check whether a letter is a vowel or a consonant
            //Console.WriteLine("Enter a letter.");
            //char yourLetter = char.Parse(Console.ReadLine());

            //switch (yourLetter)
            //{
            //    case 'a':
            //        Console.WriteLine("This is a vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'i':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'o':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'u':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //}


            //else{
            //    Console.WriteLine("This is a consonant.");
            //}




            Console.WriteLine("Enter a whole number.");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number.");
            int secondValue = int.Parse(Console.ReadLine());

            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue + " is larger the larger value.");
            }
            else if (secondValue > firstValue)
            {
                Console.WriteLine(secondValue + " is the larger value.");
            }

            else
            {
                Console.WriteLine("Both values are equal.");
            }
        

        }
    }
}
