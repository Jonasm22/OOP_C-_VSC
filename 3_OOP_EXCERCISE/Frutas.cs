using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Este codigo posee bug

public class Frutas
{

    private string _NameFruit { get; set; }
    private double _Price { get; set; }

    public Frutas(string nameFruit, double price)
    {
        _NameFruit = nameFruit;
        _Price = price;
    }

    public string NameFruit
    {

        get { return _NameFruit; }
        set { _NameFruit = value; }

    }

    public double PriceFruit
    {
        get { return _Price; }
        set
        {

            if (value >= 0)
            {

                _Price = value;
                System.Console.WriteLine("Esta Fruta es no tiene precio");

            }
            else
            {

                System.Console.WriteLine("El precio de esta fruta esta a precio nomal");
            }


        }
    }



    public static void MetodoFrutas()
    {

        System.Console.WriteLine("--------------");
        System.Console.WriteLine(" ");

        Frutas manzana = new Frutas("Manzana", 0);
        System.Console.WriteLine("Nombre: " + manzana.NameFruit);
        System.Console.WriteLine("Valor al mercado: " + manzana.PriceFruit);
        //System.Console.WriteLine($"Soy una {_NameFruit} y mi precio es: €{_Price}");


        System.Console.ReadLine();



    }
}