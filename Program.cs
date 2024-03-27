Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());
int currentGapLength = 0;
int maxGapLength = 0;

while (number > 0)
{
    int result = number % 2;

    if (result == 0)
    {
        currentGapLength++;
    }
    else
    {
        if (currentGapLength > maxGapLength)
        {
            maxGapLength = currentGapLength;
        }

        currentGapLength = 0;
    }

    number = number / 2;
}

Console.WriteLine("Longest binary gap: " + maxGapLength);