
namespace calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Display = new System.Windows.Forms.TextBox();
            this.botaoCE = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            resources.ApplyResources(this.Display, "Display");
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            // 
            // botaoCE
            // 
            resources.ApplyResources(this.botaoCE, "botaoCE");
            this.botaoCE.Name = "botaoCE";
            this.botaoCE.UseVisualStyleBackColor = true;
            this.botaoCE.Click += new System.EventHandler(this.botaoCE_Pressed);
            // 
            // divisao
            // 
            resources.ApplyResources(this.divisao, "divisao");
            this.divisao.Name = "divisao";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.operador_Pressed);
            // 
            // multiplicacao
            // 
            resources.ApplyResources(this.multiplicacao, "multiplicacao");
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.operador_Pressed);
            // 
            // subtracao
            // 
            resources.ApplyResources(this.subtracao, "subtracao");
            this.subtracao.Name = "subtracao";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.operador_Pressed);
            // 
            // botao7
            // 
            resources.ApplyResources(this.botao7, "botao7");
            this.botao7.Name = "botao7";
            this.botao7.Tag = "";
            this.botao7.UseVisualStyleBackColor = true;
            this.botao7.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao8
            // 
            resources.ApplyResources(this.botao8, "botao8");
            this.botao8.Name = "botao8";
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao9
            // 
            resources.ApplyResources(this.botao9, "botao9");
            this.botao9.Name = "botao9";
            this.botao9.UseVisualStyleBackColor = true;
            this.botao9.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // adicao
            // 
            resources.ApplyResources(this.adicao, "adicao");
            this.adicao.Name = "adicao";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.operador_Pressed);
            // 
            // botao4
            // 
            resources.ApplyResources(this.botao4, "botao4");
            this.botao4.Name = "botao4";
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao5
            // 
            resources.ApplyResources(this.botao5, "botao5");
            this.botao5.Name = "botao5";
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao6
            // 
            resources.ApplyResources(this.botao6, "botao6");
            this.botao6.Name = "botao6";
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao1
            // 
            resources.ApplyResources(this.botao1, "botao1");
            this.botao1.Name = "botao1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao2
            // 
            resources.ApplyResources(this.botao2, "botao2");
            this.botao2.Name = "botao2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // botao3
            // 
            resources.ApplyResources(this.botao3, "botao3");
            this.botao3.Name = "botao3";
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // resultado
            // 
            resources.ApplyResources(this.resultado, "resultado");
            this.resultado.Name = "resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.operador_Pressed);
            // 
            // botao0
            // 
            resources.ApplyResources(this.botao0, "botao0");
            this.botao0.Name = "botao0";
            this.botao0.UseVisualStyleBackColor = true;
            this.botao0.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // virgula
            // 
            resources.ApplyResources(this.virgula, "virgula");
            this.virgula.Name = "virgula";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.valor_Pressed);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.botaoCE);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button botaoCE;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.Button virgula;
    }
}

