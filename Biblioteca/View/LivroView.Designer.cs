namespace Biblioteca.View
{
    partial class LivroView
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
            this.gridLivros = new System.Windows.Forms.DataGridView();
            this.aUTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbVoltar = new System.Windows.Forms.Button();
            this.pbCriar = new System.Windows.Forms.Button();
            this.pbEditar = new System.Windows.Forms.Button();
            this.pbExcluir = new System.Windows.Forms.Button();
            this.lIVROTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.LIVROTableAdapter();
            this.aUTORTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.AUTORTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLivros
            // 
            this.gridLivros.AllowUserToAddRows = false;
            this.gridLivros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.gridLivros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLivros.AutoGenerateColumns = false;
            this.gridLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fkAutorDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn});
            this.gridLivros.DataSource = this.lIVROBindingSource;
            this.gridLivros.Location = new System.Drawing.Point(13, 13);
            this.gridLivros.Name = "gridLivros";
            this.gridLivros.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.gridLivros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLivros.RowTemplate.Height = 30;
            this.gridLivros.Size = new System.Drawing.Size(734, 212);
            this.gridLivros.TabIndex = 0;
            // 
            // aUTORBindingSource1
            // 
            this.aUTORBindingSource1.DataMember = "AUTOR";
            this.aUTORBindingSource1.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIVROBindingSource
            // 
            this.lIVROBindingSource.DataMember = "LIVRO";
            this.lIVROBindingSource.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // aUTORBindingSource
            // 
            this.aUTORBindingSource.DataMember = "AUTOR";
            this.aUTORBindingSource.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.pbVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbVoltar.Location = new System.Drawing.Point(645, 246);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(101, 29);
            this.pbVoltar.TabIndex = 8;
            this.pbVoltar.Text = "&Voltar";
            this.pbVoltar.UseVisualStyleBackColor = false;
            this.pbVoltar.Click += new System.EventHandler(this.pbVoltar_Click);
            // 
            // pbCriar
            // 
            this.pbCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCriar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCriar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbCriar.Location = new System.Drawing.Point(538, 246);
            this.pbCriar.Name = "pbCriar";
            this.pbCriar.Size = new System.Drawing.Size(101, 29);
            this.pbCriar.TabIndex = 7;
            this.pbCriar.Text = "&Criar";
            this.pbCriar.UseVisualStyleBackColor = false;
            this.pbCriar.Click += new System.EventHandler(this.pbCriar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEditar.BackColor = System.Drawing.SystemColors.Control;
            this.pbEditar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbEditar.Location = new System.Drawing.Point(431, 246);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(101, 29);
            this.pbEditar.TabIndex = 6;
            this.pbEditar.Text = "&Editar";
            this.pbEditar.UseVisualStyleBackColor = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.pbExcluir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbExcluir.Location = new System.Drawing.Point(324, 246);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 29);
            this.pbExcluir.TabIndex = 5;
            this.pbExcluir.Text = "Exclui&r";
            this.pbExcluir.UseVisualStyleBackColor = false;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // aUTORTableAdapter
            // 
            this.aUTORTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 40F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkAutorDataGridViewTextBoxColumn
            // 
            this.fkAutorDataGridViewTextBoxColumn.DataPropertyName = "fkAutor";
            this.fkAutorDataGridViewTextBoxColumn.DataSource = this.aUTORBindingSource1;
            this.fkAutorDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.fkAutorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fkAutorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.fkAutorDataGridViewTextBoxColumn.Name = "fkAutorDataGridViewTextBoxColumn";
            this.fkAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkAutorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkAutorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkAutorDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.FillWeight = 50F;
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LivroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(759, 280);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridLivros);
            this.Name = "LivroView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LivroView";
            this.Load += new System.EventHandler(this.LivroView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private System.Windows.Forms.DataGridView gridLivros;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private bibliotecaDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private System.Windows.Forms.Button pbVoltar;
        private System.Windows.Forms.Button pbCriar;
        private System.Windows.Forms.Button pbEditar;
        private System.Windows.Forms.Button pbExcluir;
        private System.Windows.Forms.BindingSource aUTORBindingSource;
        private bibliotecaDataSetTableAdapters.AUTORTableAdapter aUTORTableAdapter;
        private System.Windows.Forms.BindingSource aUTORBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
    }
}