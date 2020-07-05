using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHeranca.Entidades
{
    public class ContaX : Conta
    {
        public double LimiteEmprestimo { get; set; }

        
        public ContaX(int numero, string proprietario, double saldoConta, double emprestimo) 
            : base(numero,proprietario,saldoConta)
        {
            LimiteEmprestimo = emprestimo;
        }

        public void VerificaValorEmprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                SaldoConta += valor;
            }
        }
    }
}
