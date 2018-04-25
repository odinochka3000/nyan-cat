using System.Drawing;

namespace nyan_cat
{
    public class Platform
    {
        public Point Position { get; }
        public int Length { get; }

        public Platform(Point position, int length)
        {
            Position = position;
            Length = length;
        }
    }
}
