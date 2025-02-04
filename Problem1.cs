using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var t = int.Parse(input.ReadLine());
for (var ind = 0; ind < t; ind++)
{
    var nm = input.ReadLine().Split(' ').Select(int.Parse).ToArray();

    if (nm[0] == 1)
    {
        output.WriteLine(1);
        LampToRight();
        continue;
    }

    if (nm[1] == 1)
    {
        output.WriteLine(1);
        LampToDown();
        continue;
    }

    if (nm[0] == nm[1])
    {
        output.WriteLine(2);
        LampToRight();
        LampToLeft(nm[0], nm[1]);
        continue;
    }

    if (nm[0] > nm[1])
    {
        output.WriteLine(2);
        LampToDown();
        output.WriteLine($"{nm[0]} {nm[1]} U");
        continue;
    }

    output.WriteLine(2);
    LampToRight();
    LampToLeft(nm[0], nm[1]);
}

void LampToRight()
{
    output.WriteLine("1 1 R");
}

void LampToDown()
{
    output.WriteLine("1 1 D");
}

void LampToLeft(int n, int m)
{
    output.WriteLine($"{n} {m} L");
}