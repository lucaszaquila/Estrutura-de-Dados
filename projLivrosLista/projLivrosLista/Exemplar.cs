using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Exemplar
    {
        #region atributos
        private int tombo;
        private List<Emprestimo> emprestimos;
        #endregion
        
        #region propriedades
        public int Tombo
        {
            get
            {
                return tombo;
            }

            set
            {
                tombo = value;
            }
        }
        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
        }

        #endregion

        #region construtores
        public Exemplar (int tombo)
        {
            this.tombo = tombo;
            emprestimos = new List<Emprestimo>();
        }
        public Exemplar()
        {
            this.tombo = 0;
            this.emprestimos = new List<Emprestimo>();
        }


        #endregion

        #region metodos

        public Boolean emprestar()
        {
            if (this.disponivel())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean devolver()
        {
            if (this.disponivel())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean disponivel()
        {
            bool disponivel = (this.emprestimos.Count == 0);
            if (!disponivel)
            {
                disponivel = (this.emprestimos[emprestimos.Count - 1].DtDevolução != null);
            }

            return disponivel;
        }
        public int qtdeEmprestimos()
        {
            return this.emprestimos.Count();
        }

        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Exemplar p = (Exemplar)obj;
            return this.tombo.Equals(p.tombo);
        }
        #endregion

    }
}
