using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Prop prop;

        public MainWindow()
        {
            InitializeComponent();
            prop = new Prop();
            this.DataContext = prop;
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
