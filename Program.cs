using System;
using System.Collections.Generic;
using System.Globalization;

namespace AlgoritmoSoftblue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estudante[] vetor = new Estudante[10];

            //Console.WriteLine("Quantos quartos serão alugados?");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Aluguel #{i}.");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Quarto: ");
            //    int quarto = int.Parse(Console.ReadLine());
            //    vetor[quarto] = new Estudante(nome, email);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Quartos ocupados");
            //for (int i = 1; i < 10; i++)
            //{
            //    if (vetor[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + vetor[i]);
            //    }
            //}

           
            //------------------------------------------------------------------------------------------------------

            //Matriz
            
            //string[] line = Console.ReadLine().Split(' ');
            //int m = int.Parse(line[0]);
            //int n = int.Parse(line[0]);

            //int[,] mat = new int[m, n];

            //for (int i = 0; i < m; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mat[i, j] == x)
            //        {
            //            Console.WriteLine("Position " + i + "," + j + ":");
            //            if (j > 0)
            //            {
            //                Console.WriteLine("Left: " + mat[i, j - 1]);
            //            }
            //            if (i > 0)
            //            {
            //                Console.WriteLine("Up: " + mat[i - 1, j]);
            //            }
            //            if (j < n - 1)
            //            {
            //                Console.WriteLine("Right: " + mat[i, j + 1]);
            //            }
            //            if (i < m - 1)
            //            {
            //                Console.WriteLine("Down: " + mat[i + 1, j]);
            //            }
            //        }
            //    }
            //}
            //-------------------------------------------------------------------------------------------------


            Console.WriteLine("Digite a qauntidade de funcionarios");
            int n = int.Parse(Console.ReadLine());
            //declaro a lista/ instancio ela
            List<Funcionarios> lista = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionairo #" + i);
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                // Guardo os registros na lista (id,nome, salario)
                lista.Add(new Funcionarios(id, nome, salario));
            }
            Console.WriteLine("Digite o Id do funcionario que receberá o aumento");
            int idFunc = int.Parse(Console.ReadLine());

            //instancio a classe funcionarios usando o x para percorrer e achar o id (lista.Find) e usardo na variavel infunc
            Funcionarios empresa = lista.Find(x => x.Id == idFunc);
            if (empresa != null)
            {
                Console.WriteLine("quantos porcento");
                double porcentagem = double.Parse(Console.ReadLine());
                //chamoo metodo de porcentagem 
                empresa.AcrescimoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("esse id nao existe");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizaçao dos funcionarios");

            //percorro toda lista funcionario, atualizando os registros
            foreach(Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
