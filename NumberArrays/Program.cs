using System.Diagnostics.CodeAnalysis;

int[] number = new int[10];
Random rnd = new Random();

//populating the array
for (int i = 0; i < number.Length; i++)
{
    number[i] = rnd.Next(1, number.Length +1);
    int sum = 0;
    sum = sum + number[i];
}

foreach (int i in number)
{
    Console.WriteLine(number);
}
Console.WriteLine($"Total: {sum}");
