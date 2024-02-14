using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Qué desea calcular? Escriba 'perimetro' o 'area':");
        string opcion = Console.ReadLine().ToLower();

        if (opcion == "perimetro")
        {
            CalcularPerimetro();
        }
        else if (opcion == "area")
        {
            CalcularArea();
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    static void CalcularPerimetro()
    {
        Console.WriteLine("Ingresar el número de lados del polígono:");
        int numLados = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresar la longitud de un lado del polígono:");
        double longitudLado = Convert.ToDouble(Console.ReadLine());

        double perimetro = numLados * longitudLado;

        Console.WriteLine($"El perímetro del polígono es: {perimetro}");
    }

    static void CalcularArea()
    {
        Console.WriteLine("Ingresar el número de lados del polígono:");
        int numLados = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresar la longitud de un lado del polígono:");
        double longitudLado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresar el apotema (la distancia del centro al centro de un lado):");
        double apotema = Convert.ToDouble(Console.ReadLine());

        double area = (numLados * longitudLado * apotema) / 2;

        Console.WriteLine($"El área del polígono es: {area}");
    }
}
