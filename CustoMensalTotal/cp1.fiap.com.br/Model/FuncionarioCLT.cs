using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1.fiap.com.br.Model
{
    internal class FuncionarioCLT : Funcionario
    {
        public decimal Salario { get; set; }
        public bool CargoConfianca { get; set; }

        public FuncionarioCLT(int Codigo, string Nome, Genero Genero, decimal salario, bool cargoConfianca) : base(Codigo, Nome, Genero)
        {   
            this.Salario = salario;
            this.CargoConfianca = cargoConfianca;
        }


        

        public override decimal CalcularCustoMensal()
        {
            
            decimal Ferias = Salario * 0.11m;
            decimal Salario13 = Salario * 0.083m;
            decimal Fgts = Salario * 0.08m;
            decimal Recisao = Salario * 0.04m;
            decimal Previdenciario = Salario * 0.0793m;

            return Salario + Ferias + Salario13 + Fgts + Previdenciario + Recisao;
        }

    }
}
