using System.Collections.Generic;
using System.Linq;  
using System;


public class Programm {


    static void Main(string[] args)
    {
        Collections2();

    }




 public static void Collections1(){

    List<char> myChar = new List<char>();   

    myChar.Add('A');
    myChar.Add('B');
    myChar.Add('C');
    myChar.Add('D');

    System.Console.WriteLine("\n");
    foreach (var MYCHAR in myChar){
    System.Console.WriteLine("IMPRIME: " +  MYCHAR);
    }
    Console.WriteLine("\n");




 }




    public static void Collections2(){
        /*
        List<char> myCharList3 = ['a', 'b', 'c', 'd'];
        myCharList3.Add('e');
        
        char[] vowels = { 'A', 'B', 'C'};
     

        char[] vowels2 = ['A', 'B', 'C'];
       

        
        System.Console.WriteLine( myCharList3);


    System.Console.WriteLine("\n");
    foreach (var MYCHAR in myCharList3){
    System.Console.WriteLine("IMPRIME: " +  MYCHAR);
    }
    Console.WriteLine("\n");
*/

List<char> myChar = ['d', 'e', 'f', 'g'];

myChar.Add('z');

 foreach (var MYCHAR in myChar){
    System.Console.WriteLine("IMPRIME: " +  MYCHAR);
    }




 }


}
