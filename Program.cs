namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = GetNumber("Please enter a multi-digit number");
            Console.WriteLine(DuplicateNumbers(number));
            
        }

        static string GetNumber(string s)
        {
            string? userInput = "";
            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");
            return userInput;
        }

        static bool DuplicateNumbers(string num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] == num[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
