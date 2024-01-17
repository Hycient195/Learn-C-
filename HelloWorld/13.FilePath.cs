using System;
public class FilePath
{
    public static void Entrypoint()
    {
        PathMethods();
    }

    public static void PathMethods()
    {
        const string filePath = @"C:\MyPc\Documents\CSharpfiles\HelloWorld\HelloWorld.sln";

        string path = Path.GetExtension(filePath);
        Console.WriteLine(path);
        Console.WriteLine(Path.GetRelativePath(filePath, @"C:\MyPc\Documents\CSharpfiles\Mailbox"));
        Console.WriteLine(Path.Join(@"C:\MyPc\Documents\CSharpfiles", "index.cshtml"));
    }
    /* More path methods can be researched on as per timely usecases */
}

// Breakpoints and controls, Call Stack, Watch window, Running in debug mode 