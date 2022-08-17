namespace Ex7
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
            this.labF = new System.Windows.Forms.Label();
            this.labC = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labEx7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labF
            // 
            this.labF.AutoSize = true;
            this.labF.Location = new System.Drawing.Point(66, 133);
            this.labF.Name = "labF";
            this.labF.Size = new System.Drawing.Size(63, 13);
            this.labF.TabIndex = 0;
            this.labF.Text = "Fahrenheit :";
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Location = new System.Drawing.Point(83, 78);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(46, 13);
            this.labC.TabIndex = 1;
            this.labC.Text = "Celsius :";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(135, 101);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(62, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(135, 130);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(62, 20);
            this.txtF.TabIndex = 3;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(135, 75);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(62, 20);
            this.txtC.TabIndex = 4;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cº";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fº";
            // 
            // labEx7
            // 
            this.labEx7.AutoSize = true;
            this.labEx7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labEx7.Location = new System.Drawing.Point(66, 37);
            this.labEx7.Name = "labEx7";
            this.labEx7.Size = new System.Drawing.Size(255, 17);
            this.labEx7.TabIndex = 7;
            this.labEx7.Text = "Conversor de  Celsius para Fahrenheit.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labEx7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.labC);
            this.Controls.Add(this.labF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labF;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labEx7;
    }
}

