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
using System.Text.RegularExpressions;

namespace LoveCal
{
    public class Validater
    {
        public  static bool  emptyCheck(String text)
        {

            if (text == null || text == " " || text == "")
            {
                return true;
            }
            return false;

        }

        public static bool IsNumeric(string text)
        {
            if (Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$"))
            {
                return true;
            }
            return false;

        }

    }
}
