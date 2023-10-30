using System.Reflection.Metadata.Ecma335;

namespace _2310857_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int choice = 0;
            while (choice !=5)
            {
                Console.WriteLine("----| Basic Menu |----");
                Console.WriteLine("1) calculate area of a square/rectangle");
                Console.WriteLine("2) caculate perimiter of a square/rectangle");
                Console.WriteLine("3) check if rectangle thing is square");
                Console.WriteLine("4) check your triangle, ill tell you what it is");
                Console.WriteLine("");
                Console.WriteLine("5) exit for some reason... is my program not cool enough?\n\n");
                Console.Write("Select Option:\n>>> ");
                string input = Console.ReadLine();
                try
                {
                    choice = Convert.ToInt32(input); // attept to convert choice
                }
                catch
                {
                    // if not valid number output error
                    Console.WriteLine("Invalid Input!\n");
                }

                Rectangle rect;
                Triangle tria;
                switch (choice)
                {
                    case 1:
                        rect = BuildARectangle();
                        Console.WriteLine($"Your {(rect.isSquare() ? "Square" : "Rectangle")} has an area of {rect.Area()}²");
                        break;

                    case 2:
                        rect = BuildARectangle();
                        Console.WriteLine($"Your {(rect.isSquare() ? "Square" : "Rectangle")} has an perimeter of {rect.Perimeter()}");
                        break;

                    case 3:
                        rect = BuildARectangle();
                        Console.WriteLine($"A wild {(rect.isSquare() ? "Square" : "Rectangle")} appears... It's a shiny!");
                        break;

                    case 4:
                        tria = BuildATriangle();
                        Console.WriteLine($"A wild {tria.triangleType()} triangle appears... It's a shiny!");
                        break;

                }
                Console.WriteLine("\n");
            }
        }

        static Rectangle BuildARectangle()
        {
            // take length input
            double? length = null;
            while (length == null)
            {
                Console.Write("What length?\n>>> ");
                string input = Console.ReadLine();
                try
                {
                    length = Convert.ToDouble(input); // attept to convert length
                    break;
                }
                catch
                {
                    // if not valid number output error
                    Console.WriteLine("Invalid Input!\n");
                }
            }

            // take length input
            double? width = null;
            while (width == null)
            {
                Console.Write("What width?\n>>> ");
                string input = Console.ReadLine();
                try
                {
                    width = Convert.ToDouble(input); // attept to convert width
                    break;
                }
                catch
                {
                    // if not valid number output error
                    Console.WriteLine("Invalid Input!\n");
                }
            }

            return new Rectangle(Convert.ToDouble(length), Convert.ToDouble(width));
        }

        static Triangle BuildATriangle()
        {
            // take length input
            List<double> sides = new List<double> { 0, 0, 0 };

            int i = 0;
            List<double> temp = new List<double> { 0, 0, 0 };
            foreach (double num in sides)
            {
                double? tempvar = null;
                while (tempvar == null)
                {
                    Console.Write("What length?\n>>> ");
                    string input = Console.ReadLine();
                    try
                    {
                        tempvar = Convert.ToDouble(input); // attept to convert tempvar
                        break;
                    }
                    catch
                    {
                        // if not valid number output error
                        Console.WriteLine("Invalid Input!\n");
                    }
                }

                temp[i] = Convert.ToDouble(tempvar);
                i++;

            }
            sides = temp;

            return new Triangle(sides[0], sides[1], sides[2]);
        }
    }
}