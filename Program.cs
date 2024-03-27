Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());
int currentGapLength = 0;
int maxGapLength = 0;
bool gapStarted = false;
string binaryRepresentation = string.Empty;

while (number > 0)
{
    int result = number % 2;
    binaryRepresentation = result.ToString() + binaryRepresentation;

    if (result == 0)
    {
        if (gapStarted)
        {
            currentGapLength++;
        }
    }
    else
    {
        if (!gapStarted)
        {
            gapStarted = true;
        }
        else
        {
            if (currentGapLength > maxGapLength)
            {
                maxGapLength = currentGapLength;
            }
            currentGapLength = 0;
        }


    }

    number = number / 2;
}


Console.WriteLine("Binary: " + binaryRepresentation);
Console.WriteLine("Longest binary gap: " + maxGapLength);