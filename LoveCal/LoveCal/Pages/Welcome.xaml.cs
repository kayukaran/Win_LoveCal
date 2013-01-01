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
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LoveCal.Pages
{
    public partial class Welcome : PhoneApplicationPage
    {

       
       
        public Welcome()
        {
            InitializeComponent();
                       
        }

        

      
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            formatDialog.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formatDialog.Visibility = Visibility.Collapsed;
            NavigationService.Navigate(new Uri("/Pages/Input.xaml", UriKind.Relative));

        }

        private void Rectangle_Tap1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            formatDialog.Visibility = Visibility.Visible;
            dialogOutPut.Text = Resourses.Messages.Gender_Boys_message;
            Love.Sex = "Male";
        }

        private void Rectangle_Tap2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            formatDialog.Visibility = Visibility.Visible;
            dialogOutPut.Text = Resourses.Messages.Gender_Girl_message;
            Love.Sex = "Female";
        }

       
    }
}