using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var t = int.Parse(input.ReadLine());

for (var ind = 0; ind < t; ind++)
{
    var n = int.Parse(input.ReadLine());
    var goods = new HashSet<string>();
    var uniqPrices = new HashSet<string>();
    for (var i = 0; i < n; i++)
    {
        var curPair = input.ReadLine().Split(' ');
        goods.Add($"{curPair[0]}:{curPair[1]}");
        uniqPrices.Add(curPair[1]);
    }
    var friendResult = input.ReadLine().Split(',').ToList();
    var isDiff = false;
    foreach (var pair in friendResult)
    {
        var curPrice = pair.Split(':');
        if (curPrice.Length < 2 || !goods.Contains(pair) || !uniqPrices.Contains(curPrice[1]))
        {
            output.WriteLine("NO");
            isDiff = true;
            break;
        }
        uniqPrices.Remove(curPrice[1]);
    }
    if (!isDiff)
    {
        output.WriteLine(uniqPrices.Count > 0 ? "NO" : "YES");
    }
}