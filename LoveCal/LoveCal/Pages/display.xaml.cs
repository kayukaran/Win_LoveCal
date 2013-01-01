using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace LoveCal.Pages
{
    public partial class display : PhoneApplicationPage
    {
        Love lv;

        public display()
        {
            InitializeComponent();
            lv = new Love();
        }

       

        private void Percentage_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Resourses.Messages.button1_Message);
            NavigationService.Navigate(new Uri("/Pages/PercentageDisplay.xaml", UriKind.Relative));
        }

        private void Places_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Resourses.Messages.button3_Message);
            NavigationService.Navigate(new Uri("/Pages/LocationDisplay.xaml", UriKind.Relative));
        }

        private void CheckAnother_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Resourses.Messages.button4_Message);
            NavigationService.Navigate(new Uri("/Pages/Welcome.xaml", UriKind.Relative));
        }

        private void Message_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Resourses.Messages.button2_Message);
            NavigationService.Navigate(new Uri("/Pages/MessageDisplay.xaml", UriKind.Relative));
        }

        private void Displayname_Loaded(object sender, RoutedEventArgs e)
        {
            greetingYDisplay.Text = Love.YName1;
            greetingPDisplay.Text = Love.PName1;
        }

       

            
        
        
    }
}