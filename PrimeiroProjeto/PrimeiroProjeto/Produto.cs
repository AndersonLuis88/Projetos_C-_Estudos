using System.Globalization;

namespace PrimeiroProjeto
{
    class Produto
    {
        //Atributos Privados
        private string _nome;
        //Propriedades Autoimplementadas
        public double Preco { get; private set; };
        private int Quantidade { get; private set; };

        //Construtores
        public Produto(){}

        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        // Propriedades Customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != null && _nome.Length > 1)
                {
                    _nome = _nome;
                }
            }
        }


        // Outros Métodos da Classe
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
                return _nome
                    + ", $"
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ","
                    + "unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
        }




    }
}
