using JogoDeCartas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas.ConsoleDoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho baralho = new Baralho();

            Console.WriteLine("Baralho organizado");

            foreach (var carta in baralho.Cartas)
            {
                Console.WriteLine("Naipe: " + carta.Naipe + " Valor: " + carta.Valor);
            }

            Console.ReadKey();

            Console.WriteLine("Baralho embaralhado");

            baralho.EmbaralharCartas();

            foreach (var carta in baralho.Cartas)
            {
                Console.WriteLine("Naipe: " + carta.Naipe + " Valor: " + carta.Valor);
            }

            Console.ReadKey();
        }
    }
}
