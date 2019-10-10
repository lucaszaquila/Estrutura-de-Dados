using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livros
    {
        //atributos
        public List<Livro> acervo;

        //construtor
        public Livros()
        {
            this.acervo = new List<Livro>();
        }
        //metodos basicos
        public void adicionar (Livro livro)
        {
            this.acervo.Add(livro);
        }
        public Livro Pesquisar (Livro livro)
        {
            Livro aux = new Livro();

            foreach (Livro li in acervo)
            {
                if (li.Equals(livro))
                {
                    aux = li;
                }

            }
            return aux;
        }
    }
}
