using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Senhas
    {
        #region Atributos
        private Int32 proximoAtendimento;
        private Queue<Senha> filaSenhas;
        #endregion

        #region Propriedades
        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

        public Int32 ProximoAtendimento
        {
            get { return proximoAtendimento; }
            set { proximoAtendimento = value; }
        }
        #endregion

        #region Construtores
        //2 Argumentos
        public Senhas(Int32 proximoAtendimento, Queue<Senha> filaSenhas)
        {
            this.proximoAtendimento = proximoAtendimento;
            this.filaSenhas = filaSenhas;
        }
        //1 Argumento
        public Senhas(Int32 proximoAtendimento)
        {
            this.proximoAtendimento = proximoAtendimento;
        }
        //0 Argumentos
        public Senhas()
        {
            this.proximoAtendimento = 1;
            this.filaSenhas = new Queue<Senha>();
        }
        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Senhas p = (Senhas)obj;
            return this.proximoAtendimento.Equals(p.proximoAtendimento);
        }
        #endregion

        #region Metodos Funcionais
        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(this.proximoAtendimento++));
        }
        #endregion
    }
}
