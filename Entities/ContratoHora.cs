using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Enums.Entities
{
    class ContratoHora
    {
        public DateTime Date { get; set; }
        public double ValorHora { get; set; }
        public int Hora { get; set; }

        public ContratoHora()
        {
        }

        public ContratoHora(DateTime date, double valorHora, int hora)
        {
            Date = date;
            ValorHora = valorHora;
            Hora = hora;
        }

        public double ValorTotal()
        {
            return Hora * ValorHora;
        }
    }
}
