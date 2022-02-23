using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixacao.Enums.Entities.Enums;

namespace Fixacao.Enums.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }


        public List<ContratoHora> Contrato { get; set; } = new List<ContratoHora>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AddContrato(ContratoHora contrato)
        {
            Contrato.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contrato.Remove(contrato);
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(ContratoHora contrato in Contrato)
            {
                if(contrato.Date.Year == ano || contrato.Date.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
