using System;

public class Program
{

   public  static void Check(string firstArray){
    char[] ArrA = firstArray.ToCharArray();
    char[] ArrB = new char[ArrA.Length];
    Array.Reverse(ArrA);

    for(int i = 0; i < ArrA.Length ; i++){
      if (ArrA[i] == ArrB[i]){
        Console.WriteLine( "AAAAAA" );
        //return  true;
      }else{
        Console.WriteLine( "BBBBB" );
        //return false;
      }
    }
  }

  public static void Main()
  {
    Console.WriteLine( "Write Something" );
    string userInput =Console.ReadLine();

    Check(userInput);
    //Console.WriteLine(Check(userInput));

      }
    }
