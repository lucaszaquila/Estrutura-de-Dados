using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Guiche
    {
        #region Atributos
        private Int32 id;
        private Queue<Senha> atendimentos;
        #endregion

        #region Propriedades
        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
        }
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Construtores
        public Guiche(Int32 id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }
        public Guiche()
        {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }
        #endregion

        #region Metodos Funcionais
        public Boolean chamar(Queue<Senha> filaSenhas)
        {
            Boolean temSenha = (filaSenhas.Count > 0);

            if (temSenha)
            {
                Senha senhaAtendida = filaSenhas.Dequeue();
                senhaAtendida.DataAtend = DateTime.Now;
                senhaAtendida.HoraAtend = DateTime.Now;
                atendimentos.Enqueue(senhaAtendida);
            }
            return temSenha;
        }
        #endregion
    }
}
