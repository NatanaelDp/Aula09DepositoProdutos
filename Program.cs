using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09ProdutosEstoque
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { "pepsi", "fanta" };


            Console.WriteLine("Bem-Vindo ao Conradito Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();

                if (resposta=="1")
                {
                    Console.WriteLine("Digite o nome do produto");
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();


                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Esse item já existe na lista...");
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                    }
                    
                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    while (contador<produtos.Count)
                    {
                        string palavra = produtos[contador];
                        string primeira_letra=palavra.Substring(0,1);//f
                        primeira_letra = primeira_letra.ToUpper();//F
                        string segunda_parte = palavra.Substring(1, palavra.Length-1);//anta
                        string palavra_complesta = primeira_letra + segunda_parte; //F+anta
                        texto += produtos[contador] + ", ";
                        contador++;
                    }
                    
                    texto=texto.Substring(0,texto.Length-2);

                    Console.WriteLine(texto);
                }    

            }

        }
    }
}








