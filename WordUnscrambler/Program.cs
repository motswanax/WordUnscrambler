using System;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.Write("Option was not recognized.");
                        break;
                }

                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueWordUnscrambleDecision = (Console.ReadLine() ?? string.Empty);
                } while (!continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                    !continueWordUnscrambleDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);

            
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            throw new NotImplementedException();
        }

    }
}
