namespace Classes
{
    public class Usuario : Pessoa
    {
        private string _login;
        private string _senha;

        public string Login { get { return _login; } set { _login = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } }
    }
}
