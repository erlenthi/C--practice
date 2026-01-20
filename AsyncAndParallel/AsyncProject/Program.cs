using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        string filePath = "example.txt";
        string content = await ReadFileAsync(filePath);
        Console.WriteLine(content);

    


    }

    public static async Task<string> ReadFileAsync(string filePath)
    {
       
 
           // return await File.ReadAllTextAsync(filePath);
           //Opening a stream
           using (FileStream stream = File.OpenRead(filePath))
        {   
            var content = await JsonSerializer.De
            return content;
        }
        //The code below shows the microsoft learn original Streamreader that I replaced
        // using (StreamReader reader = new StreamReader(filePath))
        // {   
        //     string content = await reader.ReadToEndAsync();
        //     return content;
        // }
        
    }

    public static async Task<string> WriteFileAsync(string filePath)
    {
       
        
            return await File.ReadAllTextAsync(filePath);
        // The code below shows the microsoft learn original Streamreader that I replaced
        using (StreamReader reader = new StreamReader(filePath))
        {   
            string content = await reader.ReadToEndAsync();
            return content;
        }
        
    } 

    class Student
    {
        string name; 
        
    }


}