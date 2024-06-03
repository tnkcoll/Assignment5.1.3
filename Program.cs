namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = GetNumber("Please enter a multi-digit number");
            int[] ints = GetIntArray(number);
            Console.WriteLine(DuplicateNumbers(ints));
            
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

        static int[] GetIntArray(string num)
        {
            int[] ints = new int[num.Length];

            //This for loop converts the string "num" to an integer array.
            for (int i = 0; i < num.Length; i++)
            {
                ints[i] = num[i];
            }
            return ints;
        }

        static bool DuplicateNumbers(int[] nums)
        {
            
            Dictionary<int, int> result = new Dictionary<int, int>();
            
            //This foreach loop cycles through the integer array and checks to see if the integer from the array is in the dictionary.
            //If so, it returns the boolean value "true" to the Main() method. If not, it adds the value from the array to the dictionary.
            foreach (int num in nums)
            {
                if (result.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    result[num] = 1;
                }
            }
             return false;
        }
    }
}
