Console.Write("Enter a number: ");

int n = int.Parse(Console.ReadLine());
string m = string.Empty;

while (n > 0)
{
    int result = n % 2;
    m = result.ToString() + m;
    n = n / 2;
}

Console.WriteLine("Binary: " + m);