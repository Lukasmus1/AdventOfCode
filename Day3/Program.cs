string gamma = "";
string epsilon = "";
string[] input = File.ReadAllText("Input.txt").Split("\n");
for (int l = 0; l < input[l].Length - 1; l++)
{
    int zero = 0;
    int one = 0;
    foreach (string i in input)
    {
        if (i[l] == '1')
            one++;
        else
            zero++;
    }
    if (zero > one)
    {
        gamma += "0";
        epsilon += "1";
    }
    else
    {
        gamma += "1";
        epsilon += "0";
    }
}
Console.WriteLine(Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));