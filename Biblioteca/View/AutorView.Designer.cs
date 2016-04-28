namespace Biblioteca.View
{
    partial class AutorView
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
            this.gridAutor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.aUTORTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.AUTORTableAdapter();
            this.pbExcluir = new System.Windows.Forms.Button();
            this.pbEditar = new System.Windows.Forms.Button();
            this.pbCriar = new System.Windows.Forms.Button();
            this.pbVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutor
            // 
            this.gridAutor.AllowUserToAddRows = false;
            this.gridAutor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.gridAutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAutor.AutoGenerateColumns = false;
            this.gridAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAutor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridAutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.gridAutor.DataSource = this.aUTORBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAutor.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAutor.Location = new System.Drawing.Point(12, 12);
            this.gridAutor.Name = "gridAutor";
            this.gridAutor.ReadOnly = true;
            this.gridAutor.RowTemplate.Height = 30;
            this.gridAutor.Size = new System.Drawing.Size(455, 213);
            this.gridAutor.TabIndex = 0;
            this.gridAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAutor_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
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
            // 
            // aUTORBindingSource
            // 
            this.aUTORBindingSource.DataMember = "AUTOR";
            this.aUTORBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTORTableAdapter
            // 
            this.aUTORTableAdapter.ClearBeforeFill = true;
            // 
            // pbExcluir
            // 
            this.pbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.pbExcluir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbExcluir.Location = new System.Drawing.Point(45, 239);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(101, 29);
            this.pbExcluir.TabIndex = 1;
            this.pbExcluir.Text = "Exclui&r";
            this.pbExcluir.UseVisualStyleBackColor = false;
            this.pbExcluir.Click += new System.EventHandler(this.pbExcluir_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEditar.BackColor = System.Drawing.SystemColors.Control;
            this.pbEditar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbEditar.Location = new System.Drawing.Point(152, 239);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(101, 29);
            this.pbEditar.TabIndex = 2;
            this.pbEditar.Text = "&Editar";
            this.pbEditar.UseVisualStyleBackColor = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbCriar
            // 
            this.pbCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCriar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCriar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbCriar.Location = new System.Drawing.Point(259, 239);
            this.pbCriar.Name = "pbCriar";
            this.pbCriar.Size = new System.Drawing.Size(101, 29);
            this.pbCriar.TabIndex = 3;
            this.pbCriar.Text = "&Criar";
            this.pbCriar.UseVisualStyleBackColor = false;
            this.pbCriar.Click += new System.EventHandler(this.pbCriar_Click);
            // 
            // pbVoltar
            // 
            this.pbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.pbVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbVoltar.Location = new System.Drawing.Point(366, 239);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(101, 29);
            this.pbVoltar.TabIndex = 4;
            this.pbVoltar.Text = "&Voltar";
            this.pbVoltar.UseVisualStyleBackColor = false;
            this.pbVoltar.Click += new System.EventHandler(this.pbVoltar_Click);
            // 
            // AutorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(479, 277);
            this.Controls.Add(this.pbVoltar);
            this.Controls.Add(this.pbCriar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.gridAutor);
            this.Name = "AutorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutorView";
            this.Load += new System.EventHandler(this.AutorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutor;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource aUTORBindingSource;
        private bibliotecaDataSetTableAdapters.AUTORTableAdapter aUTORTableAdapter;
        private System.Windows.Forms.Button pbExcluir;
        private System.Windows.Forms.Button pbEditar;
        private System.Windows.Forms.Button pbCriar;
        private System.Windows.Forms.Button pbVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}