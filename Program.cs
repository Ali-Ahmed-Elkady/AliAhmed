namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x; double y; string z; bool f;
            x = 10; y = 15.5; z = "ali"; f = true;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(f);
            //------------------------------------------------------------------------------------------
            float Celsius = 10;
            float Fahrenheit = (Celsius*9/5)+32;
            //-------------------------------------------------------------------------------------------
            Console.WriteLine("please enter the first number");
            int FN = int.Parse(Console.ReadLine());
            Console.WriteLine("please select the operation");
            char OP =char.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int LN = int.Parse(Console.ReadLine());
            switch (OP)
            {
                case '+': Console.WriteLine(FN + LN);break;
                case '-': Console.WriteLine(FN - LN); break;
                case '*': Console.WriteLine(FN * LN); break;
                case '/': Console.WriteLine(FN / LN); break;
                default:
                    Console.WriteLine("Enter Valid Operation"); break;
                   
            }
            //-------------------------------------------------------------------------------------------------
            Console.WriteLine("please enter the length");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Width");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area ={Length*Width}");
            //-------------------------------------------------------------------------------------------------
            Console.WriteLine("Enter a number");
            int r = int.Parse(Console.ReadLine()); 
            if (r %2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            //---------------------------------------------------------------------------------------------------
            Console.WriteLine("Enter Your Age");
            int Age = int.Parse(Console.ReadLine());
            if (Age>= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            //-----------------------------------------------------------------------------------------------------
            Console.WriteLine("Enter your degree");
            int degree = int.Parse(Console.ReadLine());
            if (degree < 0 || degree > 100)
            {
                Console.WriteLine("Out of Range");
            }
            else if(degree >= 90)
            {
                Console.WriteLine("A");
            }
            else if (degree >= 80)
            {
                Console.WriteLine("B");
            }
            else if (degree >= 70)
            {
                Console.WriteLine("C");
            }
            else if (degree >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                {
                    Console.WriteLine("Fail");
                }
            }
            //-----------------------------------------------------------------------------------------------------
            Console.WriteLine("Enter a number");
            int Number = int.Parse(Console.ReadLine());
            if (Number< 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            //-------------------------------------------------------------------------------------------------------
            Console.WriteLine("please enter the length");
            int V = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Width");
            int C = int.Parse(Console.ReadLine());
            if (V==C)
            {
                Console.WriteLine("Square");
            }
            else
            {
                Console.WriteLine("Not square");
            }
        }
    }
}
