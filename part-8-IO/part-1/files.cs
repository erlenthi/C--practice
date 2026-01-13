using System.IO;
using System.Collections.Generic;

string currentFolder = AppContext.BaseDirectory;

System.Console.WriteLine(currentFolder);
IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("./");

foreach (var dir in listOfDirectories)
{
    Console.WriteLine("directory: ", dir);
}



List<string> salesFiles = new List<string>();
// Find all *.txt files in the stores folder and its subfolders
IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("./", "*.txt", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(".txt file: ", file);
    var fileInfo = new FileInfo(file);
    if (fileInfo.Length < 1000)
    {
        salesFiles.Add(file);
        Console.WriteLine("File added");
    }
    else
    {
        Console.WriteLine($"File not added. {file} is too big");
        Console.Write("Do you want to compress this file? (y/n): ");
        string response = Console.ReadLine();

        if (response?.ToLower() == "y")
        {
            using (var originalFileStream = new FileStream(file, FileMode.Open))
            using (var compressedFileStream = new FileStream(file + ".gz", FileMode.Create))
            using (var compressionStream = new System.IO.Compression.GZipStream(compressedFileStream, System.IO.Compression.CompressionMode.Compress))
            {
                originalFileStream.CopyTo(compressionStream);
            }
            Console.WriteLine($"File compressed to {file}.gz");
        }

    }
    // Display compressed files and handle decompression
    IEnumerable<string> compressedFiles = Directory.EnumerateFiles("./", "*.gz", SearchOption.AllDirectories);
    List<string> gzipFiles = compressedFiles.ToList();

    Console.WriteLine("\nAvailable compressed files:");
    foreach (var gzFile in gzipFiles)
    {
        Console.WriteLine(gzFile);
    }

    while (true)
    {
        Console.Write("\nEnter compressed file nam      e to decompress (or 'exit'): ");
        string compressedFileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(compressedFileName))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            continue;
        }

        if (compressedFileName.ToLower() == "exit")
            break;

        Console.Write("Enter name for decompressed file: ");
        string decompressedFileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(decompressedFileName))
        {
            Console.WriteLine("Output file name cannot be empty. Please try again.");
            continue;
        }

        try
        {
            if (File.Exists(decompressedFileName))
            {
                Console.WriteLine($"Error: File '{decompressedFileName}' already exists.");
                continue;
            }

            using (var compressedStream = new FileStream(compressedFileName, FileMode.Open))
            using (var decompressStream = new FileStream(decompressedFileName, FileMode.Create))
            using (var gzipStream = new System.IO.Compression.GZipStream(compressedStream, System.IO.Compression.CompressionMode.Decompress))
            {
                gzipStream.CopyTo(decompressStream);
            }
            Console.WriteLine($"File decompressed successfully to {decompressedFileName}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: Compressed file '{compressedFileName}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during decompression: {ex.Message}");
        }
    }

}

