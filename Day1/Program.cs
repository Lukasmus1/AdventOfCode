float res = 0;
int[] input = Array.ConvertAll(File.ReadAllText("Input.txt").Split("\n"), int.Parse);
for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i + 1] > input[i])
    {
        res++;
    }
}
Console.WriteLine(res);