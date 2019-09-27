﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double latitude1 = 0;
        private double longitude1 = 0;
        private double longitude2 = 0;
        private double longitude = 0;
        private double distance = 0;
        private double azimuth = 0;
        private Computations computations;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            computations = new Computations();
            double ans = computations.computeDistance(15.1981, -29.1068);
            Console.WriteLine(ans);
            MessageBox.Show(Convert.ToString(ans));
        }

        private void Txtbox_lat1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_distance.Text = txtbox_lat1.Text.ToString();
        }
    }
}