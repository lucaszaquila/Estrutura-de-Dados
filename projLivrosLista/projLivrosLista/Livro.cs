using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livro
    {
       
        #region atributos
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;
        #endregion

        #region propriedades
        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
        }
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        #endregion

        #region construtores
        //contrutores
        public Livro (int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.editora = editora;
            this.autor = autor;
            this.exemplares = new List<Exemplar>();
        }
        public Livro(int isbn)
        {
            this.isbn = isbn;
            this.exemplares = new List<Exemplar>();
        }
        public Livro()
            : this(0, "", "","")
        {
        }
        #endregion
              
        #region metodos
        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }
        public int qtdeExemplares()
        {
            return this.exemplares.Count();
        }
        public int qtdeDisponiveis()
        {
            int VqtdeDisponivel = 0;
            foreach(Exemplar aux in exemplares)
            {
                if (aux.disponivel())
                {
                    VqtdeDisponivel++;
                }
            }
            return VqtdeDisponivel;
        }
        public int qtdeEmprestimos()
        {
            int VqtdeEmprestimos = 0;
            foreach (Exemplar aux in exemplares){
                VqtdeEmprestimos += aux.qtdeEmprestimos();
            }
            return VqtdeEmprestimos;

        }
        public double percDisponibilidade()
        {
            return (qtdeDisponiveis() / qtdeEmprestimos())*100;
        }
        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Livro p = (Livro)obj;
            return this.isbn.Equals(p.isbn);
        }
        #endregion
    }
}
