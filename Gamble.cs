using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Gamble
    {
        static public int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19,
                                20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };
        public static string[] colors = { "red", "black" };
        public static int money = 500;
        public static string[] EvenOdd = { "even", "odd" };
        public static string[] columns = { "first", "second", "third" };
        public static Random ran = new Random();

        public void GambleMethod()

        {

            Console.WriteLine("Where would you like to place your money?");
            Console.WriteLine("money: " + money);
            Console.WriteLine("a. Numbers");
            Console.WriteLine("b. evens or odds");
            Console.WriteLine("c. reds or blacks");
            Console.WriteLine("d. Lows/Highs");
            Console.WriteLine("e. dozens ");
            Console.WriteLine("f. columns");
            Console.WriteLine("g. Street");
            Console.WriteLine("h. 6numbers ");
            Console.WriteLine("i. split ");
            Console.WriteLine("j. Corner ");
            Console.Write("");
            Console.ReadLine();
            //allows user to enter amount per gamble
            Console.WriteLine();

            Console.Write("you choose option: ");


            string choice = Console.ReadLine();

            if (choice == "a.")
            {
                Console.WriteLine("You choose Numbers:  which is amount gambled * 38");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You have " + money + " how much money would you like to gamble ? : ");
                Console.ReadKey();
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }

                money = money - input;
                Console.ReadKey();
                Console.Write("Choose any number between 0 and 36, also 00 is an option : ");
                int option = Convert.ToInt32(Console.ReadLine());

                int option2 = numbers[ran.Next(numbers.Length)];


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You landed on " + option2 + " " + colors[ran.Next(colors.Length)]);
                Console.ReadKey();
                if (option2 == option)
                {
                    input = input * 38;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    money = money - input;
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            else if (choice == "b.")
            {
                Console.WriteLine("You have chosen Evens/Odds: payout will be amount gambled * 2");
                Console.Clear();
                Console.ReadKey();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                Console.ReadKey();
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount:");
                    Console.ReadKey();
                    Console.Clear();
                }
                money = money - input;
                Console.Write("Please choose even or odd: ");
                Random ran = new Random();

                string option = Console.ReadLine();

                string option1 = EvenOdd[ran.Next(EvenOdd.Length)];

                Console.WriteLine("the ball fell on " + option1);
                Console.ReadKey();
                Console.Clear();
                if (option1 == option)
                {
                    input = input * 2;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "c.")
            {
                Console.WriteLine(" You choose  Reds/Blacks:  payout will be amount gambled * 2");
                Console.ReadKey():
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                Console.ReadKey();
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.ReadKey();
                    Console.Clear();
                }
                money = money - input;
                Console.Write("choose Red or Black: ");
                string option = Console.ReadLine();


                string option1 = colors[ran.Next(colors.Length)];

                Console.WriteLine("your ball fell on " + numbers[ran.Next(numbers.Length)] + " " + option1);
                Console.ReadKey();
                Console.Clear();
                if (option == option1)
                {
                    input = input * 2;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.WriteLine("Press Enter to continue");
                }

            }
            else if (choice == "d.")
            {
                Console.WriteLine("You choose Lows/Highs: payout will be amount gambled * 2");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.ReadKey();
                    Console.Clear();
                }
                money = money - input;
                Console.Write(" Choose highs or lows: ");
                string option = Console.ReadLine();
                Random ran = new Random();
                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball fell on " + option1 + " " + colors[ran.Next(colors.Length)]);

                if ((option1 >= 1 && option1 <= 18 && option == "lows")
                || (option1 >= 19 && option1 <= 36 && option == "highs"))
                {

                    input = input * 2;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "e.")
            {
                Console.WriteLine(" You choose : Dozens: payout will be amount gambled * 3 ");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                Console.ReadKey();
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.ReadKey();
                    Console.Clear();
                }
                money = money - input;
                Console.Write(" Choose  a row first, second or third: ");
                string option = Console.ReadLine();
                Random ran = new Random();
                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball fell on " + option1 + " " + colors[ran.Next(colors.Length)]);
                if (option1 >= 1 && option1 <= 12 && option == "first" ||
                    option1 >= 13 && option1 <= 24 && option == "second" ||
                    option1 >= 25 && option1 <= 36 && option == "third")
                {

                    input = input * 3;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "f.")
            {
                Console.WriteLine("You choose Columns: payout will be amount gambled *3 ");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }
                money = money - input;
                Console.Write(" Choose  a column first, second or third: ");
                string option = Console.ReadLine();
                Random ran = new Random();
                string option1 = columns[ran.Next(columns.Length)];
                Console.WriteLine("The ball fell on " + option1);

                if (option == option1)
                {

                    input = input * 3;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "g.")
            {
                Console.WriteLine("You choose Street: payout will be amount gambled * 12");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }
                money = money - input;
                Console.Write("Choose a row a. 1, 2, 3 or b. 22, 23, 24 type a or b : ");
                string option = Console.ReadLine();

                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball fell on " + option1 + " " + colors[ran.Next(colors.Length)]);

                if ((option == "a" && option1 <= 3) || (option == "b" && option1 >= 22 && option1 <= 24))
                {
                    input = input * 12;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "h.")
            {
                Console.WriteLine("You choose 6 Numbers: payout will be amount gambled * 6");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }
                money = money - input;
                Console.Write("Choose a row a. 1, 2, 3, 4, 5, 6 or b. 22, 23, 24, 25, 26, 27 : ");
                string option = Console.ReadLine();
                Random ran = new Random();
                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball fell on " + option1 + " " + colors[ran.Next(colors.Length)]);

                if ((option == "a" && option1 <= 6) || (option == "b" &&
                   option1 >= 22 && option1 <= 26))
                {
                    input = input * 6;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "i.")
            {
                Console.WriteLine("You choose Split: payout will be amount gambled * 18 ");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }
                money = money - input;
                Console.Write("Choose a edge  a. 1, 2 or b. 11, 14 or c. 35, 36 type a or b or c : ");
                string option = Console.ReadLine();
                Random ran = new Random();
                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball landed on " + option1 + " " + colors[ran.Next(colors.Length)]);

                if ((option == "a" && option1 <= 2) || (option == "b" &&
                    option1 == 11 || option1 == 14) || (option == "c"
                    && option1 == 35 || option1 == 36))
                {
                    input = input * 18;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else if (choice == "j.")
            {
                Console.WriteLine("You choose Corner: payout will be amount gambled * 8");
                Console.ReadKey();
                Console.Clear();
                Console.Write("You currently have " + money + " money, what would yo like to gamble : ");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Enter amount :");
                    Console.Clear();
                }
                money = money - input;
                Console.WriteLine("");
                Console.Write("Choose an intersection  a. 1,2,4,5 or b. 23,24,26,27 : ");
                string option = Console.ReadLine();
                Random ran = new Random();
                int option1 = numbers[ran.Next(numbers.Length)];
                Console.WriteLine("The ball fell on " + option1 + " " + colors[Gamble.ran.Next(colors.Length)]);

                if ((option == "a" && option1 <= 5) || (option == "b" &&
                    option1 == 23 || option1 == 24 || option1 == 26
                    || option1 == 27))
                {
                    input = input * 8;
                    money = input + money;
                    Console.WriteLine("Great job you now have " + money + " money ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lady luck wasnt on your side today you have " + money + " money left");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Please choose one of these options: ");
                Console.WriteLine("");
                Console.WriteLine("a., b., c., d., e., f., g., h., i., or j.");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue");
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
