using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAtendimentoFila
{
    public partial class FormProjetoAtendimento : Form
    {
        //INICIALIZAÇÃO DOS OBJETOS
        private Guiches listChuiches;
        private Guiche listChuiche;
        private Senhas listSenhas;
        private Senha listSenha;

        public FormProjetoAtendimento()
        {
            InitializeComponent();

            listChuiches = new Guiches();
            listChuiche = new Guiche();
            listSenhas = new Senhas();
            listSenha = new Senha();
        }

        private void labelNumGuiches_Click(object sender, EventArgs e)
        {
            labelGuiche.Text = Convert.ToString(listSenhas.ProximoAtendimento);
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            listSenhas.gerar();
        }

        private void buttonListarSenhas_Click(object sender, EventArgs e)
        {
            listBoxSenhas.Items.Clear();

            foreach(Senha shn in listSenhas.FilaSenhas)
            {
                listBoxSenhas.Items.Add(shn.dadosParciais());
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listChuiches.adicionar(new Guiche());
            labelNumGuiches.Text = Convert.ToString(listChuiches.ListaGuiches.Count());
        }

        private void buttonListarAtendimentos_Click(object sender, EventArgs e)
        {
            listBoxAtendimento.Items.Clear();
            foreach(Senha shn in listSenhas.FilaSenhas)
            {
                listBoxAtendimento.Items.Add(shn.Id+" - "+shn.DataGerac.ToShortDateString()+ " - " +shn.HoraGerac.ToShortTimeString()
                    + " - " +shn.DataAtend.ToShortDateString()+ " - " +shn.HoraAtend.ToShortTimeString());
            }
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            if (!listChuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].chamar(listSenhas.FilaSenhas))
                MessageBox.Show("Fila vazia");
        }

     
    }//CLASS
}//NAMESPACE
