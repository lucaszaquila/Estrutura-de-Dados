namespace TPAtendimentoFila
{
    partial class FormProjetoAtendimento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.labelQuantidadeGuiches = new System.Windows.Forms.Label();
            this.listBoxAtendimento = new System.Windows.Forms.ListBox();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelNumGuiches = new System.Windows.Forms.Label();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.Location = new System.Drawing.Point(11, 63);
            this.listBoxSenhas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(327, 277);
            this.listBoxSenhas.TabIndex = 0;
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(88, 25);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(91, 26);
            this.buttonGerar.TabIndex = 1;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(527, 29);
            this.textBoxGuiche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(76, 20);
            this.textBoxGuiche.TabIndex = 7;
            // 
            // labelQuantidadeGuiches
            // 
            this.labelQuantidadeGuiches.AutoSize = true;
            this.labelQuantidadeGuiches.Location = new System.Drawing.Point(367, 144);
            this.labelQuantidadeGuiches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantidadeGuiches.Name = "labelQuantidadeGuiches";
            this.labelQuantidadeGuiches.Size = new System.Drawing.Size(72, 13);
            this.labelQuantidadeGuiches.TabIndex = 3;
            this.labelQuantidadeGuiches.Text = "Qtde Guiches";
            // 
            // listBoxAtendimento
            // 
            this.listBoxAtendimento.FormattingEnabled = true;
            this.listBoxAtendimento.Location = new System.Drawing.Point(482, 63);
            this.listBoxAtendimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAtendimento.Name = "listBoxAtendimento";
            this.listBoxAtendimento.Size = new System.Drawing.Size(422, 277);
            this.listBoxAtendimento.TabIndex = 9;
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(88, 357);
            this.buttonListarSenhas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(123, 26);
            this.buttonListarSenhas.TabIndex = 2;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(342, 229);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(118, 32);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelNumGuiches
            // 
            this.labelNumGuiches.AutoSize = true;
            this.labelNumGuiches.Location = new System.Drawing.Point(392, 189);
            this.labelNumGuiches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumGuiches.Name = "labelNumGuiches";
            this.labelNumGuiches.Size = new System.Drawing.Size(13, 13);
            this.labelNumGuiches.TabIndex = 4;
            this.labelNumGuiches.Text = "0";
            this.labelNumGuiches.Click += new System.EventHandler(this.labelNumGuiches_Click);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(648, 29);
            this.buttonChamar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(88, 19);
            this.buttonChamar.TabIndex = 8;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(527, 357);
            this.buttonListarAtendimentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(212, 26);
            this.buttonListarAtendimentos.TabIndex = 10;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.buttonListarAtendimentos_Click);
            // 
            // labelGuiche
            // 
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Location = new System.Drawing.Point(480, 32);
            this.labelGuiche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(44, 13);
            this.labelGuiche.TabIndex = 6;
            this.labelGuiche.Text = "Guiche:";
            // 
            // FormProjetoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 418);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.labelNumGuiches);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.listBoxAtendimento);
            this.Controls.Add(this.labelQuantidadeGuiches);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.listBoxSenhas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProjetoAtendimento";
            this.Text = "Guiche Atentimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.Label labelQuantidadeGuiches;
        private System.Windows.Forms.ListBox listBoxAtendimento;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelNumGuiches;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Button buttonListarAtendimentos;
        private System.Windows.Forms.Label labelGuiche;
    }
}

