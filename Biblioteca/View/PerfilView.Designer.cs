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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pbVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.pbVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbVoltar.Location = new System.Drawing.Point(682, 239);
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
            this.pbCriar.Location = new System.Drawing.Point(575, 239);
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
            this.pbEditar.Location = new System.Drawing.Point(468, 239);
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
            this.pbExcluir.Location = new System.Drawing.Point(361, 239);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 28);
            this.pbExcluir.TabIndex = 6;
            this.pbExcluir.Text = "Exclui&r";
            this.pbExcluir.UseVisualStyleBackColor = false;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // gridPerfil
            // 
            this.gridPerfil.AllowUserToAddRows = false;
            this.gridPerfil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.gridPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPerfil.AutoGenerateColumns = false;
            this.gridPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPerfil.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridPerfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.qtLivrosDataGridViewTextBoxColumn,
            this.diasParaEmprestimoDataGridViewTextBoxColumn,
            this.valorMultaDataGridViewTextBoxColumn});
            this.gridPerfil.DataSource = this.pERFILBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPerfil.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPerfil.Location = new System.Drawing.Point(12, 12);
            this.gridPerfil.Name = "gridPerfil";
            this.gridPerfil.ReadOnly = true;
            this.gridPerfil.RowTemplate.Height = 30;
            this.gridPerfil.Size = new System.Drawing.Size(770, 221);
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
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(794, 273);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridPerfil);
            this.Name = "PerfilView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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