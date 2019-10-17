using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Guiches
    {
        #region Atributos
        private List<Guiche> listaGuiches;
        #endregion

        #region Propriedades
        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
        }
        #endregion

        #region Construtores
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }
        #endregion

        #region Metodos Funcionais
        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
        #endregion
    }
}
