using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Form
{
    public partial class Form1 
    {
        Contatos contatos = new Contatos();
        List<string> numeros = new List<string>();
        List<string> tipo = new List<string>();
        private object comboTipoBox;
        private object boxNum;
        private object listaNumerosBoxs;
        private object boxTipo;

        public Form1()
        {
            InitializeComponent();
            comboTipoBox.SelectedIndex = 0;
        }

        public void listaDosNumeros()
        {
            listaNumerosBoxs.Items.Clear();
            boxTipo.Items.Clear();

            for (int i = 0; i < this.numeros.Count; i++)
            {
                listaNumerosBoxs.Items.Add(this.numeros[i]);
                boxTipo.Items.Add(this.tipo[i]);
            }
        }

        public void limpandoForms()
        {
            textBoxMail.Text = "";
            textBoxName.Text = "";
            boxNum.Text = "";
            comboTipoBox.SelectedIndex = 0;
            listaNumerosBoxs.Items.Clear();
            boxTipo.Items.Clear();
            this.numeros.Clear();
            this.tipo.Clear();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if(textBoxMail.Text != "" || textBoxName.Text != "" || boxNum.Text != "")
            {
                result = MessageBox.Show("Tem certeza que deseja limpar o formulário?","", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    limpandoForms();
                }
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxMail.Text != "")
            {
                List<Fone> teladd = new List<Fone>();
                for (int i = 0; i < this.numeros.Count; i++)
                {
                    Fone newtel = new Fone(this.numeros[i], this.tipo[i]);
                    teladd.Add(newtel);
                }

                contatos.Adicionar(new Contato(textBoxMail.Text, textBoxName.Text, teladd));

                MessageBox.Show("Contato salvo");
            }
            else
            {
                MessageBox.Show("ERRO: Campo E-mail não pode estar em branco");
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string emailpesquisa = textBoxMail.Text;
            Contato contatoPesquisa = contatos.Pesquisar(new Contato(emailpesquisa));
            if (contatoPesquisa.Email == emailpesquisa)
            {
                textBoxMail.Text = contatoPesquisa.Email;
                textBoxName.Text = contatoPesquisa.Nome;

                this.numeros.Clear();
                this.tipo.Clear();

                if(textBoxMail.Text != "")
                {
                    for (int i = 0; i < contatoPesquisa.Telefones.Count; i++)
                    {
                        this.numeros.Add(contatoPesquisa.Telefones[i].Numero);
                        this.tipo.Add(contatoPesquisa.Telefones[i].Tipo);
                    }
                }
                

                listaDosNumeros();
            }

            else
                MessageBox.Show("Contato não encontrado");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string emailexclui = textBoxMail.Text;
            contatos.Remover(new Contato(emailexclui));
            MessageBox.Show("Usuário removido");
            limpandoForms();
        }

        private void boxNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.numeros.Add(boxNum.Text);
            this.tipo.Add(comboTipoBox.Text);

            listaDosNumeros();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.tipo.RemoveAt(this.numeros.IndexOf(boxNum.Text));
            this.numeros.Remove(boxNum.Text);
            

            listaDosNumeros();
        }

        private void ListBoxNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxTipo.SelectedIndex = listaNumerosBoxs.SelectedIndex;
            boxNum.Text = listaNumerosBoxs.SelectedItem.ToString();
            comboTipoBox.Text = boxTipo.Items[listaNumerosBoxs.SelectedIndex].ToString();
        }
    }
}
