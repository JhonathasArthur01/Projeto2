using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace A3 {
    internal static class Program {

        static void Main() {

             bool verdadeiro = true;

           while(verdadeiro)
           {
            Console.WriteLine("Deseja vê os dados de forma simultânia? Escolha umas das opções abaixo: ");
            Console.WriteLine("1 - Não, apenas a primeira lista de forma sequencial.");
            Console.WriteLine("2 - Não, apenas a segunda lista de forma sequencial.");
            Console.WriteLine("3 - Não, apenas a terceira lista de forma sequencial.");
            Console.WriteLine("4 - Não, apresente todas as listas de forma sequencial.");
            Console.WriteLine("5 - Sim, vê todas as listas.");
            int input = Convert.ToInt32(Console.ReadLine());

                if ( input == 1 )
                {
                   nomeEmpresa();
                }
                else if ( input == 2 )
                {
                    quantidadeEmpresa();
                }
                else if ( input == 3 )
                {
                    numerofuncionarioEmpresa();
                }
                else if ( input == 4 )
                {
                    nomeEmpresa();
                    quantidadeEmpresa();
                    numerofuncionarioEmpresa();
                }
                else if ( input == 5 )
                {
                    Parallel.Invoke(
                    new Action (nomeEmpresa),
                    new Action (quantidadeEmpresa),
                    new Action (numerofuncionarioEmpresa)
                    );
                }
                else
                {
                   Console.WriteLine("Digito invalido, digite um numero valido.");
                }  

                Console.WriteLine("Deseja realizar outra operação? 'S' para continuar ou qualquer outro caracterie pra sair do programa ");
                string continuar = Console.ReadLine();

                if (continuar.ToUpper() != "S") 
                {
                    verdadeiro = false;
                } 
           } 
        }

        static void nomeEmpresa() {
            string[] nomesArray = {"Coca-cola", "pepsi", "Guarana", "Red Bull", "Nestle", "Ambev", "Redbliss"};

            foreach(string nome in nomesArray) {
                Console.WriteLine($"Nome da empresa : {nome}");
                Thread.Sleep(2000);
            }

        }

        static void quantidadeEmpresa()
        {
            double[] quantidadeArray = { 25, 30, 50, 60, 48, 37,56};

            foreach (double quantidade in quantidadeArray)
            {
                Console.WriteLine($"quantidade de empresas : {quantidade}");
                Thread.Sleep(2000);
            }
        }

        static void numerofuncionarioEmpresa(){
            int[] numeroArray = {5000, 4500, 6000, 4700, 2500, 3200, 4100};

            foreach(int numero in numeroArray)
            {
                Console.WriteLine($"numero de funcionarios : {numero}");
                Thread.Sleep(2000);
            }

        }

    }
}
