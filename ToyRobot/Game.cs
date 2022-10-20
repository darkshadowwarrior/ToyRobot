using ToyRobot.Enums;
using ToyRobot.Models;

namespace ToyRobot
{


    public partial class Game
    {

        private Robot _robot;
        private const int MAX_XCOORDINATE = 5; 
        private const int MAX_YCOORDINATE = 5;

        public Game()
        {
            _robot = new Robot();
        }

        public void MoveRobot()
        {
            var currentLocation = new Location(_robot.Location.YCoordinate, _robot.Location.XCoordinate, _robot.Location.CurrentDirection);

            switch ((int)_robot.Location.CurrentDirection)
            {
                case 1: _robot.Location.YCoordinate += 1; break;
                case 2: _robot.Location.XCoordinate += 1; break;
                case 3: _robot.Location.YCoordinate -= 1; break;
                case 4: _robot.Location.XCoordinate -= 1; break;
            }

            if(!IsValidPosition(_robot.Location.XCoordinate, _robot.Location.YCoordinate))
            {
                _robot.Location = currentLocation;
            }
        }

        public bool IsValidPosition(int x, int y)
        {
            if(y < MAX_YCOORDINATE && y >= 0 && x < MAX_XCOORDINATE && x >= 0)
            {
                return true;
            }

            return false;
        }

        public void PlaceRobot(string[] @params)
        {
            if(IsValidPosition(int.Parse(@params[0]), int.Parse(@params[1])))
            {
                _robot.Location = new Location(int.Parse(@params[0]), int.Parse(@params[1]), ParseEnum<Direction>(@params[2]));
            }
        }

        public string ReportRobotLocation()
        {
            return $"Output: {_robot.Location?.XCoordinate},{_robot.Location?.YCoordinate},{_robot.Location?.CurrentDirection.ToString()}";
        }

        public void TurnRobotLeft()
        {
            switch ((int)_robot.Location.CurrentDirection)
            {
                case 1:
                    _robot.Location.CurrentDirection = Direction.WEST;
                    break;
                case 2:
                    _robot.Location.CurrentDirection = Direction.NORTH;
                    break;
                case 3:
                    _robot.Location.CurrentDirection = Direction.EAST;
                    break;
                case 4:
                    _robot.Location.CurrentDirection = Direction.SOUTH;
                    break;
            }
        }

        public void TurnRobotRight()
        {
            switch ((int)_robot.Location.CurrentDirection)
            {
                case 1:
                    _robot.Location.CurrentDirection = Direction.EAST;
                    break;
                case 2:
                    _robot.Location.CurrentDirection = Direction.SOUTH;
                    break;
                case 3:
                    _robot.Location.CurrentDirection = Direction.WEST;
                    break;
                case 4:
                    _robot.Location.CurrentDirection = Direction.NORTH;
                    break;
            }
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}