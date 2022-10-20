// See https://aka.ms/new-console-template for more information
using ToyRobot;

Game game = new Game(new ToyRobot.Models.Robot(), new ToyRobot.Models.Table(), new Report());
game.Help();

Console.Write("Please enter a command to begin \n");
while (true)
{
    try
    { 
        var line = Console.ReadLine().Split(' ');

        if (!game.IsRobotOnTable())
        {
            switch (line[0])
            {
                case "PLACE": game.PlaceRobot(line); break;
                default: Console.WriteLine("Sorry I didn't understand, please try again"); break;
            }
        } else
        {
            switch(line[0])
            {
                case "REPORT": Console.WriteLine($"Output: {game.ReportRobotLocation()}"); break;
                case "MOVE": game.MoveRobot(); break;
                case "LEFT": game.TurnRobotLeft(); break;
                case "RIGHT": game.TurnRobotRight(); break;
                case "HELP": game.Help(); break;
                default: Console.WriteLine("Sorry I didn't understand, please try again"); break;
            }
        }
        Console.Write("What move would you like to try next \n");
    }
    catch (Exception e)
    {
        Console.WriteLine("Sorry I didn't understand, please try again");
    }
}
