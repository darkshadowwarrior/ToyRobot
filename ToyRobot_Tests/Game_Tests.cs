using ToyRobot;
using ToyRobot.Enums;

namespace ToyRobot_Tests;
public class Tests
{
    private Game game;
    private string _initialXCoordinate = "0";
    private string _initialYCoordinate = "0";
    private Direction _initialDirection = Direction.NORTH;
    private string[] _initialPlacement = new string[4];

    [SetUp]
    public void Setup()
    {
        game = new Game(new ToyRobot.Models.Robot(), new ToyRobot.Models.Table(), new Report());
        _initialPlacement[0] = "PLACE";
        _initialPlacement[1] = _initialYCoordinate;
        _initialPlacement[2] = _initialXCoordinate;
        _initialPlacement[3] = _initialDirection.ToString();
    }

    [Test]
    public void Assert_RobotHasBeenPlace_WithOutOfBoundsYCoordinate()
    {
        var initialYCoordinate = "6";
        var initialXCoordinate = "2";
        var initialDirection = Direction.EAST;

        var initialPlacement = new string[4]
        {
            "PLACE",
            initialYCoordinate,
            initialXCoordinate,
            initialDirection.ToString()
        };

        game.PlaceRobot(initialPlacement);
        Assert.That(!game.ReportRobotLocation().Equals("Output: 6,2,EAST"));
    }

    [Test]
    public void Assert_RobotHasBeenPlace_WithOutOfBoundsXCoordinate()
    {
        var initialYCoordinate = "2";
        var initialXCoordinate = "6";
        var initialDirection = Direction.EAST;

        var initialPlacement = new string[4]
        {
            "PLACE",
            initialYCoordinate,
            initialXCoordinate,
            initialDirection.ToString()
        };

        game.PlaceRobot(initialPlacement);
        Assert.That(!game.ReportRobotLocation().Equals("Output: 6,2,EAST"));
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
        var initialYCoordinate = "2";
        var initialXCoordinate = "1";
        var initialDirection = Direction.EAST;

        var initialPlacement = new string[4]
        {
            "PLACE",
            initialYCoordinate,
            initialXCoordinate,
            initialDirection.ToString()
        };

        game.PlaceRobot(initialPlacement);
        game.MoveRobot();
        game.MoveRobot();
        game.TurnRobotLeft();
        game.MoveRobot();
        Assert.That(game.ReportRobotLocation().Equals("Output: 3,3,NORTH"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_4_3_NORTH()
    {
        var initialYCoordinate = "2";
        var initialXCoordinate = "1";
        var initialDirection = Direction.EAST;

        var initialPlacement = new string[4]
        {
            "PLACE",
            initialYCoordinate,
            initialXCoordinate,
            initialDirection.ToString()
        };

        game.PlaceRobot(initialPlacement);
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.TurnRobotLeft();
        game.MoveRobot();
        Assert.That(game.ReportRobotLocation().Equals("Output: 4,3,NORTH"));
    }

    [Test]
    public void Assert_That_Result_Equals_Output_3_4_EAST()
    {
        var initialYCoordinate = "2";
        var initialXCoordinate = "1";
        var initialDirection = Direction.NORTH;

        var initialPlacement = new string[4]
        {
            "PLACE",
            initialYCoordinate,
            initialXCoordinate,
            initialDirection.ToString()
        };

        game.PlaceRobot(initialPlacement);
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.MoveRobot();
        game.TurnRobotRight();
        game.MoveRobot();
        Assert.That(game.ReportRobotLocation().Equals("Output: 2,4,EAST"));
    }
}