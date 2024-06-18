using System;

namespace PlayerTrackingLibrary
{
    public class Location
    {
        public DateTime Time { get; }
        public int X { get; }
        public int Y { get; }

        public Location(int x, int y)
        {
            Time = DateTime.Now;
            X = x;
            Y = y;
        }
    }
}
