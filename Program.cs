using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            spaces();

            test();

            filedetails();
            AnagramTest();
            Program isa = new Program();
            Console.WriteLine(isa.model);
            int[] arr = { 1, 2, 9, 5, 7 };
            //sort
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            Thread.Sleep(100000);
        }

        public static void spaces()
        {
            int st = 0;
            string str = "dot net is my goal";
            //Array sti = str.ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                //string str1 = str.Substring(i, 1);
                string sti = str[i].ToString();
                if (sti == " ")
                {
                    st++;
                }

                /*if()*/
            }
            Console.WriteLine(st);
        }

        public static void test()
        { 
        
        
        }

        public static bool isAnagram(string Firstword, string secondword)
        {
            //if (string.IsNullOrWhiteSpace(Firstword) || string.IsNullOrWhiteSpace(secondword) || Firstword.Length != secondword.Length)
            //{
            //    return false;
            //}
            //sczfsafsdfsd
            Firstword = Firstword.ToLower();
            secondword = secondword.ToLower();

            if (Firstword.Equals(secondword))
                return false;

            char[] Firstchar = Firstword.ToCharArray();
            char[] Secondchar = secondword.ToCharArray();
            Array.Sort(Firstchar);
            Array.Sort(Secondchar);
            for (int i = 0; i < Firstchar.Length; i++)
            {
                if (Firstchar[i] != Secondchar[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void AnagramTest()
        {
            //Anagrams
            Debug.Assert(isAnagram("cinema", "iceman"));
            Debug.Assert(isAnagram("Dave Barry", "Ray Adverb"));
            Debug.Assert(isAnagram("debit card", "bad credit"));
            Debug.Assert(isAnagram("abc123", "c3b2a1"));

            //Not Anagrams

            Debug.Assert(!isAnagram("bananab", "abanana"));
            Debug.Assert(!isAnagram("Tom Riddle", "I’m Lord Voldemort?"));
            Debug.Assert(!isAnagram("abc123", "a11b22c33"));

        }
        public static void check()
        {
            //terinary method
            int time = 20;
            string result = (time < 18) ? "good" : "good";
            Console.WriteLine(result);
        }


        public string model;
        public void program()
        {
            model = "ford";
        }

        public static void filedetails()
        {
            string text = "data";
            File.WriteAllText("dd.txt", text);
            string read = File.ReadAllText("dd.txt");

            Console.WriteLine(read);
        }

    }
}
