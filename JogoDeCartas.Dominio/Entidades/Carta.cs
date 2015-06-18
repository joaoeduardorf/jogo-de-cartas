using JogoDeCartas.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeCartas.Dominio.Entidades
{
    public class Carta
    {
        public NaipeEnum Naipe { get; set; }
        public ValorDaCartaEnum Valor { get; set; }
    }
}
