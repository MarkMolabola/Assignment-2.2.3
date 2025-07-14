namespace Assignment_2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Shape Area Calculator!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1) Circle ");
                Console.WriteLine("2) Square ");
                Console.WriteLine("3) Exit ");
                Console.WriteLine("-------------------------------------");
                
                String choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("-----Circle-----.");
                        Console.Write("Enter Radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
                        break;
                    case "2":
                        Console.WriteLine("------Square-----");
                        Console.Write("Enter Side Length: ");
                        double sideLength = double.Parse(Console.ReadLine());
                        Square square = new Square(sideLength);
                        Console.WriteLine($"Square Area: {square.CalculateArea()}");
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        continueProgram = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
                if (continueProgram)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (continueProgram);
        }
    }
}
