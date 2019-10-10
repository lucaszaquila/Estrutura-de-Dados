using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Livros ListadeLivros = new Livros();
            int resposta = 0;
            do
            {
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|0 - Sair                        |");
                Console.WriteLine("|1 - Adicionar Livro             |");
                Console.WriteLine("|2 - Pesquisar Livro (sintético) |");
                Console.WriteLine("|3 - Pesquisar Livro (analítico) |");
                Console.WriteLine("|4 - Adicionar exemplar          |");
                Console.WriteLine("|5 - Registrar empréstimo        |");
                Console.WriteLine("|6 - Registrar devolução         |");
                Console.WriteLine("----------------------------------");
                resposta = Convert.ToInt32(Console.ReadLine());

                switch (resposta)
                {
                    case 0:
                        
                        break;
                    case 1:
                        int isbn;
                        string titulo;
                        string editora;
                        string autor;

                        Console.WriteLine("\n isbn do Livro \n");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n titulo do livro \n");
                        titulo = Console.ReadLine();
                        Console.WriteLine("\n editora do livro \n");
                        editora = Console.ReadLine();
                        Console.WriteLine("\n autor do livro \n");
                        autor = Console.ReadLine();

                        ListadeLivros.adicionar(new Livro(isbn, titulo, editora, autor));
                        break;
                    case 2:

                        int aux;
                        Console.WriteLine("Digite o Isbn do livro pesquisado: \t");
                        aux = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Aguardando ...");

                        {
                        
                            Livro livroAchado = ListadeLivros.Pesquisar(new Livro(aux));

                            if (livroAchado.Isbn > 0)
                            {

                                Console.WriteLine("ISBN: " + livroAchado.Isbn);

                                Console.WriteLine("TITULO: " + livroAchado.Titulo);

                                Console.WriteLine("EDITORA: " + livroAchado.Editora);

                                Console.WriteLine("AUTOR" + livroAchado.Autor);

                                Console.WriteLine("QUANTIDADE DE EXEMPLARES: " + livroAchado.qtdeExemplares());

                                Console.WriteLine("QUANTIDADE DE EMPRESTIMOS: " + livroAchado.qtdeEmprestimos());

                                Console.WriteLine("QUANTIDADE DE DISPONIVEIS: " + livroAchado.qtdeDisponiveis());
                            }
                            else
                                Console.WriteLine("Não tem o livro");

                            break;
                        }
                        
                    case 3:


                        
                        break;
                    case 4:
                        int aux4;
                        int aux42;
                        Console.WriteLine("Digite o Isbn do livro: \t");
                        aux4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Tombo do livro: \t");
                        aux42 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Aguardando ...");

                        {

                            Livro livroAchado = ListadeLivros.Pesquisar(new Livro(aux4));

                            if (livroAchado.Isbn > 0)
                            {
                                livroAchado.adicionarExemplar(new Exemplar(aux42));

                            }
                            else
                                Console.WriteLine("Não tem o livro");

                            break;
                        }
                        
                        
                    case 5:
                        int aux5;
                        int aux52;
                        Console.WriteLine("Digite o Isbn do livro: \t");
                        aux5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Tombo do livro: \t");
                        aux52 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Aguardando ...");

                        {

                            Livro livroAchado = ListadeLivros.Pesquisar(new Livro(aux5));

                            if (livroAchado.Isbn > 0)
                            {
                                livroAchado.Exemplares[0].emprestar();

                            }
                            else
                                Console.WriteLine("Não tem o livro");

                            break;
                        }
                        
                    case 6:
                        int aux6;
                        int aux62;
                        Console.WriteLine("Digite o Isbn do livro: \t");
                        aux6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Tombo do livro: \t");
                        aux62 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Aguardando ...");

                        {

                            Livro livroAchado = ListadeLivros.Pesquisar(new Livro(aux6));

                            if (livroAchado.Isbn > 0)
                            {
                                livroAchado.Exemplares[0].devolver();

                            }
                            else
                                Console.WriteLine("Não tem o livro");

                            break;
                        }
                        

                }
                Console.ReadKey();

            } while (resposta != 0);
        }
    }
}
