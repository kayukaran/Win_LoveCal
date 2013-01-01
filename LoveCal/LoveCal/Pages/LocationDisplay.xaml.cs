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
    public partial class LocationDisplay : PhoneApplicationPage
    {
        string[] msg;
        public LocationDisplay()
        {
            InitializeComponent(); 
            int x = CalaculateNumerlogy.getPartnerNumber();
            int y = CalaculateNumerlogy.getYourNumber();

            msg = CalculatePercentage.getPercentage(y, x, Love.Sex);

        }

        private void DisplayLocation_Loaded(object sender, RoutedEventArgs e)
        {
            
            DisplayLocation.Text = msg[2];
 
        }

        private void DisplayLocationMsg_Loaded(object sender, RoutedEventArgs e)
        {
           
            DisplayLocationMsg.Text = msg[3];
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {

            switch (msg[2])
            {
                case "Batticaloa": Batticaloa.Visibility = Visibility.Visible; break;
                case "Colombo": Colombo.Visibility = Visibility.Visible; break;
                case "Adams Peak": Adamspeak.Visibility = Visibility.Visible; break;
                case "Dambulla": Dambulla.Visibility = Visibility.Visible; break;
                case "Bentota": Bentota.Visibility = Visibility.Visible; break;
                case "Nuwara Eliya": Nuwaraeliya.Visibility = Visibility.Visible; break;
                case "Hikkaduwa": Hikkaduwa.Visibility = Visibility.Visible; break;
                case "Beruwela": Beruwala.Visibility = Visibility.Visible; break;
                case "Jaffna": Jaffna.Visibility = Visibility.Visible; break;
                case "Kurunegala": Kurunagala.Visibility = Visibility.Visible; break;
                case "Kandy": Kandy.Visibility = Visibility.Visible; break;
                case "Galle": Galle.Visibility = Visibility.Visible; break;
               


                    
            }
            

        }
    }
}