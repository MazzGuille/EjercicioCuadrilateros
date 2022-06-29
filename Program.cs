global using static System.Console;
using EjercicioCuadrilateros.Modelos;



WriteLine("Hello, World!");

Cuadrilatero Cuadrado = new Cuadrado(4, 4);
Cuadrilatero Rectangulo = new Rectangulo(6, 4, 6, 4);
Cuadrilatero Trapecio = new Trapecio(1, 2, 3, 4, 5, 6, 7, 8);

WriteLine($"El area del Cuadrado es: {Cuadrado.CalcularArea()}\n");
WriteLine($"El area del Rectangulo es: {Rectangulo.CalcularArea()}\n");
WriteLine($"El area del Trapecio es: {Trapecio.CalcularArea()}");


