public class ClassBasicsAndEncapsulationExercises
{
    public static void Entrypoint()
    {

        /* Exercise 2 */
        var newPost = new StackOverflowPost("How to debug a .Net application", "A very long description of the article");
        for (int i = 0; i < 8; i++)
            newPost.UpVote();

        for (int i = 0; i < 3; i++)
            newPost.DownVote();

        Console.WriteLine("The new post {0} has {1} votes", newPost.Title, newPost.Votes);
        //newPost.Votes = 400; // This would not be possible as write access to the "Votes" property is not allowed



        /* Exercise 1 */
        Console.WriteLine("Enter \"start\" to start stopwatch, \"stop\" to stop stopwatch \"show duration\" to show how long the stopwatch ran, and \"exit\" to exit stopwatch ");
        var stopwatch = new Stopwatch();

        while (true)
        {
            string command = Console.ReadLine();
            switch (command?.ToLower())
            {
                case "start":
                    stopwatch.Start();
                    break;
                case "stop":
                    stopwatch.Stop();
                    break;
                case "show duration":
                    Console.WriteLine(stopwatch.Duration);
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }

}




/// <summary>
/// Exercise 1
/// 
/// Design a class called Stopwatch. The job of this class is to simulate a stopwatch.
/// It should provide two methods: Start and Stop. We call the start method first,
/// and the stop method next.
/// Then we ask the stopwatch about the duration between start and stop.
/// Duration should be a value in TimeSpan. Display the duration on the console.
/// We should also be able to use a stopwatch multiple times.
/// So we may start and stop it and then start and stop it again.
/// Make sure the duration value each time is calculated properly.
/// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
/// So the class should throw an InvalidOperationException if its started twice.
/// 
/// </summary>


public class Stopwatch
{
    private bool _isStopwatchRunning = false;
    private DateTime _startTime;
    private DateTime _stopTime;

    public TimeSpan Duration
    {
        get { return _isStopwatchRunning ? (DateTime.Now - _startTime ) : (_stopTime - _startTime); }
    }

    public void Start()
    {
        if (!_isStopwatchRunning)
        {
            _isStopwatchRunning = true;
            _startTime = DateTime.Now;
            Console.WriteLine("Stopwatch started...");
        }
        else
        {
            Console.WriteLine("Stopwatch is already running");
            throw new InvalidOperationException("Stopwatch");
        }
    }

    public void Stop()
    {
        if (_isStopwatchRunning)
        {
            _isStopwatchRunning = false;
            _stopTime = DateTime.Now;
            Console.WriteLine("Stopwatch stopped");
        }
        else
        {
            Console.WriteLine("Stopwatch is already stopped");
            throw new InvalidOperationException("Stopwatch");
        }
    }
}

/// <summary>
/// Exercise 2
/// 
/// Design a class called Post. This class models a StackOverflow post.
/// It should have properties for title, description and the date/time it was created.
/// We should be able to up-vote or down-vote a post.
/// We should also be able to see the current vote value.
/// In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value.
/// 
/// In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
/// You should not give the ability to set the Vote property from the outside, because otherwise,
/// you may accidentally change the votes of a class to 0 or to a random number.
/// And this is how we create bugs in our programs.
/// The class should always protect its state and hide its implementation detail.
/// 
/// </summary>


public class StackOverflowPost
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public int Votes { get; private set; }

    public StackOverflowPost(string title, string description)
    {
        Title = title;
        Description = description;
        CreatedAt = DateTime.Now;
    }

    public void UpVote()
    {
        Votes += 1;
    }

    public void DownVote()
    {
        Votes -= 1;
    }
}


