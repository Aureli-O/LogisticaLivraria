using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Livraria
{
    class Produto
    {
        //ATRIBUTOS DO OBJ
        string Nome;
        string Categoria;
        float Preco;
        int QuantPags;
        int QuantEmEstoque;

        //CONSTRUTOR
        public Produto()
        {
            //NOVO PRODUTO
        }
        public Produto(string Nome)
        {
            this.Nome = Nome;
        }
        //NOME
        public void setNome(string Nome)
        {
            this.Nome= Nome;
        }
        public string getNome()
        {
            return Nome;
        }
        //CATEGORIA
        public void setCategoria(string Categoria)
        {
            this.Categoria = Categoria;
        }
        public string getCategoria()
        {
            return Categoria;
        }
        //PREÇO
        public void setPreco(float Preco)
        {
            this.Preco = Preco;
        }
        public float getPreco()
        {
            return Preco;
        }
        //QUANTIDADE DE PAGINAS
        public void setQuantidadeDePaginas(int QuantPags)
        {
            this.QuantPags = QuantPags;
        }
        public int getQuantidadeDePaginas()
        {
            return QuantPags;
        }
        //QUANTIDADE EM ESTOQUE
        public void setQuantidadeEmEstoque(int QuantEmEstoque)
        {
            this.QuantEmEstoque = QuantEmEstoque;
        }
        public int getQuantidadeEmEstoque()
        {
            return QuantEmEstoque;
        }
        //VALOR TOTAL EM ESTOQUE
        public float CalcularValorTotalEmEstoque()
        {
            return QuantEmEstoque * Preco;
        }
        //IMPRIMIR INFOS NO CONSOLE
        public override string ToString()
        {

            return  "=============================\n" +
                    "#############################\n" +
                    "=============================\n" +
                    "Nome: " + Nome + "\n" +
                    "Categoria: " + Categoria + "\n" +
                    "Preço: " + Preco.ToString() + "\n" +
                    "Quantidade de Páginas: " + QuantPags.ToString() + "\n" +
                    "Quantidade: " + QuantEmEstoque.ToString() + "\n" +
                    "Valor Total em Estoque: " + CalcularValorTotalEmEstoque() + "\n" +
                    "=============================\n" +
                    "#############################\n" +
                    "=============================\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //USAR . NO PREÇO DECIMAL
            var adq = CultureInfo.InvariantCulture;
            //CRIANDO NOVO PRODUTO
            Produto p = new Produto();
            //DECLARANDO NOVAS INFOS NO PRODUTO
            Console.Write("Digite o nome do produto: ");
            string n = Console.ReadLine();
            Console.Write("Digite a categoria do produto: ");
            string cat = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine(), adq);
            Console.Write("Digite o quantidade de páginas: ");
            int qtdP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o quantidade do produto: ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            //REDECLARANDO 
            p.setNome(n);
            p.setPreco(preco);
            p.setQuantidadeDePaginas(qtdP);
            p.setQuantidadeEmEstoque(qtd);
            p.setCategoria(cat);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}