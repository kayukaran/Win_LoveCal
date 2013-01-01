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
    public class CalaculateNumerlogy
    {
        public static int getYourNumber() {

            string   yName  = Love.YName1.Trim().ToLower();
            string[] yourName = Regex.Split(yName,"(?!^)");
				
		int calculteVal = 0 ;	
		
		
		
		for (int y=0;y<yourName.Length;y++){
			if (yourName[y].Equals("a")  || yourName[y].Equals("j")  || yourName[y].Equals("s") )
			{
				calculteVal = calculteVal+1;
								
			}
			
			else {
				calculteVal = calculteVal +0;
			      }
			
			if (yourName[y].Equals("b")  || yourName[y].Equals("k")  || yourName[y].Equals("t") )
			{
				calculteVal = calculteVal+2;
				
			}
			
			else {
				calculteVal = calculteVal +0;
			      }
			
			 if (yourName[y].Equals("c")  || yourName[y].Equals("l")  || yourName[y].Equals("u") )
			{
				calculteVal = calculteVal+3;
				
			}
			 
			 else {
					calculteVal = calculteVal +0;
				      }
			
			 if (yourName[y].Equals("d")  || yourName[y].Equals("m")  || yourName[y].Equals("v") )
			{
				calculteVal = calculteVal+4;
				
			}
			 else {
					calculteVal = calculteVal +0;
				      }
			
			 if (yourName[y].Equals("e")  || yourName[y].Equals("n")  || yourName[y].Equals("w") )
			{
				calculteVal = calculteVal+5;
				
			}
			 
			 else {
					calculteVal = calculteVal +0;
				      }
			
			 if (yourName[y].Equals("f") || yourName[y].Equals("o") || yourName[y].Equals("x") )
			{
				calculteVal = calculteVal+6;
				
			}
			 
			 else {
					calculteVal = calculteVal +0;
				      }
			
			 if (yourName[y].Equals("g")  || yourName[y].Equals("p")  || yourName[y].Equals("y") )
			{
				calculteVal = calculteVal+7;
				
			}
			 
			 else {
					calculteVal = calculteVal +0;
				      }
			
			if (yourName[y].Equals("h")  || yourName[y].Equals("q")  || yourName[y].Equals("z") )
			{
				calculteVal = calculteVal+8;
				
			}
			
			else {
				calculteVal = calculteVal +0;
			      }
			
			 if (yourName[y].Equals("i")  || yourName[y].Equals("r")  )
			{
				calculteVal = calculteVal+9;
				
			}
			 
			 else {
					calculteVal = calculteVal +0;
				      }				
			
		}
		
		while (calculteVal > 9)
		{
            string val = calculteVal.ToString();
			int z = checkValue(val);
			calculteVal = z;		
					
		}
		
		
		return calculteVal;
		
	}




        public static int getPartnerNumber() {

		string pName = Love.PName1.Trim().ToLower();
        string[] partnerName = Regex.Split(pName, "(?!^)");
        int calculteYVal = 0 ;
		
		
		
		
		for (int y=0;y<partnerName.Length;y++){
			if (partnerName[y].Equals("a")  || partnerName[y].Equals("j")  || partnerName[y].Equals("s") )
			{
				calculteYVal = calculteYVal+1;
								
			}
			
			else {
				calculteYVal = calculteYVal +0;
			      }
			
			if (partnerName[y].Equals("b")  || partnerName[y].Equals("k")  || partnerName[y].Equals("t") )
			{
				calculteYVal = calculteYVal+2;
				
			}
			
			else {
				calculteYVal = calculteYVal +0;
			      }
			
			 if (partnerName[y].Equals("c")  || partnerName[y].Equals("l")  || partnerName[y].Equals("u") )
			{
				 calculteYVal = calculteYVal+3;
				
			}
			 
			 else {
				 calculteYVal = calculteYVal +0;
				      }
			
			 if (partnerName[y].Equals("d")  || partnerName[y].Equals("m")  || partnerName[y].Equals("v") )
			{
				 calculteYVal = calculteYVal+4;
				
			}
			 else {
				 calculteYVal = calculteYVal +0;
				      }
			
			 if (partnerName[y].Equals("e")  || partnerName[y].Equals("n")  || partnerName[y].Equals("w") )
			{
				 calculteYVal = calculteYVal+5;
				
			}
			 
			 else {
				 calculteYVal = calculteYVal +0;
				      }
			
			 if (partnerName[y].Equals("f") || partnerName[y].Equals("o") || partnerName[y].Equals("x") )
			{
				 calculteYVal = calculteYVal+6;
				
			}
			 
			 else {
				 calculteYVal = calculteYVal +0;
				      }
			
			 if (partnerName[y].Equals("g")  || partnerName[y].Equals("p")  || partnerName[y].Equals("y") )
			{
				 calculteYVal = calculteYVal+7;
				
			}
			 
			 else {
				 calculteYVal = calculteYVal +0;
				      }
			
			if (partnerName[y].Equals("h")  || partnerName[y].Equals("q")  || partnerName[y].Equals("z") )
			{
				calculteYVal = calculteYVal+8;
				
			}
			
			else {
				calculteYVal = calculteYVal +0;
			      }
			
			 if (partnerName[y].Equals("i")  || partnerName[y].Equals("r")  )
			{
				 calculteYVal = calculteYVal+9;
				
			}
			 
			 else {
				 calculteYVal = calculteYVal +0;
				      }		
			
			
		}
		
		
		while (calculteYVal > 9)
		{
            string val = calculteYVal.ToString();
			int z = checkValue(val);
			calculteYVal = z;		
						
		}		
		
		return calculteYVal;
			
	}





        public static int checkValue(string x)
	{
		string val = x;
		string [] value = Regex.Split(val,"(?!^)");
		int t = 0;
		for (int y=0 ;y<(value.Length-1);y++)
		{
            int yy = int.Parse(value[y]);
            t = t + yy;
		}
		
		return t;
		
	}



        
    }
}
