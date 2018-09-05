using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine( "Write Something" );
    string userInput =Console.ReadLine();
	char[] ArrA = userInput.ToCharArray();
	char[] ArrB = userInput.ToCharArray();
	Array.Reverse(ArrA);
	bool flag=true;
	for (int i=0;i<ArrA.Length;i++){
		if (ArrA[i]==ArrB[i]){
			flag=true;
			//return flag;
		}else{
			flag=false;;
		}
	}
	Console.WriteLine(flag);
	

    //Check(userInput);
    //Console.WriteLine(Check(userInput));

      }
    }
