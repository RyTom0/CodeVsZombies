using System;
namespace CodeVsZombies
{
    class Player
    {
        static void Main(string[] args)
        {
            string[] inputs;


            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);
                int humanCount = int.Parse(Console.ReadLine());
                var humans = new Being[humanCount];


                for (int i = 0; i < humanCount; i++)
                {
                    inputs = Console.ReadLine().Split(' ');
                    int humanId = int.Parse(inputs[0]);
                    int humanX = int.Parse(inputs[1]);
                    int humanY = int.Parse(inputs[2]);
                    humans[i] = new Being(humanId, humanX, humanY);
                }


                int zombieCount = int.Parse(Console.ReadLine());
                var zombies = new Being[zombieCount];
                for (int i = 0; i < zombieCount; i++)
                {
                    inputs = Console.ReadLine().Split(' ');
                    int zombieId = int.Parse(inputs[0]);
                    int zombieX = int.Parse(inputs[1]);
                    int zombieY = int.Parse(inputs[2]);
                    int zombieXNext = int.Parse(inputs[3]);
                    int zombieYNext = int.Parse(inputs[4]);
                    zombies[i] = new Being(zombieId, zombieX, zombieY);
                }


                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                var ashNextTargetLocation = new Coordinates(0, 0);


                Console.WriteLine(ashNextTargetLocation.ToString()); // Your destination coordinates
            }
        }
    }


    public class Being
    {
        public int Id => id;
        public Coordinates Location => location;
        protected int id;
        protected Coordinates location;
        public Being(int id, int x, int y)
        {
            this.id = id;
            location = new Coordinates(x, y);
        }
    }

    public class MovingBeing : Being
    {
        public Coordinates Destination => destination;
        private Coordinates destination;

        public MovingBeing(int id, int x, int y, int nextX, int nextY)
            : base(id, x, y)
        {
            destination = new Coordinates(nextX, nextY);
        }
    }

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