using ToyRobot.Models;

namespace ToyRobot
{
    public class Report
    {
        public string Location(Location location)
        {
            return $"Output: {location?.XCoordinate},{location?.YCoordinate},{location?.CurrentDirection.ToString()}";
        }

        public void OutOfBounds()
        {
            Console.WriteLine("This move or placement is is out of bounds, please try again");
        }

        internal void Help()
        {
            Console.WriteLine("Thank you for playing my game");
            Console.WriteLine("You can use any of the below comands to move and place a robot on the table");
            Console.WriteLine("PLACE");
            Console.WriteLine("MOVE");
            Console.WriteLine("RIGHT");
            Console.WriteLine("LEFT");
            Console.WriteLine("The PLACE command must be followed by a set of parameters consisting of x, y co-ordinates and a direction from NORTH, SOUTH, EAST or WEST");
            Console.WriteLine("You can also find the location of your robot by using the command REPORT");
            Console.WriteLine("To see this list of commands again please us the command HELP");
        }
    }
}
