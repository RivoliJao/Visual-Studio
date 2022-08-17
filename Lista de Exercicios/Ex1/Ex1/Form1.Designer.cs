namespace Ex1
{
    partial class Ex1
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.labN2 = new System.Windows.Forms.Label();
            this.labN1 = new System.Windows.Forms.Label();
            this.labExercicio1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(210, 234);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 22;
            this.btnSoma.Text = "Somar";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(210, 287);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 20;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(210, 166);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 21;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(210, 120);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 19;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(58, 294);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(107, 13);
            this.labResultado.TabIndex = 18;
            this.labResultado.Text = "Resultado da soma : ";
            // 
            // labN2
            // 
            this.labN2.AutoSize = true;
            this.labN2.Location = new System.Drawing.Point(55, 174);
            this.labN2.Name = "labN2";
            this.labN2.Size = new System.Drawing.Size(82, 13);
            this.labN2.TabIndex = 17;
            this.labN2.Text = "Escreva o Nº2 :";
            // 
            // labN1
            // 
            this.labN1.AutoSize = true;
            this.labN1.Location = new System.Drawing.Point(55, 128);
            this.labN1.Name = "labN1";
            this.labN1.Size = new System.Drawing.Size(82, 13);
            this.labN1.TabIndex = 16;
            this.labN1.Text = "Escreva o Nº1 :";
            // 
            // labExercicio1
            // 
            this.labExercicio1.AutoSize = true;
            this.labExercicio1.Location = new System.Drawing.Point(52, 57);
            this.labExercicio1.Name = "labExercicio1";
            this.labExercicio1.Size = new System.Drawing.Size(151, 13);
            this.labExercicio1.TabIndex = 15;
            this.labExercicio1.Text = "Função soma de dois numeros";
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.labN2);
            this.Controls.Add(this.labN1);
            this.Controls.Add(this.labExercicio1);
            this.Name = "Ex1";
            this.Text = "Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Label labN2;
        private System.Windows.Forms.Label labN1;
        private System.Windows.Forms.Label labExercicio1;
    }
}

