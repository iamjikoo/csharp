using System;

namespace UsingMethod
{
    class Program
    {
       private void Calculate(int a)
        {
            a *= 2;
        }

        // ref 정의
        static double GetData(ref int a, ref double b)
        { return ++a * ++b; }

        // out 정의
        //static bool GetData(int a, int b, out int c, out int d)
        static bool GetData(out int c, out int d)
        {
            c = 10 + 20;
            d = 30 - 10;
            return true;
        }


        static void Main(string[] args)
        {
            Program p = new Program();

            int val = 100;
            p.Calculate(val);
            // val는 그대로 100   

            // ref 사용. 초기화 필요.
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);
            Console.WriteLine($"{x}, {y}");

            // out 사용. 초기화 불필요.
            int c, d;
            //bool bret = GetData(10, 20, out c, out d);
            bool bret = GetData(out c, out d);
            Console.WriteLine($"{c}, {d}");

            // C# 4.0 named parameter 
            //Method1(name: "John", age: 10, score: 90)

            // C# 4.0 optional parameter 
            {
                int pret = p.Calc(1, 2);
                pret = p.Calc(1, 2, "*");
            }

            //void calculate(float a, float b, bool enableRound, string roundMethod = ".2") { }
            //calculate(2.3f, 5.1f, enableRound: true);

            // variable parameter: params
            {
                //메서드
                //int Calc(params int[] values)

                //사용
                //int s = Calc(1, 2, 3, 4);
                //s = Calc(6, 7, 8, 9, 10, 11);
            }



        }

        // Optional 파라미터: calcType
        int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }


    }
}
