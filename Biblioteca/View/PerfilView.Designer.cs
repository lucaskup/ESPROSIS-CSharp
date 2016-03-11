namespace Biblioteca.View
{
    partial class PerfilView
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
            this.pbVoltar = new System.Windows.Forms.Button();
            this.pbCriar = new System.Windows.Forms.Button();
            this.pbEditar = new System.Windows.Forms.Button();
            this.pbExcluir = new System.Windows.Forms.Button();
            this.gridPerfil = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtLivrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasParaEmprestimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.pERFILTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.PERFILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVoltar
            // 
            this.pbVoltar.Location = new System.Drawing.Point(554, 239);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(101, 23);
            this.pbVoltar.TabIndex = 9;
            this.pbVoltar.Text = "&Voltar";
            this.pbVoltar.UseVisualStyleBackColor = true;
            this.pbVoltar.Click += new System.EventHandler(this.pbVoltar_Click);
            // 
            // pbCriar
            // 
            this.pbCriar.Location = new System.Drawing.Point(447, 239);
            this.pbCriar.Name = "pbCriar";
            this.pbCriar.Size = new System.Drawing.Size(101, 23);
            this.pbCriar.TabIndex = 8;
            this.pbCriar.Text = "&Criar";
            this.pbCriar.UseVisualStyleBackColor = true;
            this.pbCriar.Click += new System.EventHandler(this.pbCriar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Location = new System.Drawing.Point(340, 239);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(101, 23);
            this.pbEditar.TabIndex = 7;
            this.pbEditar.Text = "&Editar";
            this.pbEditar.UseVisualStyleBackColor = true;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Location = new System.Drawing.Point(233, 239);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 23);
            this.pbExcluir.TabIndex = 6;
            this.pbExcluir.Text = "Exclui&r";
            this.pbExcluir.UseVisualStyleBackColor = true;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // gridPerfil
            // 
            this.gridPerfil.AllowUserToAddRows = false;
            this.gridPerfil.AllowUserToDeleteRows = false;
            this.gridPerfil.AutoGenerateColumns = false;
            this.gridPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.qtLivrosDataGridViewTextBoxColumn,
            this.diasParaEmprestimoDataGridViewTextBoxColumn,
            this.valorMultaDataGridViewTextBoxColumn});
            this.gridPerfil.DataSource = this.pERFILBindingSource;
            this.gridPerfil.Location = new System.Drawing.Point(12, 12);
            this.gridPerfil.Name = "gridPerfil";
            this.gridPerfil.ReadOnly = true;
            this.gridPerfil.Size = new System.Drawing.Size(643, 221);
            this.gridPerfil.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtLivrosDataGridViewTextBoxColumn
            // 
            this.qtLivrosDataGridViewTextBoxColumn.DataPropertyName = "qtLivros";
            this.qtLivrosDataGridViewTextBoxColumn.HeaderText = "qtLivros";
            this.qtLivrosDataGridViewTextBoxColumn.Name = "qtLivrosDataGridViewTextBoxColumn";
            this.qtLivrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasParaEmprestimoDataGridViewTextBoxColumn
            // 
            this.diasParaEmprestimoDataGridViewTextBoxColumn.DataPropertyName = "diasParaEmprestimo";
            this.diasParaEmprestimoDataGridViewTextBoxColumn.HeaderText = "diasParaEmprestimo";
            this.diasParaEmprestimoDataGridViewTextBoxColumn.Name = "diasParaEmprestimoDataGridViewTextBoxColumn";
            this.diasParaEmprestimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorMultaDataGridViewTextBoxColumn
            // 
            this.valorMultaDataGridViewTextBoxColumn.DataPropertyName = "valorMulta";
            this.valorMultaDataGridViewTextBoxColumn.HeaderText = "valorMulta";
            this.valorMultaDataGridViewTextBoxColumn.Name = "valorMultaDataGridViewTextBoxColumn";
            this.valorMultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERFILBindingSource
            // 
            this.pERFILBindingSource.DataMember = "PERFIL";
            this.pERFILBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERFILTableAdapter
            // 
            this.pERFILTableAdapter.ClearBeforeFill = true;
            // 
            // PerfilView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 273);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridPerfil);
            this.Name = "PerfilView";
            this.Text = "PerfilView";
            this.Load += new System.EventHandler(this.PerfilView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pbVoltar;
        private System.Windows.Forms.Button pbCriar;
        private System.Windows.Forms.Button pbEditar;
        private System.Windows.Forms.Button pbExcluir;
        private System.Windows.Forms.DataGridView gridPerfil;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource pERFILBindingSource;
        private bibliotecaDataSetTableAdapters.PERFILTableAdapter pERFILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtLivrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasParaEmprestimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMultaDataGridViewTextBoxColumn;
    }
}