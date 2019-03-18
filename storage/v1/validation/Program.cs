using Google.Protobuf;
using System;
using System.IO;

using Storage.V1.Tests;

public class Program
{
    static int Main(string[] args)
    {
        int result = 0;
        
        foreach (var file in args)
        {
            Console.WriteLine($"Validating {file}");
            try
            {
                string json = File.ReadAllText(file);
                TestFile.Parser.ParseJson(json);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.GetType().Name}: {e.Message}");
                result = 1;
            }
        }
        return result;
    }
}