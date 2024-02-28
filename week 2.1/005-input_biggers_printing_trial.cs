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

    string MyInput= Console.ReadLine();
    

	int input1 = Convert.ToInt32 (MyInput);
	
	MyInput= Console.ReadLine();
	
	  
	int input2 = Convert.ToInt32 (MyInput);


	if (input1 > input2)
	  {
		Console.WriteLine(input1);
	  }


	else
	  {
		Console.WriteLine(input2);
	  }



  }
}
