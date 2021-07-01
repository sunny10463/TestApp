using App.ViewModels;
using SQLite;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App.Models
{
    public class Model : ViewModelBase
    {
        private string a;
        private double b;
        private double c;
        private double d;
        private double e;


        public string A
        {
            get { return a; }
            set { SetProperty(ref a, value); }
        }

        public double B
        {
            get { return b; }
            set
            {
                SetProperty(ref b, value);
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                SetProperty(ref c, value);
                UpdateTotal();
                OnPropertyChanged("E");
            }
        }

        public double D
        {
            get { return d; }
            set
            {
                SetProperty(ref d, value);
                UpdateTotal();
                OnPropertyChanged("E");
            }
        }

        private void UpdateTotal()
        {
            E = (B - C) * D;
            e = (b - c) * d;
        }

        public double E
        {
            get { return e; }
            set { SetProperty(ref e, value); }
        }
    }
}