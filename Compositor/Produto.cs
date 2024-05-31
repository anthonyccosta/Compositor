using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    public class Produto : IComponent //Essa classe implementa a interface IComponent e representa um item individual que não tem subcomponentes.
    {
        public string _nome;
        public decimal _preco;

        public Produto(string nome, decimal preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public void MostrarPreco()
        {
            Console.WriteLine($"{_nome} - Preço: R${_preco}");
        }

        public decimal CalcularTotal()
        {
            return _preco;
        }
    }

    public class Program
    {
        static void Main(string[] args) //criamos alguns produtos e uma coleção de produtos.
                                        //Adicionamos os produtos à coleção e, mostramos os preços individuais dos produtos
                                        //e o preço total da compra.
        {
            // Criando produtos de forma individual (FOLHA)
            var produto1 = new Produto("Camiseta", 25.99m); //"m" é usado para indicar que um número é do tipo decimal
            var produto2 = new Produto("Calça Jeans", 49.99m);
            var produto3 = new Produto("Tênis", 79.99m);

            // Criando coleção de produtos
            var colecao = new ColecaoProdutos();

            // Adicionando produtos à coleção (RAMOS)
            colecao.AdicionarComponente(produto1);
            colecao.AdicionarComponente(produto2);
            colecao.AdicionarComponente(produto3);

            // Mostrando preços
            Console.WriteLine("Produtos:");
            colecao.MostrarPreco();

            decimal total = colecao.CalcularTotal();
            Console.WriteLine($"\nTotal da compra: R${total}");
        }
    }
}
