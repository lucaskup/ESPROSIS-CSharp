namespace Biblioteca.View
{
    partial class ExemplarView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbVoltar = new System.Windows.Forms.Button();
            this.pbCriar = new System.Windows.Forms.Button();
            this.pbEditar = new System.Windows.Forms.Button();
            this.pbExcluir = new System.Windows.Forms.Button();
            this.gridAutor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.eXEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXEMPLARTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.EXEMPLARTableAdapter();
            this.lIVROTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.LIVROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.pbVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbVoltar.Location = new System.Drawing.Point(556, 245);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(101, 28);
            this.pbVoltar.TabIndex = 9;
            this.pbVoltar.Text = "&Voltar";
            this.pbVoltar.UseVisualStyleBackColor = false;
            this.pbVoltar.Click += new System.EventHandler(this.pbVoltar_Click);
            // 
            // pbCriar
            // 
            this.pbCriar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCriar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbCriar.Location = new System.Drawing.Point(449, 245);
            this.pbCriar.Name = "pbCriar";
            this.pbCriar.Size = new System.Drawing.Size(101, 28);
            this.pbCriar.TabIndex = 8;
            this.pbCriar.Text = "&Criar";
            this.pbCriar.UseVisualStyleBackColor = false;
            this.pbCriar.Click += new System.EventHandler(this.pbCriar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.BackColor = System.Drawing.SystemColors.Control;
            this.pbEditar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbEditar.Location = new System.Drawing.Point(342, 245);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(101, 28);
            this.pbEditar.TabIndex = 7;
            this.pbEditar.Text = "&Editar";
            this.pbEditar.UseVisualStyleBackColor = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbExcluir
            // 
            this.pbExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.pbExcluir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbExcluir.Location = new System.Drawing.Point(235, 245);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 28);
            this.pbExcluir.TabIndex = 6;
            this.pbExcluir.Text = "Exclui&r";
            this.pbExcluir.UseVisualStyleBackColor = false;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // gridAutor
            // 
            this.gridAutor.AllowUserToAddRows = false;
            this.gridAutor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.gridAutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAutor.AutoGenerateColumns = false;
            this.gridAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAutor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridAutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.perdidoDataGridViewCheckBoxColumn,
            this.tipo,
            this.fkLivroDataGridViewTextBoxColumn});
            this.gridAutor.DataSource = this.eXEMPLARBindingSource;
            this.gridAutor.Location = new System.Drawing.Point(12, 12);
            this.gridAutor.Name = "gridAutor";
            this.gridAutor.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.gridAutor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAutor.RowTemplate.Height = 30;
            this.gridAutor.Size = new System.Drawing.Size(645, 221);
            this.gridAutor.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perdidoDataGridViewCheckBoxColumn
            // 
            this.perdidoDataGridViewCheckBoxColumn.DataPropertyName = "perdido";
            this.perdidoDataGridViewCheckBoxColumn.HeaderText = "Perdido";
            this.perdidoDataGridViewCheckBoxColumn.Name = "perdidoDataGridViewCheckBoxColumn";
            this.perdidoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fkLivroDataGridViewTextBoxColumn
            // 
            this.fkLivroDataGridViewTextBoxColumn.DataPropertyName = "fkLivro";
            this.fkLivroDataGridViewTextBoxColumn.DataSource = this.lIVROBindingSource;
            this.fkLivroDataGridViewTextBoxColumn.DisplayMember = "titulo";
            this.fkLivroDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fkLivroDataGridViewTextBoxColumn.FillWeight = 300F;
            this.fkLivroDataGridViewTextBoxColumn.HeaderText = "Livro";
            this.fkLivroDataGridViewTextBoxColumn.Name = "fkLivroDataGridViewTextBoxColumn";
            this.fkLivroDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkLivroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkLivroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkLivroDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // lIVROBindingSource
            // 
            this.lIVROBindingSource.DataMember = "LIVRO";
            this.lIVROBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXEMPLARBindingSource
            // 
            this.eXEMPLARBindingSource.DataMember = "EXEMPLAR";
            this.eXEMPLARBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // eXEMPLARTableAdapter
            // 
            this.eXEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // ExemplarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(669, 282);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridAutor);
            this.Name = "ExemplarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExemplarView";
            this.Load += new System.EventHandler(this.ExemplarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pbVoltar;
        private System.Windows.Forms.Button pbCriar;
        private System.Windows.Forms.Button pbEditar;
        private System.Windows.Forms.Button pbExcluir;
        private System.Windows.Forms.DataGridView gridAutor;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource eXEMPLARBindingSource;
        private bibliotecaDataSetTableAdapters.EXEMPLARTableAdapter eXEMPLARTableAdapter;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private bibliotecaDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkLivroDataGridViewTextBoxColumn;
    }
}