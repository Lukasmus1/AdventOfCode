float res = 0;
int[] input = Array.ConvertAll(File.ReadAllText("Input.txt").Split("\n"), int.Parse);
List<int> inputSum = new();

for (int i = 0; i < input.Length; i ++)
{
    if (input.Length - Array.IndexOf(input, input[i]) >= 3)
        inputSum.Add(input[i] + input[i + 1] + input[i + 2]);
    else
        break;
}

for (int i = 0; i < inputSum.Count - 1; i++)
{
    if (inputSum[i + 1] > inputSum[i])
    {
        res++;
    }
}
Console.WriteLine(res);