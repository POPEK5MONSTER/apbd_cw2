// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Siema to ja koszykarz.");
Console.WriteLine("No witam witam!");

static double GetAverage(int [] number)
{
    double result = 0.0;
    for (int i = 0; i < number.Length; i++)
    {
        result += number[i];
    }

    return result / number.Length;
}

int[] number = {1, 2, 3, 4};
double avg = GetAverage(number);
Console.WriteLine(avg);
