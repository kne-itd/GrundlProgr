using System;

namespace Calculator
{
    class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        /// <summary>
        /// This method calculates the result of the input in
        /// accordance withe the mathematical precedense rules:
        /// BODMAS:
        ///     brackets, order, division/multiplication, addition/subtraction
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public static double CalcWithPrecedensRules(string task)
        {
            int startBracketPosition = 0;
            int closingBracketPosition = 0;
            string subTask = string.Empty;
            int subTaskLength = 0;
            int startPosition = 0;
            
            while (closingBracketPosition > -1)
            {
                closingBracketPosition = task.IndexOf(")", startPosition, task.Length);
                if (closingBracketPosition > 0)
                {
                    startBracketPosition = task.LastIndexOf("(", closingBracketPosition, closingBracketPosition);
                    subTaskLength = closingBracketPosition - startBracketPosition;
                    subTask = task.Substring(startBracketPosition, subTaskLength + 1); // includes parathesis
                    double temp = Calc(subTask.Trim(new char[] { '(', ')' }));
                    Console.WriteLine(temp);
                    task = task.Replace(subTask, temp.ToString());
                }   
            }
            // Brackets resolved

            return Calc(task);
        } 

        public static double Calc(string task)
        {
            char[] possibleOperators = { '+', '-', '*', '/' };
            string operators = String.Empty;
           
            foreach (char c in task)
            {
                foreach (char o in possibleOperators)
                {
                    if ( c == o)
                    {
                        operators += c.ToString();
                    }
                }
            }
            string[] temp = task.Split(possibleOperators);
            double[] dbls = Array.ConvertAll(temp, Double.Parse);
            double result = dbls[0];
            for (int i = 1; i < dbls.Length; i++)
            {
                char action = operators[i - 1];
                switch (action)
                {
                    case '+':
                        result += dbls[i];
                        break;
                    case '-':
                        result -= dbls[i];
                        break;
                    case '*':
                        result *= dbls[i];
                        break;
                    case '/':
                        if (dbls[i] == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result /= dbls[i];
                        break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator!");
            Console.WriteLine("*********************************************'");
            Console.WriteLine("Indtast dit regnestykke");
            Console.WriteLine("Du kan benytte +, -, *, /");

            //string task = Console.ReadLine();
            //string task = "2+3*4/0-3,5";
            string task = "2+(3*4+(3*4))+0-3,5/(2*2)";
            Console.WriteLine(task);
            Console.WriteLine("*********************************************'");
            Console.WriteLine(CalcWithPrecedensRules(task));
            Console.WriteLine("*********************************************'");
            try
            {
            //    Console.WriteLine(CalcWithPrecedensRules(task));
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}