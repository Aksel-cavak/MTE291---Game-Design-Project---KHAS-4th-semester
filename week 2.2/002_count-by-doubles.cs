/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      int N = Convert.ToInt32(  Console.ReadLine() );
      
      for (int i = 0; i<=N; i++){
          
          
          if(i%2 == 0) {
              Console.WriteLine(i);
          }
          }
      
    Console.WriteLine("Hello World");
  }
}