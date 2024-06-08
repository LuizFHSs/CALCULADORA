using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Models
{
    public class CalculadoraPadrao
    {
        public static void Somar(float x, float y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void Subtrair(float x, float y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void Multiplicar(float x, float y)
        {
            Console.WriteLine($"{x} × {y} = {x * y}");
        }
        public static void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} ÷ {y} = {x / y}");
        }
    }
}