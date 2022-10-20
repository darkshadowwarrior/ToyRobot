using ToyRobot.Enums;

namespace ToyRobot.Models
{
    public class Location
    {
        public Location(int yCoordinate, int xCoordinate, Direction currentDirection)
        {
            YCoordinate = yCoordinate;
            XCoordinate = xCoordinate;
            CurrentDirection = currentDirection;
        }

        public int YCoordinate { set; get; }
        public int XCoordinate { set; get; }
        public Direction CurrentDirection { set; get; }
    }
}