List<string> oxGen = new(File.ReadAllText("Input.txt").Split("\n"));
List<string> co2Sc = new(oxGen);
for (int l = 0; oxGen.Count > 1; l++)
{
    int zero = 0;
    int one = 0;
    foreach (string i in oxGen)
    {
        if (i[l] == '1')
            one++;
        else
            zero++;
    }
    if (zero > one)
    {
        oxGen.RemoveAll(i => i[l] == '1');
    }
    else
    {
        oxGen.RemoveAll(i => i[l] == '0');
    }
}
for (int l = 0; co2Sc.Count > 1; l++)
{
    int zero = 0;
    int one = 0;
    foreach (string i in co2Sc)
    {
        if (i[l] == '1')
            one++;
        else
            zero++;
    }
    if (one < zero)
    {
        co2Sc.RemoveAll(i => i[l] == '0');
    }
    else
    {
        co2Sc.RemoveAll(i => i[l] == '1');
    }
}
Console.WriteLine(Convert.ToInt32(co2Sc[0].Remove(co2Sc[0].Length - 1), 2) * Convert.ToInt32(oxGen[0].Remove(oxGen[0].Length - 1), 2));