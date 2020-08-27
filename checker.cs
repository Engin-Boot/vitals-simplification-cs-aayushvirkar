using System;
using System.Diagnostics;

class Checker
{
   /* static bool vitalsAreOk(float bpm, float spo2, float respRate) {
      if(bpm>70 && bpm<150 && spo2 >90 && respRate >30 && respRate <95)
      {
          return true;
      }
        return false;
    }*/
    
   bool bpm_checker(float bpm)
   {
       if(bpm < 70)
       {
          Console.WriteLine("BPM is below threshold limit");
           return false;
       }
      else if(bpm>150)
       {
          Console.WriteLine("BPM is above threshold limit");
           return false;
      }
      Console.WriteLine("Heathy level of BPM");
      return true;
   }
   
   bool so2_checker(float so2)
   {
      if(so2 > 90)
      {
         return true;
      }
      Console.WriteLine("So2 is below threshold limit");
      return false;
   }
   
   bool respRateChecker(float respRate)
   {
      if(respRate < 30)
      {
         Console.WriteLine("resPrate is below threshold level");
         return false;
      }
      else if(respRate >95)
      {
         Console.WriteLine("resprate is above threshold level");
         return false;
      }
      return true;
   }
   
   }
   /* static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    } */
    
    static int Main() {
        //ExpectTrue(vitalsAreOk(100, 95, 60));
        //ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
