using System;
using System.Collections.Generic;


namespace AlgoritmoSoftblue
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AcrescimoSalario(double percentual)
        {
            Salario = Salario + (Salario * percentual / 100);
        }

        public override string ToString()
        {
            return Id + "," + Nome + "," + Salario; 
        }

    }
}
