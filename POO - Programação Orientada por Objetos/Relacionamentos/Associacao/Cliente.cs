namespace Relacionamentos
{

    class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }

        
        public Cliente()
        {
            this.nome = "Default";
            this.cpf  = "0";
        }

        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

    }

}