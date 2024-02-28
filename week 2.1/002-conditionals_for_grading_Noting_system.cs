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

	int x1 = 5;
	int x2 = x1 + 6;			// Assignment operator

	  x2 = x2 + 1;



	double y1 = 5.0;
	double y2 = 6.0;

	string myString = "Hello World";	//immutable

	  myString = "Hello " + x1 + " Mars";

	//  Console.WriteLine (myString);




	//myString[0] = "K"; // This does not work
	//Operators

	//Arithmetic +,-,*,/

	//Logical Operators

	//&& --> and
	//||--> or
	// !  --> not

	//Comparison
	// >, < , >=, <=,

	// == , !=



	bool p = 6 != 7;
	bool q = true;

	

	//Integer division:    16/5 ==>3     16%5 ==> 1      remainder  
	//Float division:     16.0/5.0 ===> 3.2

	//Flow control

	//if, if else , if else if

    double grade= 79.0;

	if (grade>90)
	  {

		Console.WriteLine ("A");

			  } 
    else if(grade>80) { 
        Console.WriteLine("B");
		      
		  }
    else if(grade>70) { 
        Console.WriteLine("C");
    }
    else if(grade>60) { 
        Console.WriteLine("D");
        }
        
    else {
    
        Console.WriteLine("D");
        }
		  
			  
			  

    	Console.WriteLine ("This is outside the if block");


	//For, while, do while



  }
}
