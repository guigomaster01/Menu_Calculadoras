namespace Solucao_Calculadora
{
    partial class FrmCalc_Botao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalc_Botao));
            this.lblSinal = new System.Windows.Forms.Label();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(239, 55);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 0;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtN2
            // 
            this.TxtN2.Location = new System.Drawing.Point(212, 87);
            this.TxtN2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(68, 20);
            this.TxtN2.TabIndex = 2;
            // 
            // TxtN1
            // 
            this.TxtN1.Location = new System.Drawing.Point(212, 28);
            this.TxtN1.Margin = new System.Windows.Forms.Padding(2);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(68, 20);
            this.TxtN1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "&Somar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sub&trair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 153);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 189);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "&Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "#1 Número";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "#2 Número";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(303, 153);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "&Dividir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "&Fechar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.CausesValidation = false;
            this.lblResultado.Location = new System.Drawing.Point(187, 118);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 17);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.lblSinal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculadora V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblResultado;
    }
}

