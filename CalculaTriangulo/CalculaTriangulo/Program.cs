using System;
using System.Globalization;

namespace CalculaTriangulo {
    class Program {
        static void Main(string[] args) {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do primeiro triangulo: ");
            Console.Write("Lado a do triangulo x: ");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b do triangulo x: ");
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c do triangulo x: ");
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do segundo triangulo: ");
            Console.Write("Lado a do triangulo y: ");
            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b do triangulo y: ");
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c do triangulo y: ");
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("A área do triangulo x é de " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triangulo y é de " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("A maior área é a do triangulo X.");
            } else if (areaX == areaY) {
                Console.WriteLine("Os dois triangulos tem a mesma área.");
            } else {
                Console.WriteLine("A maior área é a do triangulo Y.");
            }
        }
    }
}
