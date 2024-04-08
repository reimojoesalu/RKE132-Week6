string[] snacks = { "sushi", "pizza", "Burger", "chickens wings", "Asian takeaway" };

Random rnd = new Random();

int random =rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[random]}");