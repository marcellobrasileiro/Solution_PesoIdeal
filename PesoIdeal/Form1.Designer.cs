
namespace PesoIdeal
{
    partial class frmPesoIdeal
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
            this.cntSexo = new System.Windows.Forms.GroupBox();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.cntSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntSexo
            // 
            this.cntSexo.Controls.Add(this.rdFeminino);
            this.cntSexo.Controls.Add(this.rdMasculino);
            this.cntSexo.Location = new System.Drawing.Point(32, 28);
            this.cntSexo.Name = "cntSexo";
            this.cntSexo.Size = new System.Drawing.Size(210, 53);
            this.cntSexo.TabIndex = 0;
            this.cntSexo.TabStop = false;
            this.cntSexo.Text = "Sexo";
            // 
            // rdFeminino
            // 
            this.rdFeminino.AutoSize = true;
            this.rdFeminino.Location = new System.Drawing.Point(115, 22);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(86, 21);
            this.rdFeminino.TabIndex = 1;
            this.rdFeminino.Text = "Feminino";
            this.rdFeminino.UseVisualStyleBackColor = true;
            this.rdFeminino.CheckedChanged += new System.EventHandler(this.rdFeminino_CheckedChanged);
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(17, 22);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            this.rdMasculino.CheckedChanged += new System.EventHandler(this.rdMasculino_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(266, 28);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(269, 59);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 2;
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPesoIdeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.txtPesoIdeal.Location = new System.Drawing.Point(147, 104);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.Size = new System.Drawing.Size(100, 44);
            this.txtPesoIdeal.TabIndex = 3;
            this.txtPesoIdeal.TextChanged += new System.EventHandler(this.txtPesoIdeal_TextChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(159, 84);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(74, 17);
            this.lblPesoIdeal.TabIndex = 4;
            this.lblPesoIdeal.Text = "Peso Ideal";
            // 
            // frmPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 165);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.cntSexo);
            this.Name = "frmPesoIdeal";
            this.Text = "Cálculo do peso ideal";
            this.cntSexo.ResumeLayout(false);
            this.cntSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cntSexo;
        private System.Windows.Forms.RadioButton rdFeminino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.Label lblPesoIdeal;
    }
}

