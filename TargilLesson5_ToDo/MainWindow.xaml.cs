using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TargilLesson5_ToDo
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private double  carPosition;   //will keep the current position of the car
      public MainWindow()
      {
         InitializeComponent();
         carPosition = ImageCar.Margin.Left; //get the starting posotion of the car
      }

      private void ButtonRedLight_Click(object sender, RoutedEventArgs e)
      {
         ImageSlowDown.Visibility = Visibility.Hidden;
         MessageBox.Show("BRAKES !!");
      }

      private void ButtonGreenLight_Click(object sender, RoutedEventArgs e)
      {
         //Thickness(double left, double top, double right, double bottom);
         carPosition -= 100; 
         ImageCar.Margin = new Thickness(carPosition, 263, 0, 0);
      }

      private void ButtonYellowLight_Click(object sender, RoutedEventArgs e)
      {
         //have the car slow down and go a little bit
         carPosition -= 30;
         ImageCar.Margin = new Thickness(carPosition, 263, 0, 0);
        
         ImageSlowDown.Visibility=Visibility.Visible;
         MessageBox.Show("slowing down !!");
      }
   }
}
