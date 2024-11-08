class ArrayType
{
    static void DisplayArray(string[] array) => Console.WriteLine(string.Join(", ", array));
    static void ChangeArray(string[] arr) => Array.Reverse(arr);

    static void ChangeArrayElemnt(string[] arr)
    {
        arr[0] = "Fri";
        arr[1] = "Wed";
        arr[2] = "Sun";
    }

    static void Main()
    {
        string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];        
        DisplayArray(weekDays);
        
        ChangeArray(weekDays);
        Console.WriteLine("Reverse Array");
        DisplayArray(weekDays);
        
        Console.WriteLine("Change Element");
        ChangeArrayElemnt(weekDays);
        DisplayArray(weekDays);
        
        var contacts = new[]
        {
            new
            {
                Name = "Eugene Zabokritski",
                PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
            },
            new
            {
                Name = "Hanying Feng",
                PhoneNumbers = new[] { "650-555-0199" }
            }
        };
        Console.WriteLine(contacts[0]);
    }
}