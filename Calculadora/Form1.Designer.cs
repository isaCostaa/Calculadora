namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            botao7 = new Button();
            botao9 = new Button();
            botao6 = new Button();
            botao3 = new Button();
            botao0 = new Button();
            botao8 = new Button();
            botao5 = new Button();
            botao2 = new Button();
            botao1 = new Button();
            botao4 = new Button();
            botaoDivisao = new Button();
            botaoMultiplicacao = new Button();
            botaoSubtracao = new Button();
            botaoAdicao = new Button();
            botaoIgual = new Button();
            botaoVirgula = new Button();
            botaoLimpar = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 42);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(300, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // botao7
            // 
            botao7.Location = new Point(36, 151);
            botao7.Name = "botao7";
            botao7.Size = new Size(63, 54);
            botao7.TabIndex = 1;
            botao7.Text = "7";
            botao7.UseVisualStyleBackColor = true;
            botao7.Click += botao7_Click;
            // 
            // botao9
            // 
            botao9.Location = new Point(174, 151);
            botao9.Name = "botao9";
            botao9.Size = new Size(63, 54);
            botao9.TabIndex = 2;
            botao9.Text = "9";
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += botao9_Click;
            // 
            // botao6
            // 
            botao6.Location = new Point(174, 212);
            botao6.Name = "botao6";
            botao6.Size = new Size(63, 54);
            botao6.TabIndex = 3;
            botao6.Text = "6";
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += botao6_Click;
            // 
            // botao3
            // 
            botao3.Location = new Point(174, 272);
            botao3.Name = "botao3";
            botao3.Size = new Size(63, 54);
            botao3.TabIndex = 4;
            botao3.Text = "3";
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += botao3_Click;
            // 
            // botao0
            // 
            botao0.Location = new Point(105, 332);
            botao0.Name = "botao0";
            botao0.Size = new Size(63, 54);
            botao0.TabIndex = 5;
            botao0.Text = "0";
            botao0.UseVisualStyleBackColor = true;
            botao0.Click += botao0_Click;
            // 
            // botao8
            // 
            botao8.Location = new Point(105, 151);
            botao8.Name = "botao8";
            botao8.Size = new Size(63, 54);
            botao8.TabIndex = 6;
            botao8.Text = "8";
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += botao8_Click;
            // 
            // botao5
            // 
            botao5.Location = new Point(105, 212);
            botao5.Name = "botao5";
            botao5.Size = new Size(63, 54);
            botao5.TabIndex = 7;
            botao5.Text = "5";
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += botao5_Click;
            // 
            // botao2
            // 
            botao2.Location = new Point(105, 272);
            botao2.Name = "botao2";
            botao2.Size = new Size(63, 54);
            botao2.TabIndex = 8;
            botao2.Text = "2";
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += botao2_Click;
            // 
            // botao1
            // 
            botao1.Location = new Point(36, 272);
            botao1.Name = "botao1";
            botao1.Size = new Size(63, 54);
            botao1.TabIndex = 9;
            botao1.Text = "1";
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += botao1_Click;
            // 
            // botao4
            // 
            botao4.Location = new Point(36, 212);
            botao4.Name = "botao4";
            botao4.Size = new Size(63, 54);
            botao4.TabIndex = 10;
            botao4.Text = "4";
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += botao4_Click;
            // 
            // botaoDivisao
            // 
            botaoDivisao.Location = new Point(243, 151);
            botaoDivisao.Name = "botaoDivisao";
            botaoDivisao.Size = new Size(63, 54);
            botaoDivisao.TabIndex = 11;
            botaoDivisao.Text = "/";
            botaoDivisao.UseVisualStyleBackColor = true;
            botaoDivisao.Click += botaoDivisao_Click;
            // 
            // botaoMultiplicacao
            // 
            botaoMultiplicacao.Location = new Point(243, 212);
            botaoMultiplicacao.Name = "botaoMultiplicacao";
            botaoMultiplicacao.Size = new Size(63, 54);
            botaoMultiplicacao.TabIndex = 12;
            botaoMultiplicacao.Text = "X";
            botaoMultiplicacao.UseVisualStyleBackColor = true;
            botaoMultiplicacao.Click += botaoMultiplicacao_Click;
            // 
            // botaoSubtracao
            // 
            botaoSubtracao.Location = new Point(243, 272);
            botaoSubtracao.Name = "botaoSubtracao";
            botaoSubtracao.Size = new Size(63, 54);
            botaoSubtracao.TabIndex = 13;
            botaoSubtracao.Text = "-";
            botaoSubtracao.UseVisualStyleBackColor = true;
            botaoSubtracao.Click += botaoSubtracao_Click;
            // 
            // botaoAdicao
            // 
            botaoAdicao.Location = new Point(243, 332);
            botaoAdicao.Name = "botaoAdicao";
            botaoAdicao.Size = new Size(63, 54);
            botaoAdicao.TabIndex = 14;
            botaoAdicao.Text = "+";
            botaoAdicao.UseVisualStyleBackColor = true;
            botaoAdicao.Click += botaoAdicao_Click;
            // 
            // botaoIgual
            // 
            botaoIgual.BackColor = Color.LightCoral;
            botaoIgual.Location = new Point(174, 332);
            botaoIgual.Name = "botaoIgual";
            botaoIgual.Size = new Size(63, 54);
            botaoIgual.TabIndex = 15;
            botaoIgual.Text = "=";
            botaoIgual.UseVisualStyleBackColor = false;
            botaoIgual.Click += botaoIgual_Click;
            // 
            // botaoVirgula
            // 
            botaoVirgula.Location = new Point(36, 332);
            botaoVirgula.Name = "botaoVirgula";
            botaoVirgula.Size = new Size(63, 54);
            botaoVirgula.TabIndex = 16;
            botaoVirgula.Text = ",";
            botaoVirgula.UseVisualStyleBackColor = true;
            botaoVirgula.Click += botaoVirgula_Click;
            // 
            // botaoLimpar
            // 
            botaoLimpar.Location = new Point(243, 91);
            botaoLimpar.Name = "botaoLimpar";
            botaoLimpar.Size = new Size(63, 54);
            botaoLimpar.TabIndex = 19;
            botaoLimpar.Text = "C";
            botaoLimpar.UseVisualStyleBackColor = true;
            botaoLimpar.Click += botaoLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 422);
            Controls.Add(botaoLimpar);
            Controls.Add(botaoVirgula);
            Controls.Add(botaoIgual);
            Controls.Add(botaoAdicao);
            Controls.Add(botaoSubtracao);
            Controls.Add(botaoMultiplicacao);
            Controls.Add(botaoDivisao);
            Controls.Add(botao4);
            Controls.Add(botao1);
            Controls.Add(botao2);
            Controls.Add(botao5);
            Controls.Add(botao8);
            Controls.Add(botao0);
            Controls.Add(botao3);
            Controls.Add(botao6);
            Controls.Add(botao9);
            Controls.Add(botao7);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button botao7;
        private Button botao9;
        private Button botao6;
        private Button botao3;
        private Button botao0;
        private Button botao8;
        private Button botao5;
        private Button botao1;
        private Button botao4;
        private Button botaoDivisao;
        private Button botaoMultiplicacao;
        private Button botaoSubtracao;
        private Button botaoAdicao;
        private Button botaoIgual;
        private Button botaoVirgula;
        private Button botaoLimpar;
        private Button botao2;
    }
}
