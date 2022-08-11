Console.WriteLine("Snake and Ladder game played with single player at start position 0");
int position = 0;
Random random = new Random();
int Dice = random.Next(1,7);
Console.WriteLine("Number on Dice is : " + Dice);
Random random2 = new Random();
int result = random2.Next(0, 3);
    if (result == 0)
    {
        Console.WriteLine("Snake");
        Console.WriteLine("Player moves behind by the number of postion recieved in the dice : " + Dice);
        position = position - Dice;
        Console.WriteLine(position);
    }
    else if (result == 1)
    {
        Console.WriteLine("Ladder");
        Console.WriteLine("Player will move ahead the number recieved on dice : " + Dice);
        position = position + Dice;
        Console.WriteLine(position);
    }
    else
    {
        Console.WriteLine("No Play");
        Console.WriteLine("Player will stay in the same position");
    }
