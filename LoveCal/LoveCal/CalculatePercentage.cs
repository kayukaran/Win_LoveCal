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
    public class CalculatePercentage
    {
        
        static int YourNo, PartnerNo;
	    static string sx;
        public static string[] getPercentage(int YNo, int PNo, string sex)
        {

            sx = sex;
            string[] message = new string[3];
            
            

            if (sx == "Male")
            {
                YourNo = YNo;
                PartnerNo = PNo;
            }
            else
            {
                YourNo = PNo;
                PartnerNo = YNo;
            }

            if (YourNo == 1)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] {Resourses.Percentage.Message_1_1,Resourses.LoveMessage.LoveMessage_1_1,Resourses.Places.Place_1_1,Resourses.PlacesMsg.PlaceMsg_1_1 };

                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_1_2, Resourses.LoveMessage.LoveMessage_1_2, Resourses.Places.Place_1_2, Resourses.PlacesMsg.PlaceMsg_1_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_1_3, Resourses.LoveMessage.LoveMessage_1_3, Resourses.Places.Place_1_3, Resourses.PlacesMsg.PlaceMsg_1_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_1_4, Resourses.LoveMessage.LoveMessage_1_4, Resourses.Places.Place_1_4, Resourses.PlacesMsg.PlaceMsg_1_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_1_5, Resourses.LoveMessage.LoveMessage_1_5, Resourses.Places.Place_1_5, Resourses.PlacesMsg.PlaceMsg_1_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_1_6, Resourses.LoveMessage.LoveMessage_1_6, Resourses.Places.Place_1_6, Resourses.PlacesMsg.PlaceMsg_1_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_1_7, Resourses.LoveMessage.LoveMessage_1_7, Resourses.Places.Place_1_7, Resourses.PlacesMsg.PlaceMsg_1_7 };
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_1_8, Resourses.LoveMessage.LoveMessage_1_8, Resourses.Places.Place_1_8, Resourses.PlacesMsg.PlaceMsg_1_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_1_9, Resourses.LoveMessage.LoveMessage_1_9, Resourses.Places.Place_1_9, Resourses.PlacesMsg.PlaceMsg_1_9};
                }

            }

            else if (YourNo == 2)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_2_1, Resourses.LoveMessage.LoveMessage_2_1, Resourses.Places.Place_2_1, Resourses.PlacesMsg.PlaceMsg_2_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_2_2, Resourses.LoveMessage.LoveMessage_2_2, Resourses.Places.Place_2_2, Resourses.PlacesMsg.PlaceMsg_2_2};
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_2_3, Resourses.LoveMessage.LoveMessage_2_3, Resourses.Places.Place_2_3, Resourses.PlacesMsg.PlaceMsg_2_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_2_4, Resourses.LoveMessage.LoveMessage_2_4, Resourses.Places.Place_2_4, Resourses.PlacesMsg.PlaceMsg_2_4};
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_2_5, Resourses.LoveMessage.LoveMessage_2_5, Resourses.Places.Place_2_5, Resourses.PlacesMsg.PlaceMsg_2_5};
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_2_6, Resourses.LoveMessage.LoveMessage_2_6, Resourses.Places.Place_2_6, Resourses.PlacesMsg.PlaceMsg_2_6};
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_2_7, Resourses.LoveMessage.LoveMessage_2_7, Resourses.Places.Place_2_7, Resourses.PlacesMsg.PlaceMsg_2_7};
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_2_8, Resourses.LoveMessage.LoveMessage_2_8, Resourses.Places.Place_2_8, Resourses.PlacesMsg.PlaceMsg_2_8};
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_2_9, Resourses.LoveMessage.LoveMessage_2_9, Resourses.Places.Place_2_9, Resourses.PlacesMsg.PlaceMsg_2_9};

                }

            }

            else if (YourNo == 3)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_3_1, Resourses.LoveMessage.LoveMessage_3_1, Resourses.Places.Place_3_1, Resourses.PlacesMsg.PlaceMsg_3_1};
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_3_2, Resourses.LoveMessage.LoveMessage_3_2, Resourses.Places.Place_3_2, Resourses.PlacesMsg.PlaceMsg_3_2};
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_3_3, Resourses.LoveMessage.LoveMessage_3_3, Resourses.Places.Place_3_3, Resourses.PlacesMsg.PlaceMsg_3_3};

                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_3_4, Resourses.LoveMessage.LoveMessage_3_4, Resourses.Places.Place_3_4, Resourses.PlacesMsg.PlaceMsg_3_4};

                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_3_5, Resourses.LoveMessage.LoveMessage_3_5, Resourses.Places.Place_3_5, Resourses.PlacesMsg.PlaceMsg_3_5};

                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_3_6, Resourses.LoveMessage.LoveMessage_3_6, Resourses.Places.Place_3_6, Resourses.PlacesMsg.PlaceMsg_3_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_3_7, Resourses.LoveMessage.LoveMessage_3_7, Resourses.Places.Place_3_7, Resourses.PlacesMsg.PlaceMsg_3_7};
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_3_8, Resourses.LoveMessage.LoveMessage_3_8, Resourses.Places.Place_3_8, Resourses.PlacesMsg.PlaceMsg_3_8};

                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_3_9, Resourses.LoveMessage.LoveMessage_3_9, Resourses.Places.Place_3_9, Resourses.PlacesMsg.PlaceMsg_3_9};
                }

            }

            else if (YourNo == 4)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_4_1, Resourses.LoveMessage.LoveMessage_4_1, Resourses.Places.Place_4_1, Resourses.PlacesMsg.PlaceMsg_4_1};
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_4_2, Resourses.LoveMessage.LoveMessage_4_2, Resourses.Places.Place_4_2, Resourses.PlacesMsg.PlaceMsg_4_2};
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_4_3, Resourses.LoveMessage.LoveMessage_4_3, Resourses.Places.Place_4_3, Resourses.PlacesMsg.PlaceMsg_4_3};
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_4_4, Resourses.LoveMessage.LoveMessage_4_4, Resourses.Places.Place_4_4, Resourses.PlacesMsg.PlaceMsg_4_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_4_5, Resourses.LoveMessage.LoveMessage_4_5, Resourses.Places.Place_4_5, Resourses.PlacesMsg.PlaceMsg_4_5};
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_4_6, Resourses.LoveMessage.LoveMessage_4_6, Resourses.Places.Place_4_6, Resourses.PlacesMsg.PlaceMsg_4_6};

                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_4_7, Resourses.LoveMessage.LoveMessage_4_7, Resourses.Places.Place_4_7, Resourses.PlacesMsg.PlaceMsg_4_7 };
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_4_8, Resourses.LoveMessage.LoveMessage_4_8, Resourses.Places.Place_4_8, Resourses.PlacesMsg.PlaceMsg_4_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_4_9, Resourses.LoveMessage.LoveMessage_4_9, Resourses.Places.Place_4_9, Resourses.PlacesMsg.PlaceMsg_4_9 };
                }

            }

            else if (YourNo == 5)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_5_1, Resourses.LoveMessage.LoveMessage_5_1, Resourses.Places.Place_5_1, Resourses.PlacesMsg.PlaceMsg_5_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_5_2, Resourses.LoveMessage.LoveMessage_5_2, Resourses.Places.Place_5_2, Resourses.PlacesMsg.PlaceMsg_5_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_5_3, Resourses.LoveMessage.LoveMessage_5_3, Resourses.Places.Place_5_3, Resourses.PlacesMsg.PlaceMsg_5_3};
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_5_4, Resourses.LoveMessage.LoveMessage_5_4, Resourses.Places.Place_5_4, Resourses.PlacesMsg.PlaceMsg_5_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_5_5, Resourses.LoveMessage.LoveMessage_5_5, Resourses.Places.Place_5_5, Resourses.PlacesMsg.PlaceMsg_5_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_5_6, Resourses.LoveMessage.LoveMessage_5_6, Resourses.Places.Place_5_6, Resourses.PlacesMsg.PlaceMsg_5_6 };

                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_5_7, Resourses.LoveMessage.LoveMessage_5_7, Resourses.Places.Place_5_7, Resourses.PlacesMsg.PlaceMsg_5_7};
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_5_8, Resourses.LoveMessage.LoveMessage_5_8, Resourses.Places.Place_5_8, Resourses.PlacesMsg.PlaceMsg_5_8};
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_5_9, Resourses.LoveMessage.LoveMessage_5_9, Resourses.Places.Place_5_9, Resourses.PlacesMsg.PlaceMsg_5_9};
                }

            }

            else if (YourNo == 6)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_6_1, Resourses.LoveMessage.LoveMessage_6_1, Resourses.Places.Place_6_1, Resourses.PlacesMsg.PlaceMsg_6_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_6_2, Resourses.LoveMessage.LoveMessage_6_2, Resourses.Places.Place_6_2, Resourses.PlacesMsg.PlaceMsg_6_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_6_3, Resourses.LoveMessage.LoveMessage_6_3, Resourses.Places.Place_6_3, Resourses.PlacesMsg.PlaceMsg_6_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_6_4, Resourses.LoveMessage.LoveMessage_6_4, Resourses.Places.Place_6_4, Resourses.PlacesMsg.PlaceMsg_6_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_6_5, Resourses.LoveMessage.LoveMessage_6_5, Resourses.Places.Place_6_5, Resourses.PlacesMsg.PlaceMsg_6_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_6_6, Resourses.LoveMessage.LoveMessage_6_6, Resourses.Places.Place_6_6, Resourses.PlacesMsg.PlaceMsg_6_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_6_7, Resourses.LoveMessage.LoveMessage_6_7, Resourses.Places.Place_6_7, Resourses.PlacesMsg.PlaceMsg_6_7 };
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_6_8, Resourses.LoveMessage.LoveMessage_6_8, Resourses.Places.Place_6_8, Resourses.PlacesMsg.PlaceMsg_6_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_6_9, Resourses.LoveMessage.LoveMessage_6_9, Resourses.Places.Place_6_9, Resourses.PlacesMsg.PlaceMsg_6_9 };
                }

            }

            else if (YourNo == 7)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_7_1, Resourses.LoveMessage.LoveMessage_7_1, Resourses.Places.Place_7_1, Resourses.PlacesMsg.PlaceMsg_7_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_7_2, Resourses.LoveMessage.LoveMessage_7_2, Resourses.Places.Place_7_2, Resourses.PlacesMsg.PlaceMsg_7_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_7_3, Resourses.LoveMessage.LoveMessage_7_3, Resourses.Places.Place_7_3, Resourses.PlacesMsg.PlaceMsg_7_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_7_4, Resourses.LoveMessage.LoveMessage_7_4, Resourses.Places.Place_7_4, Resourses.PlacesMsg.PlaceMsg_7_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_7_5, Resourses.LoveMessage.LoveMessage_7_5, Resourses.Places.Place_7_5, Resourses.PlacesMsg.PlaceMsg_7_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_7_6, Resourses.LoveMessage.LoveMessage_7_6, Resourses.Places.Place_7_6, Resourses.PlacesMsg.PlaceMsg_7_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_7_7, Resourses.LoveMessage.LoveMessage_7_7, Resourses.Places.Place_7_7, Resourses.PlacesMsg.PlaceMsg_7_7 };
                }

                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_7_8, Resourses.LoveMessage.LoveMessage_7_8, Resourses.Places.Place_7_8, Resourses.PlacesMsg.PlaceMsg_7_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_7_9, Resourses.LoveMessage.LoveMessage_7_9, Resourses.Places.Place_7_9, Resourses.PlacesMsg.PlaceMsg_7_9 };
                }

            }

            else if (YourNo == 8)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_8_1, Resourses.LoveMessage.LoveMessage_8_1, Resourses.Places.Place_8_1, Resourses.PlacesMsg.PlaceMsg_8_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_8_2, Resourses.LoveMessage.LoveMessage_8_2, Resourses.Places.Place_8_2, Resourses.PlacesMsg.PlaceMsg_8_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_8_3, Resourses.LoveMessage.LoveMessage_8_3, Resourses.Places.Place_8_3, Resourses.PlacesMsg.PlaceMsg_8_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_8_4, Resourses.LoveMessage.LoveMessage_8_4, Resourses.Places.Place_8_4, Resourses.PlacesMsg.PlaceMsg_8_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_8_5, Resourses.LoveMessage.LoveMessage_8_5, Resourses.Places.Place_8_5, Resourses.PlacesMsg.PlaceMsg_8_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_8_6, Resourses.LoveMessage.LoveMessage_8_6, Resourses.Places.Place_8_6, Resourses.PlacesMsg.PlaceMsg_8_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_8_7, Resourses.LoveMessage.LoveMessage_8_7, Resourses.Places.Place_8_7, Resourses.PlacesMsg.PlaceMsg_8_7 };
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_8_8, Resourses.LoveMessage.LoveMessage_8_8, Resourses.Places.Place_8_8, Resourses.PlacesMsg.PlaceMsg_8_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_8_9, Resourses.LoveMessage.LoveMessage_8_9, Resourses.Places.Place_8_9, Resourses.PlacesMsg.PlaceMsg_8_9};
                }

            }

            else if (YourNo == 9)
            {
                if (PartnerNo == 1)
                {
                    message = new string[] { Resourses.Percentage.Message_9_1, Resourses.LoveMessage.LoveMessage_9_1, Resourses.Places.Place_9_1, Resourses.PlacesMsg.PlaceMsg_9_1 };
                }
                else if (PartnerNo == 2)
                {
                    message = new string[] { Resourses.Percentage.Message_9_2, Resourses.LoveMessage.LoveMessage_9_2, Resourses.Places.Place_9_2, Resourses.PlacesMsg.PlaceMsg_9_2 };
                }
                else if (PartnerNo == 3)
                {
                    message = new string[] { Resourses.Percentage.Message_9_3, Resourses.LoveMessage.LoveMessage_9_3, Resourses.Places.Place_9_3, Resourses.PlacesMsg.PlaceMsg_9_3 };
                }
                else if (PartnerNo == 4)
                {
                    message = new string[] { Resourses.Percentage.Message_9_4, Resourses.LoveMessage.LoveMessage_9_4, Resourses.Places.Place_9_4, Resourses.PlacesMsg.PlaceMsg_9_4 };
                }
                else if (PartnerNo == 5)
                {
                    message = new string[] { Resourses.Percentage.Message_9_5, Resourses.LoveMessage.LoveMessage_9_5, Resourses.Places.Place_9_5, Resourses.PlacesMsg.PlaceMsg_9_5 };
                }
                else if (PartnerNo == 6)
                {
                    message = new string[] { Resourses.Percentage.Message_9_6, Resourses.LoveMessage.LoveMessage_9_6, Resourses.Places.Place_9_6, Resourses.PlacesMsg.PlaceMsg_9_6 };
                }
                else if (PartnerNo == 7)
                {
                    message = new string[] { Resourses.Percentage.Message_9_7, Resourses.LoveMessage.LoveMessage_9_7, Resourses.Places.Place_9_7, Resourses.PlacesMsg.PlaceMsg_9_7 };
                }
                else if (PartnerNo == 8)
                {
                    message = new string[] { Resourses.Percentage.Message_9_8, Resourses.LoveMessage.LoveMessage_9_8, Resourses.Places.Place_9_8, Resourses.PlacesMsg.PlaceMsg_9_8 };
                }
                else if (PartnerNo == 9)
                {
                    message = new string[] { Resourses.Percentage.Message_9_9, Resourses.LoveMessage.LoveMessage_9_9, Resourses.Places.Place_9_9, Resourses.PlacesMsg.PlaceMsg_9_9 };
                }

            }




            return message;


        }

    }

}
