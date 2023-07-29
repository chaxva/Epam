namespace Iflyable

{


    public struct Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate newPoint);
    }

}
