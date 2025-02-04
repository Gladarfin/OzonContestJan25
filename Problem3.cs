using System.Text;

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var t = int.Parse(input.ReadLine());

for (var ind = 0; ind < t; ind++)
{
    var n = int.Parse(input.ReadLine());
    var oddCharsMap = new Dictionary<string, int>();
    var evenCharsMap = new Dictionary<string, int>();
    var words = new Dictionary<string, int>();
    for (var i = 0; i < n; i++)
    {
        var curString = input.ReadLine()!;
        var oddChars = new StringBuilder();
        var evenChars = new StringBuilder();

        for (var j = 0; j < curString.Length; j++)
        {
            if (j % 2 == 0)
            {
                evenChars.Append(curString[j]);
                continue;
            }
            oddChars.Append(curString[j]);
        }
        var curOdd = oddChars.ToString();
        var curEven = evenChars.ToString();

        evenCharsMap.TryAdd(curEven, 0);
        evenCharsMap[curEven]++;

        if (!string.IsNullOrEmpty(curOdd))
        {
            words.TryAdd(curString, 0);
            words[curString]++;
            oddCharsMap.TryAdd(curOdd, 0);
            oddCharsMap[curOdd]++;
        }
    }

    var oddSum = oddCharsMap.Values.Sum(GetPairCount);
    var evenSum = evenCharsMap.Values.Sum(GetPairCount);
    var intersectSum = words.Values.Sum(GetPairCount);

    output.WriteLine(oddSum + evenSum - intersectSum);
}

long GetPairCount(int n)
{
    return n * (n - 1) / 2;
}