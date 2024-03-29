﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Prop : INotifyPropertyChanged
    {
        private Computations computations;
        private double latitude1 = 0;
        private double longitude1 = 0;
        private double longitude2 = 0;
        private double longitude = 0;
        private double distance = 0;
        private double azimuth = 0;
        private double c = 0;
        private double elevation = 0;
        private double slantRange = 0;
        private string elevationTest = "0";

        public Prop()
        {
            computations = new Computations();
        }

        public double Latitude1 
        {
            get { return latitude1; }
            set 
            {
                if(latitude1 != value)
                {
                    latitude1 = value;
                    
                    OnPropertyChanged();
                }
            }
        }

        public double Longitude1 {
            get { return longitude1; }
            set {
                if (longitude1 != value)
                {
                    longitude1 = value;
                    Longitude = computations.computeLongitude(value, Longitude2);
                    OnPropertyChanged();
                }
            }
        }

        public double Longitude2 {
            get { return longitude2; }
            set {
                if (longitude2 != value)
                {
                    longitude2 = value;
                    Longitude = computations.computeLongitude(Longitude1, value);
                    OnPropertyChanged();
                }
            }
        }

        public double Longitude {
            get { return longitude; }
            set {
                if (longitude != value)
                {
                    longitude = value;
                    Distance = computations.computeDistance(Latitude1, value);
                    OnPropertyChanged();
                }
            }
        }

        public double Distance {
            get { return distance; }
            set {
                if (distance != value)
                {
                    distance = value;
                    C = computations.computeC(Latitude1, value);
                    Elevation = computations.computeElevation(value);
                    SlantRange = computations.computeSlantRange(value);
                    OnPropertyChanged();
                }
            }
        }

        public double Azimuth {
            get { return azimuth; }
            set {
                if (azimuth != value)
                {
                    azimuth = value;
                    OnPropertyChanged();
                }
            }
        }

        public double C {
            get { return c; }
            set {
                if (c != value)
                {
                    c = value;
                    Azimuth = computations.computeAzimuth(value);
                    OnPropertyChanged();
                }
            }
        }

        public double Elevation
        {
            get { return elevation; }
            set
            {
                if (elevation != value)
                {
                    elevation = value;
                    ElevationTest = elevation < 0 ? "Not valid" : elevation.ToString();
                    OnPropertyChanged();
                }
            }
        }

        public string ElevationTest {
            get { return elevationTest; }
            set {
                if(elevationTest != value)
                {
                    elevationTest = value;
                    OnPropertyChanged();
                }
            }
        }

        public double SlantRange
        {
            get { return slantRange; }
            set
            {
                if (slantRange != value)
                {
                    slantRange = value;

                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
