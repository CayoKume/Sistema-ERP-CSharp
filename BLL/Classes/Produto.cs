namespace Classes
{
    public class Produto
    {
        private int _id;
        private string _descricao;
        private string _referencia;
        private string _classe;
        private string _fornecedor;
        private string _categoria;
        private string _tipo;
        private string _status;
        private decimal _precoCompra;
        private decimal _precoVenda;
        private decimal _precoCompraImposto;
        private decimal _margemLucro;
        private decimal _estoqueDisponivel;
        private decimal _estoqueMinimo;
        private decimal _estoqueMaximo;
        private decimal _estoqueVinculado;
        private decimal _estoquePrevisto;
        private char _unidade;
        private decimal _largura;
        private decimal _altura;
        private decimal _comprimento;
        private decimal _peso;

        public int Id { get { return _id; } set { _id = value; } }
        public string Descricao { get { return _descricao; } set { _descricao = value; } }
        public string Referencia { get { return _referencia; } set { _referencia = value; } }
        public string Classe { get { return _classe; } set { _classe = value; } }
        public string Fornecedor { get { return _fornecedor; } set { _fornecedor = value; } }
        public string Categoria { get { return _categoria; } set { _categoria = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public decimal PrecoCompra { get { return _precoCompra; } set { _precoCompra = value; } }
        public decimal PrecoVenda { get { return _precoVenda; } set { _precoVenda = value; } }
        public decimal PrecoCompraImposto { get { return _precoCompraImposto; } set { _precoCompraImposto = value; } }
        public decimal MargemLucro { get { return _margemLucro; } set { _margemLucro = value; } }
        public decimal EstoqueDisponivel { get { return _estoqueDisponivel; } set { _estoqueDisponivel = value; } }
        public decimal EstoqueMinimo { get { return _estoqueMinimo; } set { _estoqueMinimo = value; } }
        public decimal EstoqueMaximo { get { return _estoqueMaximo; } set { _estoqueMaximo = value; } }
        public decimal EstoqueVinculado { get { return _estoqueVinculado; } set { _estoqueVinculado = value; } }
        public decimal EstoquePrevisto { get { return _estoquePrevisto; } set { _estoquePrevisto = value; } }
        public char Unidade { get { return _unidade; } set { _unidade = value; } }
        public decimal Largura { get { return _largura; } set { _largura = value; } }
        public decimal Altura { get { return _altura; } set { _altura = value; } }
        public decimal Comprimento { get { return _comprimento; } set { _comprimento = value; } }
        public decimal Peso { get { return _peso; } set { _peso = value; } }

    }
}
