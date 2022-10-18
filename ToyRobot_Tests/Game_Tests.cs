using ToyRobot;

namespace ToyRobot_Tests;
public class Tests
{
    private Game game;


    [SetUp]
    public void Setup()
    {
        game = new Game();
    }

    [Test]
    public void Assert_That_Result_Equals_Output_0_1_NORTH()
    {
        game.PlaceRobot();
        game.MoveRobot();
        Assert.That(!game.ReportRobotLocation().Equals("Output: 0,1,NORTH"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_0_0_WEST()
    {
        game.PlaceRobot();
        game.TurnRobotLeft();
        Assert.That(!game.ReportRobotLocation().Equals("Output: 0,0,WEST"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_3_3_NORTH()
    {
        game.PlaceRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.TurnRobotLeft();
        game.MoveRobot();
        Assert.That(game.ReportRobotLocation().Equals("Output: 3,3,NORTH"));
    }
}