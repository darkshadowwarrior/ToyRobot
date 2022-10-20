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

        if (!game.IsRobotOnTable() && line[0] == "PLACE")
        {
            game.PlaceRobot(line);
        }

        if (line[0] == "REPORT")
        {
            Console.WriteLine($"Output: {game.ReportRobotLocation()}");
        }

        if (line[0] == "MOVE")
        {
            game.MoveRobot();
        }

        if (line[0] == "LEFT")
        {
            game.TurnRobotLeft();
        }

        if (line[0] == "RIGHT")
        {
            game.TurnRobotRight();
        }

        if (line[0] == "HELP")
        {
            game.Help();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("You can not go that way. Please try again");
    }
    Console.Write("What move would you like to try next \n");
}
