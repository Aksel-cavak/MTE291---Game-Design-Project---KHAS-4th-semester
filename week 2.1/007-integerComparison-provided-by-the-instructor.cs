/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static void Main ()
  {
	//Variable 
    string myInput= Console.ReadLine();
    
 	int x1 = Convert.ToInt32(myInput);
	
	myInput= Console.ReadLine();
	
	int x2 = Convert.ToInt32(myInput);
	//Take two input integers and print the larger one
    
    	
	myInput= Console.ReadLine();
	
	int x3 = Convert.ToInt32(myInput);
    
    bool isMiddleFound= false;
    
    if(!isMiddleFound && ((x1>=x2 && x1<=x3)||(x1<=x2 && x1>=x3))){
        
        isMiddleFound=true;
        Console.WriteLine(x1);
    }
    
    if(!isMiddleFound && ((x2>=x1 && x2<=x3)||(x2<=x1 && x2>=x3))){
        
        isMiddleFound=true;
        Console.WriteLine(x2);
    }
    
      if(!isMiddleFound && ((x3>=x1 && x3<=x2)||(x3<=x1 && x3>=x2))){
        
        isMiddleFound=true;
        Console.WriteLine(x3);
    }
    
    
    //Take three input integers and print the middle value
    //Take three input floats(double) and check whether 
    //they constitute a right triangle
      
      
  }
}
