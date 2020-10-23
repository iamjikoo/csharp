using System;

namespace UsingNullableType
{
    class Program
    {
        static void Main(string[] args)
        {

            // nullable type 
            {
                int? i = null;
                bool? b = null;
                int?[] a = new int?[100];

                // nullable concept :
                int ii = int.MaxValue; // 할당안하게 만드는 방법1
                bool iHasValue = false; // 할당안하게 만드는 방법2
                int? iii = null;
                if (iii.HasValue)
                {
                    Console.WriteLine(iii.Value);
                }


            }
        }

        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            // time값이 있는 체크.
            if (!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;

            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }

        public void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int result = Nullable.Compare<int>(a, b);
            Console.WriteLine(result); //결과 -1

            double? c = 0.01;
            double? d = 0.0100;
            bool result2 = Nullable.Equals<double>(c, d);
            Console.WriteLine(result2); //결과 true
        }

    }
}
