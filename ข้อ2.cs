using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            string input;
            Console.Write("Input half DNA Sequence : ");
            input = Console.ReadLine();
            if (IsValidSequence(input))
            {
              Isvalid(input);
            }
            else
            {
                Isinvalid(input);
            }

        }
        static void Isvalid(string input)
        {
            bool loop = true;
            string YN;
            char ans;
            Console.WriteLine("Current half DNA sequence : {0} ", input);
            Console.Write("Do you want to replicate it ? Y or N : ");
            YN = Console.ReadLine();

            while (loop == true)
            {

                if (YN == "Y")
                {
                    string returnvalue = ReplicateSeqeunce(input);
                    Console.WriteLine("Replicated half DNA Sequence: {0}", returnvalue);
                    end();
                    break;

                }
                else if (YN == "N")
                {

                    end();
                    
                }
                else
                {
                    Console.WriteLine("Please input Y or N");
                    Isvalid(input);
                    break;
                }
            }
        }

        static void Isinvalid(string input)
        {
            Console.WriteLine("That half DNA Sequence is Invalid");
            end();
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static void end()
        {
            string ans;
            Console.Write("Do you want to process another sequence ?(Y or N) : ");
            ans = Console.ReadLine();

            if (ans == "Y")
            {
                Menu();

            }
            else if (ans == "N")
            {
                Console.WriteLine("You're done here");
            }
        }

    }
}
       
   
