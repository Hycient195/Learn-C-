//Create folder, Get directories, Get files, 

using System;
public class FolderOperations
{
    public static void Entrypoint()
    {
        //StaticFolderMethods();
        //InstanceFilderMethods();
    }

    public static void StaticFolderMethods()
    {
        const string directoryToCreate = @"../../../Newdir";
        Directory.CreateDirectory(directoryToCreate);

        const string existingDirectory = @"../../../../../HelloWorld";

        /* Using full function overload to search for directories */
        var directories = Directory.GetDirectories(existingDirectory, "*.*", SearchOption.AllDirectories);
        foreach (var directory in directories)
            Console.WriteLine(directory);

        /* Using full function overload to search for files */
        var files = Directory.GetFiles(existingDirectory, "*.*", SearchOption.AllDirectories);
        foreach (var file in files)
            Console.WriteLine(file);
    }

    public static void InstanceFilderMethods()
    {
        const string directoryToCreate = @"../../../NewInstDir";
        var directoryInstance = new DirectoryInfo(directoryToCreate);

        directoryInstance.Create();

        const string existingDirectory = @"../../../../../HelloWorld";
        var existingDirectoryInstance = new DirectoryInfo(existingDirectory);

        /* Using full function overload to search for directories */
        var existingDirectoryList = existingDirectoryInstance.GetDirectories("*.*", SearchOption.AllDirectories);
        foreach (var dir in existingDirectoryList)
            Console.WriteLine(dir);

        var existingFiles = existingDirectoryInstance.GetFiles("*.*", SearchOption.AllDirectories);
        foreach (var file in existingFiles)
            Console.WriteLine(file);
    }

    /* For more on these classes, visit the MSDN Docummentations */
}

