namespace Ex3
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
            this.labExercicio = new System.Windows.Forms.Label();
            this.labDistancia = new System.Windows.Forms.Label();
            this.labCombustivel = new System.Windows.Forms.Label();
            this.labMedia = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.labKm = new System.Windows.Forms.Label();
            this.labL = new System.Windows.Forms.Label();
            this.labKmL = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labExercicio
            // 
            this.labExercicio.AutoSize = true;
            this.labExercicio.Location = new System.Drawing.Point(51, 52);
            this.labExercicio.Name = "labExercicio";
            this.labExercicio.Size = new System.Drawing.Size(376, 13);
            this.labExercicio.TabIndex = 0;
            this.labExercicio.Text = "Algoritmo para determinar o consumo médio de um automóvel em uma viagem ";
            // 
            // labDistancia
            // 
            this.labDistancia.AutoSize = true;
            this.labDistancia.Location = new System.Drawing.Point(61, 111);
            this.labDistancia.Name = "labDistancia";
            this.labDistancia.Size = new System.Drawing.Size(147, 13);
            this.labDistancia.TabIndex = 0;
            this.labDistancia.Text = "Escreva a distancia percoria :";
            // 
            // labCombustivel
            // 
            this.labCombustivel.AutoSize = true;
            this.labCombustivel.Location = new System.Drawing.Point(61, 149);
            this.labCombustivel.Name = "labCombustivel";
            this.labCombustivel.Size = new System.Drawing.Size(126, 13);
            this.labCombustivel.TabIndex = 0;
            this.labCombustivel.Text = "Indorme os litros usados :";
            // 
            // labMedia
            // 
            this.labMedia.AutoSize = true;
            this.labMedia.Location = new System.Drawing.Point(51, 231);
            this.labMedia.Name = "labMedia";
            this.labMedia.Size = new System.Drawing.Size(174, 13);
            this.labMedia.TabIndex = 0;
            this.labMedia.Text = "Media de litros (L) e distância (Km) :";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(231, 111);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(56, 20);
            this.txtKm.TabIndex = 1;
            this.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(231, 149);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(56, 20);
            this.txtL.TabIndex = 1;
            this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(231, 228);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(56, 20);
            this.txtMedia.TabIndex = 1;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labKm
            // 
            this.labKm.AutoSize = true;
            this.labKm.Location = new System.Drawing.Point(293, 114);
            this.labKm.Name = "labKm";
            this.labKm.Size = new System.Drawing.Size(22, 13);
            this.labKm.TabIndex = 2;
            this.labKm.Text = "Km";
            // 
            // labL
            // 
            this.labL.AutoSize = true;
            this.labL.Location = new System.Drawing.Point(293, 152);
            this.labL.Name = "labL";
            this.labL.Size = new System.Drawing.Size(13, 13);
            this.labL.TabIndex = 3;
            this.labL.Text = "L";
            // 
            // labKmL
            // 
            this.labKmL.AutoSize = true;
            this.labKmL.Location = new System.Drawing.Point(293, 231);
            this.labKmL.Name = "labKmL";
            this.labKmL.Size = new System.Drawing.Size(33, 13);
            this.labKmL.TabIndex = 4;
            this.labKmL.Text = "Km/L";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(231, 188);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(56, 23);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "Calcular";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.labKmL);
            this.Controls.Add(this.labL);
            this.Controls.Add(this.labKm);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.labMedia);
            this.Controls.Add(this.labCombustivel);
            this.Controls.Add(this.labDistancia);
            this.Controls.Add(this.labExercicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labExercicio;
        private System.Windows.Forms.Label labDistancia;
        private System.Windows.Forms.Label labCombustivel;
        private System.Windows.Forms.Label labMedia;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label labKm;
        private System.Windows.Forms.Label labL;
        private System.Windows.Forms.Label labKmL;
        private System.Windows.Forms.Button btnMedia;
    }
}

