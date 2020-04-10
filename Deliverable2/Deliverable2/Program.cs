using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message? ");
            string input = Console.ReadLine();
            string inputUpper = input.ToUpper();



            Console.WriteLine("Your encoded message is: ");
            foreach (char c in inputUpper)

                
                Console.Write(((int)c - 64) + "-");

            static long ASCIIWordSum(string inputUpper, long[] sumArr)
            {
                int l = inputUpper.Length;
                int pos = 0;
                long sum = 0;
                long bigSum = 0;
                for (int i = 0; i < l; i++)
                {

                    
                    if (inputUpper[i] == ' ')
                    {
                        bigSum += sum;
                        sumArr[pos++] = sum;
                        sum = 0;
                    }
                    else

                        
                        sum += inputUpper[i];
                }

                 
                sumArr[pos] = sum;
                bigSum += sum;
                return bigSum;
            }

            
                
                int ctr = 0;
                for (int i = 0; i < inputUpper.Length; i++)
                    if (inputUpper[i] == ' ')
                        ctr++;

                long[] sumArr = new long[ctr + 1];

                
                long sum = ASCIIWordSum(inputUpper, sumArr);

                

                Console.WriteLine();
                
            int checksum = (int)sum;
            Console.Write("Checksum Value " + checksum);
        }
        }

        











    }


