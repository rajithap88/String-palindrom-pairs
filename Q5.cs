using System;

namespace opkgsn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "at", "ta", "ct" };
            /*string input;
            //int n;
            Console.WriteLine("Enter integer for the number pattern of integers to be displayed ");
            input = Console.ReadLine();
            bool charResult;
            Boolean.TryParse(input, out charResult);*/

            bool stopProgram = false;
            
            while (stopProgram == false)
            {


                for (int i = 0; i < words.Length; i++)
                {
                    if (string.IsNullOrEmpty(words[i]))
                    {
                        Console.WriteLine("There is an empty string input.Kindly input your string once more with no empty values");
                        stopProgram = true;
                    }
                    else
                    {
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (i != j)
                            {
                                string a = string.Concat(words[i], words[j]);

                                //Console.WriteLine(a);
                                //Console.WriteLine(b);
                                char[] s1 = a.ToCharArray();
                                Array.Reverse(s1);
                                String rev1 = new string(s1);

                                if (a == rev1)
                                {
                                    //Console.WriteLine("true");
                                    Console.Write("[" + i + "," + j + "]" + ",");
                                }
                            }
                        }
                        stopProgram = true;
                    }
                }
            }  
        }


    }




}




