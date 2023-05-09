using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2_1_Tanaka
{
    class Menu
    {
        public void Inicio()
        {
            Console.Clear();
            Console.WriteLine("¿Area de que quiere Sacar?");
            Console.WriteLine(" ");
            Console.WriteLine("1.- Rectangulo");
            Console.WriteLine("2.- Cuadrado");
            Console.WriteLine("3.- Circulo");
            Console.WriteLine("4.- Triangulo");
            Respuesta();
        }
        void Respuesta()
        {
            Figura Figura;
            int opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Escribir Base y Altura");
                    Console.WriteLine("Base:");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    float a = float.Parse(Console.ReadLine());
                    Figura = new Rectangulo(b, a);
                    Console.WriteLine($"el area de la Figura es: {Figura.Area()}");
                    Regresar();
                    break;
                case 2:
                    Console.WriteLine("Escribir Lado");
                    Console.WriteLine("Lado:");
                    float l = float.Parse(Console.ReadLine());
                    Figura = new Cuadrado(l);
                    Console.WriteLine($"el area de la Figura es: {Figura.Area()}");
                    Regresar();
                    break;
                case 3:
                    Console.WriteLine("Escribir Radio");
                    Console.WriteLine("Radio:");
                    float r = float.Parse(Console.ReadLine());
                    Figura = new Circulo(r);
                    Console.WriteLine($"el area de la Figura es: {Figura.Area()}");
                    Regresar();
                    break;
                case 4:
                    Console.WriteLine("Escribir Base y Altura");
                    Console.WriteLine("Base:");
                    float tb = float.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    float ta = float.Parse(Console.ReadLine());
                    Figura = new Triangulo(tb, ta);
                    Console.WriteLine($"el area de la Figura es: {Figura.Area()}");
                    Regresar();
                    break;
                default :
                    Console.WriteLine("Opcion no disponible");
                    Inicio();
                    break;
            }
        }
        void Regresar()
        {
            Console.WriteLine("presion 1 para volver");
            Console.WriteLine("presion 2 para terminar");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Inicio();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
