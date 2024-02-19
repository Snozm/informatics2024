using GuessingGame;
while (true)
{
    int difficulty;
    do
    {
        Console.WriteLine("Choose difficulty:\n1: 8 tries\n2: 5 tries\n3: 3 tries\n4: Escape");
        difficulty = int.Parse(Console.ReadLine());
    } while (difficulty != 1 && difficulty != 2 && difficulty != 3 && difficulty != 4);
    int tries = 0;
    switch (difficulty)
    {
        case 1:
            tries = 8;
            break;
        case 2:
            tries = 5;
            break;
        case 3:
            tries = 3;
            break;
        default:
            break;
    }
    if (tries == 0)
    {
        break;
    }
    Game game = new Game(tries);
    while (true)
    {
        int guess = 0;
        bool success;
        do
        {
            Console.WriteLine("Make a guess between 1 and 100.");
            success = int.TryParse(Console.ReadLine(), out guess);
        }while(!success || guess < 1 || guess > 100);

        Console.WriteLine(game.MakeGuess(guess));
        if (game.getTries() == 0 || game.isWin())
        {
            break;
        }
    }
    Console.WriteLine("\nNew Game!");
}