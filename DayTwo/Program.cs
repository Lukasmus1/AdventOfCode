float hor = 0;
float vert = 0;
string[] input = File.ReadAllText("Input.txt").Split("\n");
foreach (string i in input)
{
    if (i.Contains("forward"))
    {
        hor += Convert.ToInt32(i.Remove(0, 8));
    }
    else if(i.Contains("up"))
    {
        vert -= Convert.ToInt32(i.Remove(0, 3));
    }
    else if(i.Contains("down"))
    {
        vert += Convert.ToInt32(i.Remove(0, 5));
    }
}
Console.WriteLine(hor * vert);