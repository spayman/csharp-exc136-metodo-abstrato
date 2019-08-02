namespace ExecProposto136_MetodosAbstrato.Entities
{
        abstract class  Pessoa
    {
        public string Nome { get; set; }
        public double Renda { get; set; }
        public Pessoa(string nome,double renda)
        {
            Nome = nome;
            Renda = renda;
        }
        public abstract double Imposto();        

    }
}
