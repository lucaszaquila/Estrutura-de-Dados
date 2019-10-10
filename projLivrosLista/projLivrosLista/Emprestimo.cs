using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Emprestimo
    {
        #region atributos
        private DateTime dtEmprestimo;
        private DateTime dtDevolução;
        #endregion

        #region propriedades
        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }
        public DateTime DtDevolução
        {
            get { return dtDevolução; }
            set { dtDevolução = value; }

        }
        #endregion
    }
}
