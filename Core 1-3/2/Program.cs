using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input distance (meters):");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input timeSec (hour):");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input timeSec (minutes):");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input timeSec (seconds):");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Total time in seconds
        double totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

        // Speed in meters per second
        double speedMetersPerSecond = distance / totalTimeInSeconds;

        // Speed in kilometers per hour (1 meter/second = 3.6 kilometers/hour)
        double speedKmPerHour = speedMetersPerSecond * 3.6;

        // Speed in miles per hour (1 kilometer/hour = 0.621371 miles/hour)
        double speedMilesPerHour = speedKmPerHour * 0.621371;

        Console.WriteLine($"Your speed in metres/sec is {speedMetersPerSecond}");
        Console.WriteLine($"Your speed in km/h is {speedKmPerHour}");
        Console.WriteLine($"Your speed in miles/h is {speedMilesPerHour}");
    }
}
