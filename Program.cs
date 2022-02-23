using System;
using Fixacao.Enums.Entities.Enums;
using Fixacao.Enums.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Fixacao.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string nomeDep = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel: (Junior, Pleno, Senior) : ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salario base: ");
            double salariobase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dep = new Departamento(nomeDep);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salariobase, dep);

            Console.Write("Quantos contratos tem esse trabalhador: ");
            int contrato = int.Parse(Console.ReadLine());

            for(int i = 1; i <= contrato; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Contrato numero {i}#");
                Console.Write("Data(DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração/horas: ");
                int hora = int.Parse(Console.ReadLine());
                ContratoHora contratoHora = new ContratoHora(data, valorHora, hora);

                trabalhador.AddContrato(contratoHora);
            }
            Console.WriteLine();
            Console.WriteLine("Entre com o mes e ano para o calculo da renda(MM/AAAA):");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento);
            Console.WriteLine("Renda: " + mesEano + trabalhador.Renda(ano, mes).ToString("F2", CultureInfo.InvariantCulture)); ;




        }
    }
}
