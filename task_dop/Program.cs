Console.Clear();

public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("INPUT.txt"); 
        int bushesCount = int.Parse(lines[0]); 
        string[] bushes = lines[1].Split(' '); 
        int[] berriesArray = bushes.Select(b => int.Parse(b)).ToArray(); 
 
        Console.ReadKey();
    }