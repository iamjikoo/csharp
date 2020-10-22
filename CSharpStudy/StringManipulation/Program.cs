using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.Write("Enter a sentence: ");

            sentence = Console.ReadLine();
            string[] words = sentence.Split();

            PrintReverseOrderWords(sentence);

            PrintReverseWithDash(sentence);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(CapitalizeFirstLetter(words[i]) + " ");
            }
            Console.WriteLine();

            //Console.Write("Enter a word to search: ");
            //string keyword = Console.ReadLine();
            //SearchLocationofWords(sentence, keyword);
        }

        static void PrintReverseOrderWords(string sentence)
        {
            string[] words = sentence.Split();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }
            Console.WriteLine();
        }

        static void PrintReverseWithDash(string sentence)
        {
            string[] words = sentence.Split();

            string newSentence = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i%2 == 1)
                {
                    newSentence += words[i];
                } else
                {
                    newSentence += "-";
                }
            }
            Console.WriteLine(newSentence);
        }

        static string CapitalizeFirstLetter(string word)
        {
            string capitalWord;

            capitalWord = word.Substring(0, 1).ToUpper();

            if (word.Length > 1)
            {
                capitalWord += word.Substring(1).ToLower();
            }

            return capitalWord;
        }

        //static void SearchLocationofWords(string sentence, string keyword)
        //{

        //    string str = "i am a boy";

        //    str.ToLower();
        //    str.ToUpper();
        //    str.Substring(1);
        //    str.IndexOf("aaa");
        //    //str.Reverse()


        //    //string str1, str2;
        //    //String.Compare(str1, str2);
        //    //if str1.Contains(str2)
        //    // substr == 
        //}


        static void StringFunctions()
        {
            // compare
            {
                string str1 = "I am a boy";
                string str2 = "I am a boy";

                if (String.Compare(str1, str2) == 0)
                {
                    Console.WriteLine(str1 + " and" + str2 + " are equal.");
                }
                else
                {
                    Console.WriteLine(str1 + " and" + str2 + " are not equal.");
                }
            }

            // contains 
            {
                string str = "This is Test";
                string key = "test";

                if (str.Contains(key))
                {
                    Console.WriteLine($"The sequence '{key}' was found.");
                }
            }

            // substring 
            {
                string str = "Last night, I dreamt of San Pedro";
                string substr = str.Substring(5);
                Console.WriteLine(substr);
            }

            // join
            {
                string[] strarray = { "apple", "banana", "orange", "kiwi" };

                string str = String.Join(",", strarray);
                Console.WriteLine(str);
            }

        }

        //string str;
        //str.ToLower();

        /* 




        */
    }
}
