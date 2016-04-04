namespace Biblioteca.View
{
    partial class EmprestimoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.pbIncluir = new System.Windows.Forms.Button();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exemplar";
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(79, 10);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(152, 20);
            this.txtEmprestimo.TabIndex = 1;
            this.txtEmprestimo.TextChanged += new System.EventHandler(this.txtEmprestimo_TextChanged);
            // 
            // pbIncluir
            // 
            this.pbIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIncluir.Location = new System.Drawing.Point(518, 8);
            this.pbIncluir.Name = "pbIncluir";
            this.pbIncluir.Size = new System.Drawing.Size(75, 23);
            this.pbIncluir.TabIndex = 3;
            this.pbIncluir.Text = "Incluir";
            this.pbIncluir.UseVisualStyleBackColor = true;
            this.pbIncluir.Click += new System.EventHandler(this.pbIncluir_Click);
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Location = new System.Drawing.Point(238, 12);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(0, 13);
            this.lblNomeLivro.TabIndex = 5;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmprestimoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 49);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.pbIncluir);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label1);
            this.Name = "EmprestimoView";
            this.Text = "EmprestimoView";
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Button pbIncluir;
        private System.Windows.Forms.Label lblNomeLivro;
        private bibliotecaDataSet bibliotecaDataSet;
    }
}