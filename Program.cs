Console.WriteLine("Snake and Ladder game played with single player at start position 0");
int position = 0;
int count = 0;
int n = 100;
Random random = new Random();
Random random2 = new Random();
for (int i = 0; i < n; i++)
{
    while (count <= 100)
    {
        int result = random2.Next(0, 3);
        int Dice = random.Next(1, 7);
        if (position == 0)
        {
            if (result == 0)
            {
                Console.WriteLine("Snake");
                Console.WriteLine("Player moves behind by the number of postion recieved in the dice : " + Dice);
                position = position - Dice;
                Console.WriteLine("position moves back: " + position);
            }
            else if (result == 1)
            {
                Console.WriteLine("Ladder");
                Console.WriteLine("Player will move ahead the number recieved on dice : " + Dice);
                position = position + Dice;
                Console.WriteLine("player moves forward: " + position);
            }
            else
            {
                Console.WriteLine("No Play");
                Console.WriteLine("Player will stay in the same position");
            }
        }
        else if (position == 100)
        {
            Console.WriteLine("Player has won");
        }
        count++;
    }
}