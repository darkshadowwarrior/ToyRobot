using ToyRobot;

namespace ToyRobot_Tests;
public class Tests
{
    private Game game;
    private string _initialXCoordinate = "0";
    private string _initialYCoordinate = "0";
    private Direction _initialDirection = Direction.NORTH;
    private string[] _initialPlacement = new string[3];

    [SetUp]
    public void Setup()
    {
        game = new Game();
        _initialPlacement[0] = _initialYCoordinate;
        _initialPlacement[1] = _initialXCoordinate;
        _initialPlacement[2] = _initialDirection.ToString();
    }

    [Test]
    public void Assert_RobotHasBeenPlace_WithOutOfBoundsYCoordinate()
    {
        var initialYCoordinate = "6";
        var initialXCoordinate = "2";
        var initialDirection = Direction.EAST;

        var initialPlacement = new string[3]
        {
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

        var initialPlacement = new string[3]
        {
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

        var initialPlacement = new string[3]
        {
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
}