using System;
					
/*
class Persona
{
    private string _nombre;
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Edad
    {
        get { return _edad; }
        set 
        {
            if (value >= 0)
            {
                _edad = value;
            }
            else
            {
                Console.WriteLine("La edad no puede ser negativa.");
            }
        }
    }

    public string MensajeEdad()
    {
        if (_edad >= 18)
        {
            return $"¡Felicidades {Nombre}, ya eres un adulto!";
        }
        else
        {
            return $"Espera un poco más, {Nombre}.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();

        Console.Write("Ingrese su nombre: ");
        persona.Nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edadIngresada = Convert.ToInt32(Console.ReadLine());
        persona.Edad = edadIngresada;

        Console.WriteLine(persona.MensajeEdad());
    }
}
*/