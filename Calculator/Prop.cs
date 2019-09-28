using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
