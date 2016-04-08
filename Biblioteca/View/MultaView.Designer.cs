namespace Biblioteca.View
{
    partial class MultaView
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
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.gridMulta = new System.Windows.Forms.DataGridView();
            this.pbPagar = new System.Windows.Forms.Button();
            this.pbAbonar = new System.Windows.Forms.Button();
            this.pbObservacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridMulta
            // 
            this.gridMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMulta.Location = new System.Drawing.Point(12, 12);
            this.gridMulta.Name = "gridMulta";
            this.gridMulta.Size = new System.Drawing.Size(759, 202);
            this.gridMulta.TabIndex = 0;
            // 
            // pbPagar
            // 
            this.pbPagar.Location = new System.Drawing.Point(696, 238);
            this.pbPagar.Name = "pbPagar";
            this.pbPagar.Size = new System.Drawing.Size(75, 23);
            this.pbPagar.TabIndex = 1;
            this.pbPagar.Text = "Pagar";
            this.pbPagar.UseVisualStyleBackColor = true;
            this.pbPagar.Click += new System.EventHandler(this.pbPagar_Click);
            // 
            // pbAbonar
            // 
            this.pbAbonar.Location = new System.Drawing.Point(615, 238);
            this.pbAbonar.Name = "pbAbonar";
            this.pbAbonar.Size = new System.Drawing.Size(75, 23);
            this.pbAbonar.TabIndex = 2;
            this.pbAbonar.Text = "Abonar";
            this.pbAbonar.UseVisualStyleBackColor = true;
            this.pbAbonar.Click += new System.EventHandler(this.pbAbonar_Click);
            // 
            // pbObservacao
            // 
            this.pbObservacao.Location = new System.Drawing.Point(534, 238);
            this.pbObservacao.Name = "pbObservacao";
            this.pbObservacao.Size = new System.Drawing.Size(75, 23);
            this.pbObservacao.TabIndex = 3;
            this.pbObservacao.Text = "Observação";
            this.pbObservacao.UseVisualStyleBackColor = true;
            this.pbObservacao.Click += new System.EventHandler(this.pbObservacao_Click);
            // 
            // MultaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 273);
            this.Controls.Add(this.pbObservacao);
            this.Controls.Add(this.pbAbonar);
            this.Controls.Add(this.pbPagar);
            this.Controls.Add(this.gridMulta);
            this.Name = "MultaView";
            this.Text = "MultaView";
            this.Load += new System.EventHandler(this.MultaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.DataGridView gridMulta;
        private System.Windows.Forms.Button pbPagar;
        private System.Windows.Forms.Button pbAbonar;
        private System.Windows.Forms.Button pbObservacao;
    }
}