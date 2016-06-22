using System;
using System.IO;
using System.Text;

namespace Read_write_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string text_number = "";
            string str_max = "";
            StringBuilder str = new StringBuilder();
            var lines = File.ReadLines(@"Resources\input.txt");

            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '1')
                        {
                            str.Append(line[i]);
                            if (line[i + 1] == '0')
                            {
                                text_number = str.Append(" ").ToString();
                            }
                        }
                }

                string[] numberArray = text_number.Split(' '); 
                for(int i = 0; i < numberArray.Length; i++)
                {
                    if (numberArray[i].Length >= str_max.Length)
                    {
                        str_max = numberArray[i];
                    }
                }
                Console.WriteLine(text_number);
                Console.WriteLine("Longest: " + str_max);
                Console.WriteLine("Lenght: " + str_max.Length);
            }
            Console.ReadKey();

            File.WriteAllText(@"Resources\output.txt", str_max.Length.ToString());
        }
    }
}
