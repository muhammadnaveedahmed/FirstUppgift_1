using System;
namespace prog1_Uppgift1
{
    class program
    {
        static bool programQuit = false;
        static void Main(string[] args)
        {
            while (programQuit == false)
            {
                BreakLine();
                MainMenuText();
                BreakLine('-', 20);
                UserChoise(UserInput());
                BreakLine('-', 20);
                BreakLine();

            }
        }

        private static void BreakLine(char v1, int v2)
        {
            throw new NotImplementedException();
        }

        private static void BreakLine() => throw new NotImplementedException();

        static void MainMenuText()
        {
            Console.WriteLine("Gör ditt Val:");
            Console.WriteLine("1: Skriv ut 1 till 100.");
            Console.WriteLine("2: Skriv ut 100 till 1.");
            Console.WriteLine("3: Avsluta Program");
        }
        static int UserInput()
        {
            string? inputString = Console.ReadLine();
            int inputNum;
            Int32.TryParse(inputString, out inputNum);
            return inputNum;
        }
        static void UserChoise(int UserInput)
        {
            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Du har gjort Val 1:");
                    Counter(true);
                    break;
                case 2:
                    Console.WriteLine("Du har gjort Val 2:");
                    Counter(false);
                    break;
                case 3:
                    Console.WriteLine("Program Avslutas:");
                    programQuit = true;
                    break;
                default:
                    Console.WriteLine("Dit val är ej giltigt, prova igen.");
                    UserChoise(UserInput);
                    break;

            }
            static void Counter(bool countUp)
            {
                if (countUp == true)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                else
                {
                    for (int i = 100; i > 0; i--)
                    {
                        Console.WriteLine(i);

                    }

                }
                static void BreakLine(char v, int v1) => BreakLine('*', 20);
            }
        }

        private static void BreakLine1(char breakLineType, int length)
        {
            string breakLine = new string(breakLineType, length);
            Console.WriteLine(breakLine);
        }

    }
}



