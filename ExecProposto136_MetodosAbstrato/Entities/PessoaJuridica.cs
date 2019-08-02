using System;
using System.Collections.Generic;
using System.Text;

namespace ExecProposto136_MetodosAbstrato.Entities
{
     class PessoaJuridica : Pessoa
    {        
        public int QtdFuncionarios { get; set; }
        public PessoaJuridica(string nome,double renda, int qtdFuncionarios):
            base(nome,renda)
        {           
            QtdFuncionarios = qtdFuncionarios;
        }
        public override double Imposto()
        {
            if (QtdFuncionarios > 10)
            {
                return Renda * 0.14;
            }
            else
            {
                return Renda * 0.16;
            }            
        }        
        public override string ToString()
        {
            return Nome
                + " : $ " 
                + Imposto();
        }
    }
}
