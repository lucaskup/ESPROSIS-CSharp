namespace Biblioteca.View
{
    partial class MultaObservacaoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pbConfirmar = new System.Windows.Forms.Button();
            this.pbCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(13, 13);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(400, 20);
            this.txtObservacao.TabIndex = 0;
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.Location = new System.Drawing.Point(256, 39);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(75, 23);
            this.pbConfirmar.TabIndex = 1;
            this.pbConfirmar.Text = "Confirmar";
            this.pbConfirmar.UseVisualStyleBackColor = true;
            this.pbConfirmar.Click += new System.EventHandler(this.pbConfirmar_Click);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(338, 39);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(75, 23);
            this.pbCancelar.TabIndex = 2;
            this.pbCancelar.Text = "Cancelar";
            this.pbCancelar.UseVisualStyleBackColor = true;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // MultaObservacaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 73);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.txtObservacao);
            this.Name = "MultaObservacaoView";
            this.Text = "MultaObservacaoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button pbConfirmar;
        private System.Windows.Forms.Button pbCancelar;
    }
}