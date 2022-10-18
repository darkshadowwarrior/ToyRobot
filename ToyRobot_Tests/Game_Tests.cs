using ToyRobot;

namespace ToyRobot_Tests;
public class Tests
{
    private Game game;
    private string[] _initialPlacement = new string[3] { "0", "0", "NORTH" };

    [SetUp]
    public void Setup()
    {
        game = new Game();
    }

    [Test]
    public void Assert_RobotHasBeenPlace_EqualsTrue()
    {
        game.PlaceRobot(_initialPlacement);
        Assert.That(game.ReportRobotLocation().Equals("Output: 0,0,NORTH"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_0_1_NORTH()
    {
        game.PlaceRobot(_initialPlacement);
        game.MoveRobot();
        Assert.That(game.ReportRobotLocation().Equals("Output: 0,1,NORTH"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_0_0_WEST()
    {
        game.PlaceRobot(_initialPlacement);
        game.TurnRobotLeft();
        Assert.That(game.ReportRobotLocation().Equals("Output: 0,0,WEST"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_0_0_EAST()
    {
        game.PlaceRobot(_initialPlacement);
        game.TurnRobotRight();
        Assert.That(game.ReportRobotLocation().Equals("Output: 0,0,EAST"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_3_3_NORTH()
    {
        game.PlaceRobot(_initialPlacement);
        game.MoveRobot();
        game.MoveRobot();
        game.TurnRobotLeft();
        game.MoveRobot();
        Assert.That(!game.ReportRobotLocation().Equals("Output: 3,3,NORTH"));
    }
}