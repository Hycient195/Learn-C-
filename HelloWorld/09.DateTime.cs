public class DateTimeType
{
    public static void EntryPoint()
    {
        //DateAndTime();
        //TimeSpanType();
    }

    public static void DateAndTime()
    {
        //Creating a new date-Time instance
        var dateTimeInstance = new DateTime(2024, 11, 20, 18, 15, 20);
        Console.WriteLine(dateTimeInstance); // Accessing entire date-time instance
        Console.WriteLine(dateTimeInstance.Second); // Accessing individual property
        Console.WriteLine(dateTimeInstance.AddYears(2)); // You can perform date arithmetic on any of the date or time parameters.

        /* Getting Current Date and time */
        var now = DateTime.Now;
        var today = DateTime.Today;
        Console.WriteLine("Today is: " + now.TimeOfDay);

        Console.WriteLine("Short date string: " + today.ToShortDateString());
        Console.WriteLine("Long date string: " + today.ToLongDateString());
        Console.WriteLine("Short time string: " + now.ToLongTimeString());

        //Displaying the full date-Time in string format
        Console.WriteLine("Full date-time string: " + now.ToString());
        //Further formatting the date in any form of choice
        Console.WriteLine("Full date-time string: " + now.ToString("yyyy_mm_dd h_m_s"));
    }

    public static void TimeSpanType()
    {
        /* A timespan is simply the difference between two date instances 
         Let's have a look at how this looks like */

        var now = DateTime.Now;
        var someTimeTomorrow = DateTime.Now.AddDays(1).AddHours(4).AddMinutes(36);
        var duration = someTimeTomorrow - now;
        Console.WriteLine("The duration between now and sometime tomorrow: " + duration);

        // A timespan can also be created from its class
        var timeframe = new TimeSpan(3,34,56); // Hour, Minuite and Seconds
        // More overloads of the above tranlate to mapping the numbers to differet properties.
        Console.WriteLine("Manually created timeframe: " + timeframe);

        // A timespan can also be created from the "Timespan's" static methods
        // For the above we can also represent it as
        var newTimeframe = TimeSpan.FromHours(3) + TimeSpan.FromMinutes(34) + TimeSpan.FromSeconds(56);
        Console.WriteLine("New Manually created timeframe: " + newTimeframe);

        // The individual constituemts of the timespan can also be obtained.
        Console.WriteLine("Timeframe minutes: " + newTimeframe.Minutes);

        // The entire constituents of the timeframe can also be represented in
        // terms of one of its parameters
        Console.WriteLine("The entire timeframe represented in minutes: " + newTimeframe.TotalMinutes);

        // A timeframe can also be added to or subtracted from another timeframe
        var augumentedTimeframe = newTimeframe.Add(TimeSpan.FromHours(2));
        Console.WriteLine("Augumented timeframe is: " + augumentedTimeframe);

        // A timeframe can also be converted to string as seen below
        string stringedTimeframe = augumentedTimeframe.ToString();
        Console.WriteLine("Stringified timeframe: " + stringedTimeframe);

        // We can also obtain a timespan from a string by parsing it as seen below
        var parsedTimespan = TimeSpan.Parse("10:22:13");
        Console.WriteLine("The parsed timespan is: " + parsedTimespan);
        
    }
}
