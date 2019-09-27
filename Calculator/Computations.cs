using System;

namespace Calculator
{
    public class Computations
    {
        public double computeLongitude(double longitude1, double longitude2)
        {
            return longitude1 - longitude2;
        }

        public double computeDistance(double latitude1, double longitude)
        {
            return convertToDegrees(Math.Acos(Math.Cos(convertToRadians(latitude1)) * Math.Cos(convertToRadians(longitude))));
        }

        public double computeC(double latitude1, double distance)
        {
            return convertToDegrees(Math.Acos(-Math.Tan(convertToRadians(latitude1))/Math.Tan(convertToRadians(distance))));
        }

        public double computeAzimuth(double C)
        {
            return 360 - C;
        }
        public double convertToDegrees(double val)
        {
            return (180 / Math.PI) * val;
        }

        public double convertToRadians(double degreeVal)
        {
            return Math.PI * degreeVal / 180;
        }
        

    }
}
