namespace Biblioteca.View
{
    partial class UsuarioView
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
            this.pbVoltar = new System.Windows.Forms.Button();
            this.pbCriar = new System.Windows.Forms.Button();
            this.pbEditar = new System.Windows.Forms.Button();
            this.pbExcluir = new System.Windows.Forms.Button();
            this.gridPerfil = new System.Windows.Forms.DataGridView();
            this.pERFILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.USUARIOTableAdapter();
            this.pERFILTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.PERFILTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVoltar
            // 
            this.pbVoltar.Location = new System.Drawing.Point(655, 239);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(101, 23);
            this.pbVoltar.TabIndex = 14;
            this.pbVoltar.Text = "&Voltar";
            this.pbVoltar.UseVisualStyleBackColor = true;
            this.pbVoltar.Click += new System.EventHandler(this.pbVoltar_Click);
            // 
            // pbCriar
            // 
            this.pbCriar.Location = new System.Drawing.Point(548, 239);
            this.pbCriar.Name = "pbCriar";
            this.pbCriar.Size = new System.Drawing.Size(101, 23);
            this.pbCriar.TabIndex = 13;
            this.pbCriar.Text = "&Criar";
            this.pbCriar.UseVisualStyleBackColor = true;
            this.pbCriar.Click += new System.EventHandler(this.pbCriar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Location = new System.Drawing.Point(441, 239);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(101, 23);
            this.pbEditar.TabIndex = 12;
            this.pbEditar.Text = "&Editar";
            this.pbEditar.UseVisualStyleBackColor = true;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Location = new System.Drawing.Point(334, 239);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 23);
            this.pbExcluir.TabIndex = 11;
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
            this.sobrenomeDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.fkPerfilDataGridViewTextBoxColumn});
            this.gridPerfil.DataSource = this.uSUARIOBindingSource;
            this.gridPerfil.Location = new System.Drawing.Point(12, 12);
            this.gridPerfil.Name = "gridPerfil";
            this.gridPerfil.ReadOnly = true;
            this.gridPerfil.Size = new System.Drawing.Size(744, 221);
            this.gridPerfil.TabIndex = 10;
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
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // pERFILTableAdapter
            // 
            this.pERFILTableAdapter.ClearBeforeFill = true;
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
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            this.sobrenomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sobrenomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dtNascimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dtNascimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "dtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            this.dtNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkPerfilDataGridViewTextBoxColumn
            // 
            this.fkPerfilDataGridViewTextBoxColumn.DataPropertyName = "fkPerfil";
            this.fkPerfilDataGridViewTextBoxColumn.DataSource = this.pERFILBindingSource;
            this.fkPerfilDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.fkPerfilDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fkPerfilDataGridViewTextBoxColumn.HeaderText = "fkPerfil";
            this.fkPerfilDataGridViewTextBoxColumn.Name = "fkPerfilDataGridViewTextBoxColumn";
            this.fkPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkPerfilDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkPerfilDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkPerfilDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 279);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridPerfil);
            this.Name = "UsuarioView";
            this.Text = "UsuarioView";
            this.Load += new System.EventHandler(this.UsuarioView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pbVoltar;
        private System.Windows.Forms.Button pbCriar;
        private System.Windows.Forms.Button pbEditar;
        private System.Windows.Forms.Button pbExcluir;
        private System.Windows.Forms.DataGridView gridPerfil;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private bibliotecaDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.BindingSource pERFILBindingSource;
        private bibliotecaDataSetTableAdapters.PERFILTableAdapter pERFILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkPerfilDataGridViewTextBoxColumn;
    }
}