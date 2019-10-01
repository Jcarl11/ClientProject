using System;

namespace Calculator
{
    public class Computations
    {
        private const double Rs_in_nautical = 22766;
        private const double Rs_in_Km = 42166;

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
        public double computeElevation(double distance)
        {
            return convertToDegrees(Math.Atan((Math.Cos(convertToRadians(distance)) - (1 / 6.61)) / Math.Sqrt(1 - Math.Pow(Math.Cos(convertToRadians(distance)), 2))));
        }

        public double convertToDegrees(double val)
        {
            return (180 / Math.PI) * val;
        }

        public double convertToRadians(double degreeVal)
        {
            return Math.PI * degreeVal / 180;
        }
        
        public double computeSlantRange(double distance)
        {
            return Math.Sqrt(1 - 2 * (1 / 6.61) * Math.Cos(convertToRadians(distance)) + Math.Pow(1 / 6.61, 2)) * Rs_in_nautical;
        }
    }
}
