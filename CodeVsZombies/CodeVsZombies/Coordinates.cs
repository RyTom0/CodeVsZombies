using System;
namespace CodeVsZombies
{
    public class Coordinates
    {
        public int X => x;
        public int Y => y;
        int x;
        int y;
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x} {y}";
        }
        public int GetDistanceToCoordinate(Coordinates target)
        {
            return (int) Math.Sqrt(Math.Pow(Math.Abs(target.x - x), 2) + Math.Pow(Math.Abs(target.y - y), 2));
        }
    }
}