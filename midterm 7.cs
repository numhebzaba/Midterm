using System;

namespace midterm_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double realNum, imaNum;

            bool loop = true;
            while (loop)
            {

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        double c = double.Parse(Console.ReadLine());
                        double d = double.Parse(Console.ReadLine());
                        if (operation == "+")
                        {
                            realNum = a + c;
                            imaNum = b + d;
                        }
                        else if (operation == "-")
                        {
                            realNum = a - c;
                            imaNum = b - d;
                        }
                        else if (operation == "*")
                        {
                            realNum = a * c - b * d;
                            imaNum = a * d + b * c;
                        }
                        else if (operation == "/")
                        {
                            realNum = (a * c + b * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
                            imaNum = (b * c - a * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
                        }

                        break;
                    case "^":
                        double power = double.Parse(Console.ReadLine());

                        break;
                    case "|":
                        realNum = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                        break;
                    default:
                        loop = false;
                        break;

                }
            }
            //ยอมแพ้ทำไม่ทัน
        }
        static double RealMuti(double a, double b, double c, double d)
        {
            double realNum = a * c - b * d;
            return realNum;
        }
        static double ImaMuti(double a, double b, double c, double d)
        {
            double imaNum = a * d + b * c;
            return imaNum;
        }
        static void PowerIma(double a, double b,double n)
        {
            double c = a;
            double d = b;
            double resultReal = RealMuti(a, b, c,d);
            double resultIma = ImaMuti(a, b, c, d);



        }
    }
}
