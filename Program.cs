using System;

using GeometricFigureHandler;


namespace GeometricApp
{
    internal class Program
    {
        private static float myP1, myP2, myP3;

        private static void Main(string[] args)
        {
            var shapeGenerator = new ShapeGenerator();
            string temp;
            do
            {
                if (Start())
                {
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine("");
                    Console.WriteLine("Generating Shapes ...");
                    Console.WriteLine("");
                    Console.WriteLine(new string('-', 100));
                    shapeGenerator.GenerateShape();
                }
                else
                {
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine("");
                    Console.WriteLine($"Generating shapes with center ({myP1:N1},{myP2:N1},{myP3:N1}) ...");
                    Console.WriteLine("");
                    Console.WriteLine(new string('-', 100));
                    shapeGenerator.GenerateShape(new Vector3 {X = myP1, Y = myP2, Z = myP3});
                }

                Console.WriteLine("");
                Console.WriteLine("Press 1 to try again");
                Console.WriteLine("Press any other key to exit ...");
                temp = Console.ReadKey().KeyChar.ToString().Split('\'')[0];
            } while (temp == "1");

            Environment.Exit(0);
        }

        private static bool Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('=', 100));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"",40} Geometric App");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('=', 100));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter 1 to generate shapes with randomly generated values");
            Console.WriteLine("Enter 2 to generate shapes with specific center and remaining values randomly generated");
            Console.WriteLine("Enter 3 to exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Note : Don't press Enter button after pressing the key.");
            string temp;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Your option : ");
                Console.ForegroundColor = ConsoleColor.White;
                temp = Console.ReadKey().KeyChar.ToString().Split('\'')[0];
                Console.ForegroundColor = ConsoleColor.Red;
                if (temp != "1" && temp != "2" && temp != "3")
                    Console.WriteLine(" Invalid option ! try again ");
            } while (temp != "1" && temp != "2" && temp != "3");

            if (temp == "3")
                Environment.Exit(0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            if (temp == "1")
                return true;
            GetCenterCoordinates();

            return false;
        }

        private static void GetCenterCoordinates()
        {
            bool flag;
            string temp;
            Console.WriteLine("");
            Console.WriteLine("Enter value for the coordinates of center between -20.0 to 20.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Note :Press Enter button after entering the value.");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter X coordinate of center : ");
                Console.ForegroundColor = ConsoleColor.White;
                temp = Console.ReadLine();
                flag = float.TryParse(temp, out var value);
                if (flag)
                {
                    if (value >= -20 && value <= 20)
                    {
                        myP1 = (float) Math.Round(value, 1);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" value must be in the range of -20.0 to 20.0 ");
                        flag = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid value ! try again ");
                }
            } while (!flag);

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Y coordinate of center : ");
                Console.ForegroundColor = ConsoleColor.White;
                temp = Console.ReadLine();
                flag = float.TryParse(temp, out var value);
                if (flag)
                {
                    if (value >= -20 && value <= 20)
                    {
                        myP2 = (float) Math.Round(value, 1);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" value must be in the range of -20.0 to 20.0 ");
                        flag = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid value ! try again ");
                }
            } while (!flag);

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Z coordinate of center : ");
                Console.ForegroundColor = ConsoleColor.White;
                temp = Console.ReadLine();
                flag = float.TryParse(temp, out var value);
                if (flag)
                {
                    if (value >= -20 && value <= 20)
                    {
                        myP3 = (float) Math.Round(value, 1);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" value must be in the range of -20.0 to 20.0 ");
                        flag = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid value ! try again ");
                }
            } while (!flag);
        }
    }
}