namespace CalcDZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу-калькулятор, вычисляющую выражения вида a +b,
            // a - b, a / b, a* b, введенные из командной строки, и выводящую
            // результат выполнения на экран.

            if (args.Length==0)
            {
                Console.WriteLine("Enter the arguments to calculate");
            }
            double value1;
            double value2;
            if (double.TryParse(args[0] , out value1) && double.TryParse(args[2] , out value2)) 
            {
            switch (args[1])
                {
                    case "+":
                        Console.WriteLine($"{value1}+{value2}={value1+value2}");
                        break;
                        case "-":
                        Console.WriteLine($"{value1}-{value2}={value1 - value2}");
                        break;
                        case "*":
                        Console.WriteLine($"{value1}*{value2}={value1 * value2}");
                        break;
                        case "/":
                        if (value2==0)
                        {
                            throw new Exception("Can't divide by zero!");
                        }
                        Console.WriteLine($"{value1}/{value2}={value1 / value2}");
                        break;
                        default:
                        Console.WriteLine("I don't understand this simbol(((");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Enter the numbers please!");
            }
        }
    }
}
