/*
// System.Int32 (Value Type)
public struct Int32
{
    //....
}

// System.String (Reference Type)
public sealed class String
{
   //....
*/


using System;



namespace UsingStruct
{
    class Program
    {

        struct MyPoint
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
                // string s = string.Format("{{ \"Name\" : \"{0}\" }}", name);
            }
        }


        static void Main(string[] args)
        {
            // 구조체 사용
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }
    }
}
