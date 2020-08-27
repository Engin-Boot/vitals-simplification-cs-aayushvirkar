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
    
   bool Bpm_Checker(float bpm)
   {
       if(bpm < 70)
       {
          Console.WriteLine("BPM is below threshold limit");
           return 0;
       }
      else if(bpm>150)
       {
          Console.WriteLine("BPM is above threshold limit");
           return 0;
      }
      Console.WriteLine("Heathy level of BPM");
      return 1;
   }
   
   bool So2_Checker(float so2)
   {
      if(so2 > 90)
      {
         return 1;
      }
      Console.WriteLine("So2 is below threshold limit");
      return 0;
   }
   
   bool RespRateChecker(float respRate)
   {
      if(respRate < 30)
      {
         Console.WriteLine("resPrate is below threshold level");
         return 0;
      }
      else if(respRate >95)
      {
         Console.WriteLine("resprate is above threshold level");
         return 0;
      }
      return 1;
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
      int x,y,z;
      x = Bpm_Checker(100);
      y = So2_Checker(95);
      z = RespRateChecker(45);
       
      if(x*y*z==1){
         Console.WriteLine("All ok");
      }
       else
       {
          Console.WriteLine("Health issue detected");
       }
       
       
        return 0;
    }
}
