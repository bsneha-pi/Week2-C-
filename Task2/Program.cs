namespace Task2
{
    class Circle
    {
        // Constant PI
        public const double PI = 3.14;

        // Method to calculate the area
        public static double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }

        // Method to calculate the perimeter
        public static double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }

    class Program
    {
        static void Main()
        {
            // Display the value of PI
            Console.WriteLine("Value of PI: " + Circle.PI);

            // Create a radius
            double radius = 5;

            // Calculate the area
            double area = Circle.CalculateArea(radius);

            // Calculate the perimeter
            double perimeter = Circle.CalculatePerimeter(radius);

            // Display the results
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area of Circle: " + area);
            Console.WriteLine("Perimeter of Circle: " + perimeter);

            

            Console.WriteLine("PI is a constant and cannot be changed.");
            //constant's value is fixed and cannot be changed or reassigned later in the program.
            //so trying to assign 3.14159 to Circle.PI results in a compilation error.
        }
    }
}