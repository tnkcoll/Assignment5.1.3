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
            //The first loop will iterate from the 0 index to the n-1 index, which is the same thing as num.Length - 1.
            for (int i = 0; i < num.Length - 1; i++)
            {
                //The inner loop will iterate from whatever index i is through the rest of the string array.
                for (int j = i + 1; j < num.Length; j++)
                {
                    //If the value in the string array at the index j is pointing to and the value in the string array that i is pointing to match, then return true.
                    //The keywork return ends both loops. The thread of execution then goes back to the Main() method.
                    if (num[j] == num[i])
                    {
                        return true;
                    }
                }
            }
            //If the values at the indexes that i and j are pointing too never match, then return false.
            return false;
        }
    }
}
