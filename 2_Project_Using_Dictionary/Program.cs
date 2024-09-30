using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class MyDictionary
{
    
    public static void Main(string[] args)
    {
        MenuOptions();
        Console.ReadLine(); 
    }


    public static void MenuOptions(){

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---Options List---");
        Console.ResetColor();

        Console.WriteLine("\n1. Agregar producto\n");
       
        Console.WriteLine("2. Eliminar producto\n");
      
        Console.WriteLine("3. Buscar producto\n");
        
        Console.WriteLine("4. Salir");


        bool myMenu = true;

        while (myMenu){


        Console.Write("\nSelecciona una Opcion: ");

        string Myoptions = Console.ReadLine();

            if (Myoptions == "1"){
                Options.Option_1();
                 myMenu = false;
            }
            else if (Myoptions == "2")
            {
                Options.Option_2();
                 myMenu = false;
            }    

            else if (Myoptions == "3"){
               Options.Option_3();
                 myMenu = false;
            }  

            else if (Myoptions == "4"){
            // Mostrar Menu
            System.Console.WriteLine("El programa ha finalizado.");
            //myMenu = false;
            break;
            
            }

            else{
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Option no valid try again.");
                Console.ResetColor();
            
            }
        }

    }   


}


public class Options{
    static Dictionary<string, string> myDict = new Dictionary<string, string>(); 
    public static void Option_1(){

        System.Console.WriteLine("Agrega un Producto: ");
        string miProducto = Console.ReadLine();  

        if(miProducto.Contains(miProducto)){

            System.Console.WriteLine("El Producto ya se encuentra en el Sistma.");
        } else {
            Console.WriteLine("Producto no Encontrado.");
            myDict.Add(miProducto, miProducto);
            System.Console.WriteLine("Producto agregado correctamente.");
        }
        

    }

    public static void Option_2(){

        System.Console.WriteLine("You call Option 2");
        
    }

    public static void Option_3(){

        System.Console.WriteLine("You call 3");
    }




}


