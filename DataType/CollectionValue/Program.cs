class CollectionValue
{
    static void Main()
    {
        List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        var evenNumber = numbers.Where(x => x % 2 == 0);
        Console.WriteLine(string.Join(", ",evenNumber));
        
        numbers.Add(6);
        Console.WriteLine(string.Join(", ", numbers));

        // Dictionary<TKey, TValue> Example
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 30;
        ages["Bob"] = 25;
        Console.WriteLine($"Alice's age: {ages["Alice"]}");
    }
}