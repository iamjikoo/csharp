using System;
using System.Text;
using System.Xml.Schema;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Type 
            {
                // char in C
                bool trueOrFalse = true; // true or false (8)
                byte byte_8bit_uint = 255;
                sbyte sbyte_8bit_int = -128;

                // short int 
                ushort ushort_16bit_uint = 65535;
                short short_16bit_int = -32768;

                // int , long, uint, ulong;
                // float, double 

                decimal decimal_128bit; // 128 bit decimal

                char char_16bit_unicode;
                string string_unicode;

                // DateTime : 2020-10-31 12:30:00
                DateTime dt = new DateTime(2020, 10, 31, 12, 30, 00);


                // object : System.Object type 
            }


            // Literal - use suffix :  default ( int, double, char, string, bool)
            {
                long l = 1234L;
                ulong ul = 1244UL;
                float f = 123.45F;
                double d = 123.45D; // default 

                char c = 'A';
                string s = "Hello";
            }


            // Min/Max Property 
            {
                int iMax = int.MaxValue;
                float fMax = float.MaxValue;

                // null for the reference type (not value type)
                string ss = null;
            }


            // Nullable Type conversion
            {
                int? ni = null;
                ni = 101;
                Nullable<int> nii = null;
                nii = 102;

                int ii = nii.Value; // nullable to int conversion
            }

            // Array 
            {
                string[] players = new string[10];
                string[] players2 = new string[] { "a1", "a2" };
                string[] players3 = { "a1", "a2" };

                // 2-order-array
                string[,] depts = { { "a1", "a2" }, { "b1", "b2" } };

                // 3-roder array
                string[,,] cubes;

            }

            // Jagged Array - array of array 
            {
                int[][] A = new int[3][];  // array size : 3 - determined when compiled
                A[0] = new int[2];
                A[1] = new int[3] { 1, 2, 3 };
                A[2] = new int[] { 1, 2, 3, 4 };

                A[0][0] = 1;
                A[0][1] = 2;
            }

            // array.Length
            {
                int sum = 0;
                int[] scores = { 80, 70, 60, 50, 40 };
                for (int i = 0; i < scores.Length; i++)
                {
                    sum += scores[i];
                }
                Console.WriteLine(sum);
            }

            // string : immutable
            {
                string s1 = "C#";
                string s2 = "Programming";

                string s3 = s1 + " " + s2;
                Console.WriteLine($"String: {s3}");

                string s3sub = s3.Substring(1, 5);
                Console.WriteLine("Substring: {0}", s3sub);
            }

            // char array 
            {
                // convert string to char[]
                string str = "Hello";
                char[] charArray = str.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    Console.WriteLine(charArray[i]);
                }

                // convert char[] to string
                char[] charArray2 = { 'H', 'e', 'l', 'l', 'o' };
                string s4 = new string(charArray);

                char[] aaa = new char[4];


            }

            // StringBuilder: mutable class
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= 26; i++)
                {
                    sb.Append(i.ToString());
                    //sb.Append(System.Environment.NewLine);
                    sb.Append("\n");
                }
                string s = sb.ToString();
                Console.WriteLine(s);

            }

            // CSVar obj 
            {
                CSVar obj = new CSVar();
                obj.Method1();
            }

            // enum use
            {
                City myCity;

                myCity = City.Jeju;
                int cityValue = (int)myCity;
                Console.WriteLine("cityvalue {0}", cityValue);
            }

            // enum flags
            {
                Border b = Border.Top | Border.Bottom;

                if ((b & Border.Top) != 0)
                {
                    if (b.HasFlag(Border.Bottom))
                    {
                        Console.WriteLine(b.ToString()); // Top, Bottom print 
                    }
                }
            }

            // Null - coalescing operator
            {
                string str = "i am sam";
                string s = str ?? "(널)";

                int? i = null;
                i = i ?? 0;

                string s1 = null;
                s1 = s1 ?? string.Empty;
            }

            // foreach 
            {
                string[] array = new string[] { "AB", "CD", "EF" };

                foreach (string s in array)
                {
                    Console.WriteLine(s);
                }

                // 3차배열 선언
                string[,,] arr = new string[,,] {
                    { {"1", "2"}, {"11","22"} },
                    { {"3", "4"}, {"33", "44"} }
                };

                //for 루프 : 3번 루프를 만들어 돌림
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr.GetLength(2); k++)
                        {
                            Console.WriteLine(arr[i, j, k]);
                        }
                    }
                }

                //foreach 루프 : 한번에 3차배열 모두 처리
                foreach (var s in arr)
                {
                    Console.WriteLine(s);
                }
            }

 



        } // main

        // enum  :in-class or in-namespace
        enum City
        {
            Seoul,
            Daejeon,
            Busan = 5,
            Jeju = 10
        }


        // enum flag 
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

    } // class Program

    class CSVar
    {
        // field (global variable)
        int globalVar; // automatic initialized by 0 

        const int MAX = 1024; // determined when compiled 
        readonly int Max;  // readonly field  - determined when runtime
        public CSVar()
        {
            Max = 1;
        }

        static int globalVar2;


        public void Method1()
        {
            int localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);

        }
    }

}
