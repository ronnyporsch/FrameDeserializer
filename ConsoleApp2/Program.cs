using System.Text.Json;
using ConsoleApp2;

public class Program
{
    private static string pathToJson = @"../../../Data/frame.json";
    
    public static void Main()
    {
        string[] lines = File.ReadAllLines(pathToJson);
        string json = String.Concat(lines);
        FrameV2? frame = JsonSerializer.Deserialize<FrameV2>(json);

        Console.WriteLine(frame?.nameOfTask);
        Console.WriteLine(frame?.frameNumber);
        Console.WriteLine(frame?.sensors[1].quaternion?.q0);
    }
}