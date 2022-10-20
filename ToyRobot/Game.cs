using ToyRobot.Enums;
using ToyRobot.Models;

namespace ToyRobot
{


    public partial class Game
    {

        private Robot _robot;
        private Report _report;
        private Table _table;
        private bool _robotPlaced = false;
        

        public Game(Robot robot, Table table, Report report)
        {
            _robot = robot;
            _report = report;
            _table = table;
        }

        public void MoveRobot()
        {
            var currentLocation = new Location(_robot.Location.YCoordinate, _robot.Location.XCoordinate, _robot.Location.CurrentDirection);

            switch (_robot.Location.CurrentDirection)
            {
                case Direction.NORTH: _robot.Location.YCoordinate += 1; break;
                case Direction.EAST: _robot.Location.XCoordinate += 1; break;
                case Direction.SOUTH: _robot.Location.YCoordinate -= 1; break;
                case Direction.WEST: _robot.Location.XCoordinate -= 1; break;
            }

            if(!_table.IsValidPosition(_robot.Location.XCoordinate, _robot.Location.YCoordinate))
            {
                _robot.Location = currentLocation;
                _report.OutOfBounds();
            }
        }

        public void PlaceRobot(string[] @params)
        {
            if(_table.IsValidPosition(int.Parse(@params[1]), int.Parse(@params[2])))
            {
                _robot.Location = new Location(int.Parse(@params[1]), int.Parse(@params[2]), ParseEnum<Direction>(@params[3]));
                _robotPlaced = true;
            } else
            {
                _report.OutOfBounds();
            }
        }

        public string ReportRobotLocation()
        {
            
            return _report.Location(_robot.Location);
        }

        public void TurnRobotLeft()
        {
            switch (_robot.Location.CurrentDirection)
            {
                case Direction.NORTH:
                    _robot.Location.CurrentDirection = Direction.WEST;
                    break;
                case Direction.EAST:
                    _robot.Location.CurrentDirection = Direction.NORTH;
                    break;
                case Direction.SOUTH:
                    _robot.Location.CurrentDirection = Direction.EAST;
                    break;
                case Direction.WEST:
                    _robot.Location.CurrentDirection = Direction.SOUTH;
                    break;
            }
        }

        public void TurnRobotRight()
        {
            switch (_robot.Location.CurrentDirection)
            {
                case Direction.NORTH:
                    _robot.Location.CurrentDirection = Direction.EAST;
                    break;
                case Direction.EAST:
                    _robot.Location.CurrentDirection = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    _robot.Location.CurrentDirection = Direction.WEST;
                    break;
                case Direction.WEST:
                    _robot.Location.CurrentDirection = Direction.NORTH;
                    break;
            }
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public bool IsRobotOnTable()
        {
            return _robotPlaced;
        }

        public void Help()
        {
            _report.Help();
        }
    }
}