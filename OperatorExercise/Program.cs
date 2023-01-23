namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.Write("Input an integer for a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Input an integer for b: ");
            int b = Int32.Parse(Console.ReadLine());
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"Addition: {addition}\n" +
                $"Subtraction: {subtraction}\n" +
                $"Multiplication: {multiplication}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // Exercise 2
            Console.Write("Input the radius of your circle: ");
            double radius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");

            // Thought Execercise
            var i = 3;
            var j = 4;
            var k = ++i * j++; // i is pre-fixed, so it adds 1 before the line is run.  j is post-fixed, so it adds 1 after the line is run.
            Console.WriteLine($"The value of k: {k}"); // i now == 4, j still == 4.  Therefore k = 4 * 4 == 16.
        }
        public static double AreaOfCircle(double radius) // Method for Exercise 2
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
