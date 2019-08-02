namespace ExecProposto136_MetodosAbstrato.Entities
{
    class PessoaFisica : Pessoa
    {        
        public double Saude { get; set; }

        public PessoaFisica(string nome,double renda, double saude):
            base(nome,renda)
        {           
            Saude = saude;        }
        public override double Imposto()
        {           
            if (Renda < 20000.00)
            {
                return (Renda * 0.15) - (Saude * 0.50);
            }
            else
            {
                return (Renda * 0.25) - (Saude * 0.50);
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
