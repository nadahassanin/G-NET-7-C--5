namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1: 
            
            static double Add(double a, double b) => a + b;
            static double Subtract(double a, double b) => a - b;
            static double Multiply(double a, double b) => a * b;
            static double Divide(double a, double b)
            {
                if (b == 0) return 0; 
                return a / b;
            }

            
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter operation (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            double result = op switch
            {
                '+' => Add(num1, num2),
                '-' => Subtract(num1, num2),
                '*' => Multiply(num1, num2),
                '/' => Divide(num1, num2),
                _ => 0
            };
            Console.WriteLine("Result: " + result);
            #endregion
        }
    }
}
