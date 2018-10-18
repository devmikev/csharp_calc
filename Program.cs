using System;

namespace command_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            var x = GetNum("X");
            var oper = GetOperator();
            var y = GetNum("Y");
            var calc = Calculate(x, y, oper);
            Console.WriteLine(calc);
        }

        public static int GetNum(string variable)
        {
            Console.Write("Enter {0}: ", variable);
            int num;
            Int32.TryParse(Console.ReadLine(), out num);
            return num;
        }

        public static String GetOperator()
        {
            Console.Write("Enter an operatior ' +, -, *, /': ");
            var oper = Console.ReadLine();
            return oper;           
        }

        public static float Calculate(float a, float b, string c)
        {
            float result;
            switch (c)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }


    }
}
