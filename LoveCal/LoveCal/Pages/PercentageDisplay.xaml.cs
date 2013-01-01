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
    public partial class PercentageDisplay : PhoneApplicationPage
    {

        string[] msg;
        
        public PercentageDisplay()
        {
            InitializeComponent();
            int x = CalaculateNumerlogy.getPartnerNumber();
            int y = CalaculateNumerlogy.getYourNumber();


            msg = CalculatePercentage.getPercentage(y, x, Love.Sex);
            
        }

       
        private void Display_Loaded(object sender, RoutedEventArgs e)
        {
           
            Display.Text = msg[0];
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            switch (msg[0])
            {
                case "30%": Percentage_30_Image.Visibility = Visibility.Visible; break;
                case "35%": Percentage_35_Image.Visibility = Visibility.Visible; break;
                case "40%": Percentage_40_Image.Visibility = Visibility.Visible; break;
                case "45%": Percentage_45_Image.Visibility = Visibility.Visible; break;
                case "50%": Percentage_50_Image.Visibility = Visibility.Visible; break;
                case "55%": Percentage_55_Image.Visibility = Visibility.Visible; break;
                case "60%": Percentage_60_Image.Visibility = Visibility.Visible; break;
                case "65%": Percentage_65_Image.Visibility = Visibility.Visible; break;
                case "70%": Percentage_70_Image.Visibility = Visibility.Visible; break;
                case "75%": Percentage_75_Image.Visibility = Visibility.Visible; break;
                case "80%": Percentage_80_Image.Visibility = Visibility.Visible; break;
                case "85%": Percentage_85_Image.Visibility = Visibility.Visible; break;
                case "90%": Percentage_90_Image.Visibility = Visibility.Visible; break;
                case "95%": Percentage_95_Image.Visibility = Visibility.Visible; break;


            }

        }
    }
}