decimal hor = 0;
decimal vert = 0;
decimal aim = 0;
string[] input = File.ReadAllText("Input.txt").Split("\n");
foreach (string i in input)
{
    if (i.Contains("forward"))
    {
        hor += Convert.ToInt32(i.Remove(0, 8));
        vert += (aim * Convert.ToInt32(i.Remove(0, 8)));
    }
    else if (i.Contains("up"))
    {
        aim -= Convert.ToInt32(i.Remove(0, 3));
    }
    else if (i.Contains("down"))
    {
        aim += Convert.ToInt32(i.Remove(0, 5));
    }
}
Console.WriteLine(hor * vert);