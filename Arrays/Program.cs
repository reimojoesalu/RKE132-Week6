
//string[] fruit = { "apples", "bananas", "oranges" };
string[] fruits = new string[3];


fruits[0] = "apples";
fruits[1] = "bananas";
fruits[2] = "oranges";
Console.WriteLine($"{fruits[0]}, {fruits[1]}, {fruits[2]}");
int fruitsArrayLength = fruits.Length;

Console.WriteLine($"There are {fruitsArrayLength} in your arry.");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruits[i] = fruits[i].Replace(fruits[i][0], char.ToUpper(fruits[i][1]));
}


foreach(string element in fruits)
 {
  Console.WriteLine( element );
}