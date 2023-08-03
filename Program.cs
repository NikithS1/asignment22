using Assignment22;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Source source = new Source
        {
            CommonProperty1 = 10,
            CommonProperty2 = "Hello",
            CommonProperty3 = 3.14
        };

        Destination destination = new Destination();

        PropertyMapper.MapProperties(source, destination);

        Console.WriteLine($"CommonProperty1 in Destination: {destination.CommonProperty1}");
        Console.WriteLine($"CommonProperty2 in Destination: {destination.CommonProperty2}");
        Console.WriteLine($"DestinationProperty1 in Destination: {destination.DestinationProperty1}");
    }
}