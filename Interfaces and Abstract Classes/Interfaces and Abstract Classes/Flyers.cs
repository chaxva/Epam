using Iflyable;


namespace Flyers

{


    public class Bird : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;

        public Bird(Coordinate initialPosition)
        {
            currentPosition = initialPosition;
            speed = new Random().Next(0, 21); // Random speed between 0 and 20 km/h
        }

        public void FlyTo(Coordinate newPoint)
        {
            currentPosition = newPoint;
            Console.WriteLine("Bird is flying to the new point.");
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = CalculateDistance(currentPosition, newPoint);
            double time = distance / speed;
            return time;
        }

        private double CalculateDistance(Coordinate point1, Coordinate point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.Y - point1.Y;
            double deltaZ = point2.Z - point1.Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }

    public class Airplane : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;

        public Airplane(Coordinate initialPosition)
        {
            currentPosition = initialPosition;
            speed = 200; // Initial speed of 200 km/h
        }

        public void FlyTo(Coordinate newPoint)
        {
            currentPosition = newPoint;
            Console.WriteLine("Airplane is flying to the new point.");
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = CalculateDistance(currentPosition, newPoint);
            double time = 0;
            while (distance > 0)
            {
                if (distance >= 10)
                {
                    time += 10 / speed;
                    speed += 10; // Increase speed by 10 km/h every 10 km
                    distance -= 10;
                }
                else
                {
                    time += distance / speed;
                    distance = 0;
                }
            }
            return time;
        }

        private double CalculateDistance(Coordinate point1, Coordinate point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.Y - point1.Y;
            double deltaZ = point2.Z - point1.Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }

    public class Drone : IFlyable
    {
        private Coordinate currentPosition;

        public Drone(Coordinate initialPosition)
        {
            currentPosition = initialPosition;
        }

        public void FlyTo(Coordinate newPoint)
        {
            double distance = CalculateDistance(currentPosition, newPoint);
            if (distance > 1000)
            {
                Console.WriteLine("Drone cannot fly beyond a distance of 1000 km.");
                return;
            }
            currentPosition = newPoint;
            Console.WriteLine("Drone is flying to the new point.");
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = CalculateDistance(currentPosition, newPoint);
            double time = distance / 60; // Assuming speed of 1 km/min
            double hoverTime = Math.Floor(time / 10) * 1; // 1 minute of hovering for every 10 minutes of flight
            time += hoverTime;
            return time;
        }

        private double CalculateDistance(Coordinate point1, Coordinate point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.Y - point1.Y;
            double deltaZ = point2.Z - point1.Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }

}
