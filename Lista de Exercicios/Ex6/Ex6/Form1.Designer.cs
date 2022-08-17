namespace Ex6
{
    partial class Form1
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
            this.labA = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.labAB = new System.Windows.Forms.Label();
            this.labBA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.txtBA = new System.Windows.Forms.TextBox();
            this.btnTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Location = new System.Drawing.Point(71, 69);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(58, 13);
            this.labA.TabIndex = 0;
            this.labA.Text = "Informe A :";
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Location = new System.Drawing.Point(71, 100);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(58, 13);
            this.labB.TabIndex = 1;
            this.labB.Text = "Informe B :";
            // 
            // labAB
            // 
            this.labAB.AutoSize = true;
            this.labAB.Location = new System.Drawing.Point(109, 155);
            this.labAB.Name = "labAB";
            this.labAB.Size = new System.Drawing.Size(20, 13);
            this.labAB.TabIndex = 2;
            this.labAB.Text = "A :";
            // 
            // labBA
            // 
            this.labBA.AutoSize = true;
            this.labBA.Location = new System.Drawing.Point(109, 181);
            this.labBA.Name = "labBA";
            this.labBA.Size = new System.Drawing.Size(20, 13);
            this.labBA.TabIndex = 3;
            this.labBA.Text = "B :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(136, 69);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(135, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(135, 152);
            this.txtAB.Name = "txtAB";
            this.txtAB.Size = new System.Drawing.Size(100, 20);
            this.txtAB.TabIndex = 4;
            // 
            // txtBA
            // 
            this.txtBA.Location = new System.Drawing.Point(135, 178);
            this.txtBA.Name = "txtBA";
            this.txtBA.Size = new System.Drawing.Size(100, 20);
            this.txtBA.TabIndex = 4;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(135, 123);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(100, 23);
            this.btnTroca.TabIndex = 5;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.txtBA);
            this.Controls.Add(this.txtAB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labBA);
            this.Controls.Add(this.labAB);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label labAB;
        private System.Windows.Forms.Label labBA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.TextBox txtBA;
        private System.Windows.Forms.Button btnTroca;
    }
}

