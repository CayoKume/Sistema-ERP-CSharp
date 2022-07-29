namespace BLL
{
    public class Pessoa
    {
        private int _id;
        private string _nome;
        private string _sobrenome;
        private string _cpf;
        private string _rg;
        private string _sexo;
        private string _email;
        private int _telefone;
        private int _celular;
        private string _conta;
        private string _agencia;
        private string _tipoConta;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Sobrenome { get { return _sobrenome; } set { _sobrenome = value; } }
        public string Cpf { get { return _cpf; } set { _cpf = value; } }
        public string Rg { get { return _rg; } set { _rg = value; } }
        public string Sexo { get { return _sexo; } set { _sexo = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public int Telefone { get { return _telefone; } set { _telefone = value; } }
        public int Celular { get { return _celular; } set { _celular = value; } }
        public string Conta { get { return _conta; } set { _conta = value; } }
        public string Agencia { get { return _agencia; } set { _agencia = value; } }
        public string TipoConta { get { return _tipoConta; } set { _tipoConta = value; } }
    }
}
