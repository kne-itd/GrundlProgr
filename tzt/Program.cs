using System;

namespace tzt
{
    class Program
    {
        static double Div(int dividend, int divisor)
        {
            //if (divisor == 0)
            //{
            //    throw new DivideByZeroException();
            //}
            return dividend / divisor;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Div(4, 0));
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
