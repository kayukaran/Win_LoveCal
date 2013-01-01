using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace LoveCal
{
    public class Love
    {
        private static string sex, YName, PName; 

        public static string PName1
        {
            get { return PName; }
            set { PName = value; }
        }

        public static string YName1
        {
            get { return YName; }
            set { YName = value; }
        }

        public static string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}
