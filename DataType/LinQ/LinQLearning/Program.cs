namespace LinQLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = GetIntNumbers();
            Print(dataSource);

            // Way1:
            // var negativeData = from n in dataSource
            //     where n >= 0
            //     select n;
            // Way2:
            var negativeData = from n in dataSource
                where isPositive(n)
                    select n;
            Print(negativeData);
            
            Console.WriteLine($"The sum: {negativeData.Sum()}");
        }

        static bool isPositive(int number)
        {
            Console.WriteLine($"{number} is positive {number >= 0}");
            return number >= 0;
        }
        
        static IEnumerable<int> GetIntNumbers()
        {
            var ns = new int[] {1, 2, 3, 4, 5, -1, 23, -99, 0, -123, -121};

            return ns;
        }

        static void Print(IEnumerable<int> numbers)
        {
            Console.WriteLine("-----------------");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}