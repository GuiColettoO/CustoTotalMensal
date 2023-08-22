using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1.fiap.com.br.Model
{
    internal class FuncionarioPJ : Funcionario
    {   
        public decimal ValorHora { get; set; }
        public int ValorHoraContratada { get; set; }
        public string CNPJ { get; set; }

        public FuncionarioPJ(int Codigo, string Nome, Genero Genero, decimal valorHora, int valorHoraContratada, string cnpj) : base(Codigo, Nome, Genero)
        {
            this.ValorHora = valorHora;
            this.ValorHoraContratada = valorHoraContratada;
            this.CNPJ = cnpj;
        }

        public override decimal CalcularCustoMensal(int horasExtras)
        {
            if (horasExtras < 0) { 
                throw new ArgumentException("Horas extras não podem ser negativas");
            }
                return ValorHora *  (horasExtras + ValorHoraContratada);
        }

        public override decimal CalcularCustoMensal()
        {
            return ValorHora * ValorHoraContratada;
        }

    }
}
