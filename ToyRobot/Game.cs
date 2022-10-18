namespace ToyRobot
{


    public partial class Game
    {
        private int _yCoordinate = 3;
        private int _xCoordinate = 3;
        private Direction _direction;

        public void MoveRobot()
        {
            
        }

        public void PlaceRobot(string[] @params)
        {
            _xCoordinate = int.Parse(@params[0]);
            _yCoordinate = int.Parse(@params[1]);
            _direction = ParseEnum<Direction>(@params[2]);
        }

        public string ReportRobotLocation()
        {
            return $"Output: {_xCoordinate},{_yCoordinate},{_direction.ToString()}";
        }

        public void TurnRobotLeft()
        {
            
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}