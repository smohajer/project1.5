using System;

namespace project15
{
    class Program
    {

        static void Main(string[] args)
        {

            string sample1 = "test";
            string sample2 = "tests";
            bool something = false;

            // if more than two off cannot be right
            if (Math.Abs(sample1.Length - sample2.Length) > 1)
                Console.WriteLine("false");

            //trying to make sure we go outside of array
            else if (sample1.Length <= sample2.Length)
            {
                for (int i = 0; i < sample1.Length; i++)
                {
                    if (sample1[i] == sample2[i])
                        something = true;

                    else if (sample1[i] == sample2[i + 1] || sample1[i + 1] == sample2[i])
                        something = true;

                    else
                        something = false;
                    
                }
                Console.WriteLine(something);
            }

            //ensures we dont go outside array
            else
            {
                for (int i = 0; i < sample2.Length-1; i++)
                {
                    if (sample2[i] == sample1[i])
                        something = true;

                    else if (sample2[i] == sample1[i + 1] || sample2[i + 1] == sample1[i])
                        something = true;

                    else
                        something = false;
                    
                }
                Console.WriteLine(something);
            }
            
        }
    }

}
   