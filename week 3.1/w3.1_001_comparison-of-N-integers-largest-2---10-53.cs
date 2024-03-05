using System;
class HelloWorld{
  static void Main ()  {


	// ask the user for an integer N
	// ask the user for N integers
	//Print the largest among them

	  int N = Convert.ToInt32 (Console.ReadLine ());
	    Console.WriteLine ("N is " + N);

	 int currentMax = int.MinValue;

     int currentMax2 = int.MinValue;


    for (int i = 0; i < N; i++){

        

        

        int x = Convert.ToInt32(Console.ReadLine());

        if((x > currentMax) && (x > currentMax2))  {

            

            

            currentMax2 = currentMax;

            currentMax = x;

            

        }

        else if ((x < currentMax) && (x > currentMax2)){

            currentMax2 = x;

        }

        else if ((x < currentMax) && (x > currentMax2)){

            

        }

    }

    

    Console.WriteLine(currentMax + " is the biggest number");

    Console.WriteLine(currentMax2 + " is the second biggest number");

}
  }
