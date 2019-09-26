using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class Contato
    {
        #region Atributos
        private string email;
        private string nome;
        private List<Fone> telefones;
        #endregion

        #region Propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal List<Fone> Telefones
        {
            get { return telefones; }
            set { telefones = value; }
        }

        #endregion

        #region Construtores
        public Contato(string email, string nome, List<Fone> telefones)
        {
            this.email = email;
            this.nome = nome;
            this.telefones = telefones;
        }

        public Contato(string email) : this(email, "", null)
        { }

        public Contato()
            : this("", "", null)
        { }
        #endregion

        public void AdicionarFone (Fone f)
        {
            this.Telefones.Add(f);
        }

        public bool RemoverFone (Fone f)
        {
            bool podeRemover;
            podeRemover = (this.telefones.IndexOf(f) > -1);
            if (podeRemover)
                this.telefones.RemoveAt(this.telefones.IndexOf(f));
            return podeRemover;
        }

        #region Sobrecargas
        public override string ToString()
        {
            return string.Format("e-mail: {0}\nNome: {1}",
                this.email, this.nome);
        }

        public override bool Equals(object obj)
        {
            return (this.email == ((Contato)obj).email);
        }
        #endregion
    }
}
