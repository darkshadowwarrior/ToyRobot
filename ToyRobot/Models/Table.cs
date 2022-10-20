namespace ToyRobot.Models
{
    public class Table
    {
        private const int MAX_XCOORDINATE = 5;
        private const int MAX_YCOORDINATE = 5;

        public bool IsValidPosition(int x, int y)
        {
            if (y < MAX_YCOORDINATE && y >= 0 && x < MAX_XCOORDINATE && x >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
