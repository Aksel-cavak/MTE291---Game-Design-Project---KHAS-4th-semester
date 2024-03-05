using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    
    List<int> myInts= new List<int>(){};
    
//    Console.WriteLine(myInts[0]);
  //  Console.WriteLine(myInts[1]);
//    Console.WriteLine(myInts[2]);
    
  //  myInts[1] = 5;
    int K =10; 
    
    for(int i = 0; i< K ; i++){
        myInts.Add(i);
    }
    
    //{2,2,2,...., 2}
    
    Console.WriteLine(myInts[K-1]);
    
  }
  
  
  
}