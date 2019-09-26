using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class Contatos
    {
        private List<Contato> meusContatos;

        public List<Contato> MeusContatos
        {
            get { return meusContatos; }
        }

        public Contatos()
        {
            meusContatos = new List<Contato>();
        }

        public void Adicionar(Contato c)
        {
            this.meusContatos.Add(c);
        }

        public Contato Pesquisar(Contato c)
        {
            Contato contatoAchado;
            contatoAchado = new Contato();
            foreach (Contato contato in this.meusContatos)
                if (contato.Equals(c))
                    contatoAchado = contato;
            return contatoAchado;
        }

        public bool Alterar(Contato c)
        {
            int posicao;
            posicao = this.meusContatos.IndexOf(c);
            if (posicao > -1)
            {
                this.meusContatos.RemoveAt(posicao);
                this.meusContatos.Insert(posicao, c);
            }
            return (posicao > -1);
        }

        public bool Remover(Contato c)
        {
            bool podeRemover;
            podeRemover = (this.meusContatos.IndexOf(c) > -1);
            if (podeRemover)
                this.meusContatos.RemoveAt(this.meusContatos.IndexOf(c));
            return podeRemover;
        }
    }
}
