using JogoDeCartas.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas.Dominio.Entidades
{
    public class Baralho
    {
        public IList<Carta> Cartas { get; private set; }

        public Baralho()
        {
            Cartas = new List<Carta>();
            this.CriaBaralho();
        }

        private void CriaBaralho()
        {
            foreach (NaipeEnum naipe in Enum.GetValues(typeof(NaipeEnum)))
            {
                foreach (ValorDaCartaEnum valorDaCarta in Enum.GetValues(typeof(ValorDaCartaEnum)))
                {
                    Carta novaCarta = new Carta() { Naipe = naipe, Valor = valorDaCarta };
                    Cartas.Add(novaCarta);
                }
            }

        }

        public void EmbaralharCartas()
        {
            Random rand = new Random();

            this.Cartas = this.Cartas.OrderBy(c => rand.Next()).ThenByDescending(c => rand.Next()).Select(c => new Carta { Naipe = c.Naipe, Valor = c.Valor }).ToList();
        }
    }
}
