using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 01
            //
            //for (var i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercise 02
            //
            //var sum = 0;

            //while(true)
            //{
            //    Console.WriteLine("Enter a number or enter ok to exit.");
            //    var userInput = Console.ReadLine();

            //    if (userInput.ToLower() == "ok")
            //    {
            //        break;
            //    }

            //    else
            //    {
            //        sum += Convert.ToInt32(userInput);
            //    }
            //}
            //Console.WriteLine($"The sum of all your numbers is {sum}");

            //Exercise 03
            //
            //var factorial = 1;

            //Console.WriteLine("Enter a number and I will return the factorial.");
            //var userInput = Convert.ToInt32(Console.ReadLine());

            //for (var i = 1; i <= userInput; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine($"{userInput}! = {factorial}");

            //Exercise 04
            //
            //var secretNumber = new Random().Next(1, 10);
            //var attemptNumber = 4;
            //var guessesRemaining = attemptNumber;

            //Console.WriteLine($"Number to guess is {secretNumber}");

            //Console.WriteLine($"Guess a number between 1 and 10. You have {attemptNumber} attempts:");

            //for (var i = 0; i < attemptNumber; i++)
            //{
            //    var userGuess = Convert.ToInt32(Console.ReadLine());

            //    if(userGuess == secretNumber)
            //    {
            //        Console.WriteLine("You've guessed correctly!");
            //        return;
            //    }

            //    else
            //    {
            //        guessesRemaining--;
            //        Console.WriteLine($"Incorrect answer, you have {guessesRemaining} guesses remaining.");
            //    }
            //}
            //Console.WriteLine("Game Over, you loose.");

            //Exercise 05
            //

            Console.WriteLine("Enter a list of numbers separated by a comma (example: 1, 2, 3, 4) and will return the largest number.");
            var userInput = Console.ReadLine();

            var numbers = userInput.Split(",");

            var max = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The max number is {max}.");
            Console.WriteLine("---- Press any key to exit ----");
            Console.ReadKey();
        }
    }
}
