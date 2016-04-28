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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.gridMulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMulta.Location = new System.Drawing.Point(12, 12);
            this.gridMulta.Name = "gridMulta";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.gridMulta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridMulta.RowTemplate.Height = 30;
            this.gridMulta.Size = new System.Drawing.Size(759, 202);
            this.gridMulta.TabIndex = 0;
            // 
            // pbPagar
            // 
            this.pbPagar.BackColor = System.Drawing.SystemColors.Control;
            this.pbPagar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbPagar.Location = new System.Drawing.Point(661, 230);
            this.pbPagar.Name = "pbPagar";
            this.pbPagar.Size = new System.Drawing.Size(110, 31);
            this.pbPagar.TabIndex = 1;
            this.pbPagar.Text = "Pagar";
            this.pbPagar.UseVisualStyleBackColor = false;
            this.pbPagar.Click += new System.EventHandler(this.pbPagar_Click);
            // 
            // pbAbonar
            // 
            this.pbAbonar.BackColor = System.Drawing.SystemColors.Control;
            this.pbAbonar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbAbonar.Location = new System.Drawing.Point(545, 230);
            this.pbAbonar.Name = "pbAbonar";
            this.pbAbonar.Size = new System.Drawing.Size(110, 31);
            this.pbAbonar.TabIndex = 2;
            this.pbAbonar.Text = "Abonar";
            this.pbAbonar.UseVisualStyleBackColor = false;
            this.pbAbonar.Click += new System.EventHandler(this.pbAbonar_Click);
            // 
            // pbObservacao
            // 
            this.pbObservacao.BackColor = System.Drawing.SystemColors.Control;
            this.pbObservacao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbObservacao.Location = new System.Drawing.Point(429, 230);
            this.pbObservacao.Name = "pbObservacao";
            this.pbObservacao.Size = new System.Drawing.Size(110, 31);
            this.pbObservacao.TabIndex = 3;
            this.pbObservacao.Text = "Observação";
            this.pbObservacao.UseVisualStyleBackColor = false;
            this.pbObservacao.Click += new System.EventHandler(this.pbObservacao_Click);
            // 
            // MultaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(783, 273);
            this.Controls.Add(this.pbObservacao);
            this.Controls.Add(this.pbAbonar);
            this.Controls.Add(this.pbPagar);
            this.Controls.Add(this.gridMulta);
            this.Name = "MultaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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