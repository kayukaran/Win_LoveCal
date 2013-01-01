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
    public partial class MessageDisplay : PhoneApplicationPage
    {
        public MessageDisplay()
        {
            InitializeComponent();
        }

        private void Display_Loaded(object sender, RoutedEventArgs e)
        {
            int x = CalaculateNumerlogy.getPartnerNumber();
            int y = CalaculateNumerlogy.getYourNumber();


            // Display.Text = x.ToString();

            string[] msg = CalculatePercentage.getPercentage(y, x, Love.Sex);
            Display.Text = msg[1];
        }

       
    }
}