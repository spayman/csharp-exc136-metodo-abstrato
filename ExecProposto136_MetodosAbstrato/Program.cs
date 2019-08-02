using System;
using System.Globalization;
using ExecProposto136_MetodosAbstrato.Entities;
using System.Collections.Generic;

namespace ExecProposto136_MetodosAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> Pessoa = new List<Pessoa>();
            Console.Write("Informe o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}º contribuite: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("É pessoa fisica ou juridica (f/j)?: ");
                char tipo = char.Parse(Console.ReadLine());
                
                if (tipo == 'f')
                {
                    Console.Write("Gasto com saúde: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Pessoa.Add(new PessoaFisica(nome, renda, saude));
                }
                else
                {
                    Console.Write("Número de funcionarios: ");
                    int qtdFuncionarios = int.Parse(Console.ReadLine());
                    Pessoa.Add(new PessoaJuridica(nome, renda, qtdFuncionarios));
                }
            }

            double soma = 0.0;
            Console.WriteLine();
            Console.WriteLine("Imposto pago por contribuinte:");
            foreach (Pessoa pessoa in Pessoa)
            {
                Console.WriteLine(pessoa.ToString());
                soma += pessoa.Imposto();
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Total de imposto arecadado:");
            Console.WriteLine(" $ {0}", soma.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
