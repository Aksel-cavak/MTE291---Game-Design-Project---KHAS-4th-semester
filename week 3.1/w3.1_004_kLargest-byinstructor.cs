using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    
    List<int> myInts= new List<int>(){};

    
    int K =10; 
    
    for(int i = 0; i< K ; i++){
        myInts.Add(i*i);
    }
    
    
    int x = Convert.ToInt32(Console.ReadLine());
    
    int insertIndex=-1;
    
    for(int i = 0; i<K; i++){
        
        if(myInts[i]> x  && insertIndex == -1 ){
            
            insertIndex= i;
            
        }
        
    //0, 1 , 4, 9, 16, 25, 36, 49, 64, 81
        
    }
    
    
    myInts.Add(myInts[K-1]);
    
    for(int i = K; i>= insertIndex; i--){
    myInts[i] = myInts[i-1];
    }
    
    myInts[insertIndex] = x; 
    
    
    for(int i = 0 ; i<K+1; i ++)
    Console.WriteLine(myInts[i]);
    
    //Please insert x into myInts such that myInts remains sorted
    
    //0, 1 , 4, 9, 16, 25, 25, 36, 49, 64, 81
    
    //x = 35
    
    //0, 1 , 4, 9, 16, 25, 35 ,36, 49, 64, 81
    
    
    
    
    
    
    
    
  }
  
  
  
}