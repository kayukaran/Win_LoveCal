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
    public partial class Input : PhoneApplicationPage
    {
       
        public Input()
        {
            InitializeComponent();
            
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            string YName, PName;
            YName = Ynameinput.Text;
            PName = Pnameinput.Text;
            if (Validater.emptyCheck(YName))
            {
                formatDialog.Visibility = Visibility.Visible;
                dialogOutPut.Text = Resourses.Messages.InputEmpty_Message;
            }
            else
            {
                if (Validater.IsNumeric(YName))
                {
                    formatDialog.Visibility = Visibility.Visible;
                    dialogOutPut.Text = Resourses.Messages.InputNumeric_Message;
                }
                else
                {
                    if (Validater.emptyCheck(PName))
                    {
                        formatDialog.Visibility = Visibility.Visible;
                        dialogOutPut.Text = Resourses.Messages.InputEmpty_Message;
                    }
                    else
                    {
                        if (Validater.IsNumeric(PName))
                         {
                            formatDialog.Visibility = Visibility.Visible;
                            dialogOutPut.Text = Resourses.Messages.InputNumeric_Message;
                         }
                        else
                        {
                            Love.YName1 = YName;
                            Love.PName1 = PName;
                            NavigationService.Navigate(new Uri("/Pages/display.xaml", UriKind.Relative));
                        }
                    
                }
           }        
          }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formatDialog.Visibility = Visibility.Collapsed;
            Ynameinput.Text = "";
            Pnameinput.Text = "";

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            formatDialog.Visibility = Visibility.Collapsed;
            Ynameinput.Text = "";
            Pnameinput.Text = "";
        }
    }
}