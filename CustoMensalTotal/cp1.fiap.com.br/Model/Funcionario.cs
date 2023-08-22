using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cp1.fiap.com.br.Model
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Genero Genero { get; set; }

        public Funcionario(int codigo, string nome, Genero genero)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Genero = genero;
        }
        public virtual decimal CalcularCustoMensal()
        {
            return 0m;
        }

        public virtual decimal CalcularCustoMensal(int horasExtras)
        {
            return 0m;
        }

    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}
