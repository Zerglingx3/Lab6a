using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    //declaring arrays
    double[] celsius = new double[7];
    double[] fahrenheit = new double[7];


    //array inputs loop w/ conversion
    for (int i = 0; i < 7; i++){
    Console.WriteLine("Enter the 7 daily tempeartures in celsius");
    celsius [i] = Convert.ToDouble(Console.ReadLine());

    fahrenheit [i] = ((celsius [i] * 9) / 5) + 32;
    }  
    
    //sorting array and outputing array
    Array.Sort(fahrenheit);
    Array.Reverse(fahrenheit);
    Console.WriteLine("Temps in fahrenheit sorted High to Low");
    foreach (double x in fahrenheit)
    {
      Console.WriteLine ("Fahrenheit = " + x);
    }


    //average calculation and output
    double sum = fahrenheit.Sum(); 

    double avg = sum / 7;
    Console.WriteLine("The average temp during the week is " + avg);

  }
}