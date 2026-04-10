namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1: 

            //static double Add(double a, double b) => a + b;
            //static double Subtract(double a, double b) => a - b;
            //static double Multiply(double a, double b) => a * b;
            //static double Divide(double a, double b)
            //{
            //    if (b == 0) return 0; 
            //    return a / b;
            //}


            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter operation (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //double result = op switch
            //{
            //    '+' => Add(num1, num2),
            //    '-' => Subtract(num1, num2),
            //    '*' => Multiply(num1, num2),
            //    '/' => Divide(num1, num2),
            //    _ => 0
            //};
            //Console.WriteLine("Result: " + result);
            #endregion

            #region Q2
            
            //static void CalculateCircle(double radius, out double area, out double circumference)
            //{
            //    area = Math.PI * radius * radius;
            //    circumference = 2 * Math.PI * radius;
            //}

            //// Inside Main:
            //Console.Write("Enter Radius: ");
            //double r = double.Parse(Console.ReadLine());
            //CalculateCircle(r, out double a, out double c);
            //Console.WriteLine($"Area: {a}, Circumference: {c}");
              #endregion

            #region enum
           
        //    enum Grade { A, B, C, D, F }

   
        //static Grade GetGrade(int score)
        //{
        //    if (score >= 90) return Grade.A;
        //    if (score >= 80) return Grade.B;
        //    if (score >= 70) return Grade.C;
        //    if (score >= 60) return Grade.D;
        //    return Grade.F;
        //}

        //static double CalculateAverage(int[] scores)
        //{
        //    double sum = 0;
        //    foreach (int s in scores) sum += s;
        //    return sum / scores.Length;
        //}

        //static void GetMinMax(int[] scores, out int min, out int max)
        //{
        //    min = scores[0];
        //    max = scores[0];
        //    foreach (int s in scores)
        //    {
        //        if (s < min) min = s;
        //        if (s > max) max = s;
        //    }
        //}

       
      
           #endregion
        }
    }
}
