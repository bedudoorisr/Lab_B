using System;
using System.Threading;

using GeometricFigureHandler;


namespace GeometricApp
{
    public class ShapeGenerator
    {
        private readonly Random myRandom = new Random();
        private Vector3 myCenter;
        private bool myIsCenterGiven;

        public void GenerateShape()
        {
            myIsCenterGiven = false;
            for (var i = 0; i < 20; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(200);
                Console.WriteLine("");
                Console.Write($"{$"Shape {i + 1} : ",15}");
                CreateShape(myRandom.Next(0, 6));
            }
        }

        public void GenerateShape(Vector3 center)
        {
            myIsCenterGiven = true;
            myCenter = center;
            for (var i = 0; i < 20; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(200);
                Console.WriteLine("");
                Console.Write($"{$"Shape {i + 1} : ",15}");
                CreateShape(myRandom.Next(0, 6));
            }
        }

        private void CreateShape(int shape)
        {
            switch (shape)
            {
                case 0:
                    CreateAndPrintCircle();
                    break;
                case 1:
                    CreateAndPrintRectangle();
                    break;
                case 2:
                    CreateAndPrintSquare();
                    break;
                case 3:
                    CreateAndPrintTriangle();
                    break;
                case 4:
                    CreateAndPrintCuboid();
                    break;
                case 5:
                    CreateAndPrintCube();
                    break;
                case 6:
                    CreateAndPrintSphere();
                    break;
            }
        }

        private Vector3 GetCenter()
        {
            var center = new Vector3
            {
                X = (float) Math.Round(myRandom.NextDouble() * 20, 1),
                Y = (float) Math.Round(myRandom.NextDouble() * 20, 1),
                Z = (float) Math.Round(myRandom.NextDouble() * 20, 1)
            };
            return center;
        }

        private void CreateAndPrintSphere()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Sphere ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var radius = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var sphere = new Sphere(myCenter, radius);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}" + sphere);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {sphere.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Volume : {sphere.Volume}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintCube()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Cube ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var width = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var cube = new Cuboid(myCenter, width);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + cube);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {cube.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Volume : {cube.Volume}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintCuboid()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Cuboid ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var height = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var width = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var length = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var size = new Vector3 {X = height, Y = width, Z = length};
            var cuboid = new Cuboid(myCenter, size);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + cuboid);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {cuboid.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Volume : {cuboid.Volume}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintTriangle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Triangle ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var p1 = new Vector2 {X = (float) Math.Round(myRandom.NextDouble() * 20, 1), Y = (float) Math.Round(myRandom.NextDouble() * 20, 1)};
            var p2 = new Vector2 {X = (float) Math.Round(myRandom.NextDouble() * 20, 1), Y = (float) Math.Round(myRandom.NextDouble() * 20, 1)};
            var p3 = new Vector2 {X = 3 * myCenter.X - p1.X - p2.X, Y = 3 * myCenter.Y - p1.Y - p2.Y};
            var triangle = new Triangle(p1, p2, p3);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + triangle);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {triangle.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Circumference : {triangle.Circumference}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintSquare()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Square ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var width = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var square = new Rectangle(myCenter, width);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + square);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {square.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Circumference : {square.Circumference}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintRectangle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Rectangle ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var length = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var width = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var size = new Vector2 {X = length, Y = width};
            var rectangle = new Rectangle(myCenter, size);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + rectangle);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {rectangle.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Circumference : {rectangle.Circumference}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }

        private void CreateAndPrintCircle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating Circle ...");
            myCenter = myIsCenterGiven ? myCenter : GetCenter();
            var radius = (float) Math.Round(myRandom.NextDouble() * 20, 1);
            var circle = new Circle(myCenter, radius);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",10}" + circle);
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine($"{"",15}Area : {circle.Area}");
            Thread.Sleep(200);
            Console.WriteLine($"{"",15}Circumference : {circle.Circumference}");
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine(new string('-', 100));
        }
    }
}