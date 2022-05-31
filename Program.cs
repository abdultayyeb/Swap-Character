using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "ABCDEFGHIJKLMNOPQ";
        var characterArrayValue = name.ToCharArray();
        int limit = 0;
        while(characterArrayValue.Length > limit){
            var checkNumber = limit == 0 ? limit : characterArrayValue.Length % 2;
            string valuePrint = "";
            if(limit == 0){
                valuePrint = characterArrayValue[0].ToString() + characterArrayValue[1].ToString()
                + characterArrayValue[3].ToString()
                + characterArrayValue[2].ToString();
            }
            else{
                int limitValueAdded = limit+ 2;
                              
                if(characterArrayValue.Length > limitValueAdded){
                    if(checkNumber % 2 != 0 ){
                        int remainingValue = characterArrayValue.Length - limit;
                       
                        if(remainingValue == 3){
                            valuePrint = characterArrayValue[limit].ToString() + characterArrayValue[limit+1].ToString()                       
                        + characterArrayValue[limit+2].ToString();
                        }
                        else{
                             valuePrint = characterArrayValue[limit].ToString() + characterArrayValue[limit+1].ToString()
                        + characterArrayValue[limit+3].ToString()
                        + characterArrayValue[limit+2].ToString();
                        }
                    }
                    else{
                    valuePrint = characterArrayValue[limit].ToString() + characterArrayValue[limit+1].ToString()
                        + characterArrayValue[limit+3].ToString()
                        + characterArrayValue[limit+2].ToString();
                    }
                   
               }
               else{
                    if(checkNumber % 2 != 0){
                       valuePrint = characterArrayValue[limit].ToString();
                }
                else{
                     valuePrint = characterArrayValue[limit].ToString() + characterArrayValue[limit+1].ToString();
                     
                }                  
               }
               
              
            }
            Console.Write(valuePrint);

            limit += 4;
        }
		}
	}
}
