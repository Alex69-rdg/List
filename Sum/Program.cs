namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                int reversed = 0;

                for (; num > 0; num /= 10)
                {
                    int digit = num % 10;
                    reversed = reversed * 10 + digit;
                }

                reversedNumbers.Add(reversed);
            }
            int sum = 0;
            for (int i = 0;i< reversedNumbers.Count; i++)
            {
                sum += reversedNumbers[i];
            }

            Console.WriteLine($"Sum= {sum}");
        }
    }
    
}
