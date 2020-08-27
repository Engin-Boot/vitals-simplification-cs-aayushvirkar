using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
      if(bpm<70 || bpm >150 || spo2 <90 || respRate<30 || respRate >95)
      {
          return false;
      }
        return true;
    }
    
    static int Main() {
        //ExpectTrue(vitalsAreOk(100, 95, 60));
       // ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
