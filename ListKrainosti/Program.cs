namespace ListKrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            List<int> numbers=Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result=new List<int>();
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            for (int index=0;index < numbers.Count; index++)
            {
                if( numbers[index] == min|| numbers[index]==max)
                {
                    result.Add(numbers[index]);
                }
            }
            Console.WriteLine(string.Join(", ",result));
           
            
        }
    }
}
