namespace Biblioteca.View
{
    partial class ExemplarViewEditar
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
            this.pbSalvar = new System.Windows.Forms.Button();
            this.pbCancelar = new System.Windows.Forms.Button();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca.bibliotecaDataSet();
            this.aUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPerdido = new System.Windows.Forms.CheckBox();
            this.aUTORTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.AUTORTableAdapter();
            this.lIVROTableAdapter = new Biblioteca.bibliotecaDataSetTableAdapters.LIVROTableAdapter();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSalvar
            // 
            this.pbSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.pbSalvar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbSalvar.Location = new System.Drawing.Point(236, 217);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(86, 29);
            this.pbSalvar.TabIndex = 4;
            this.pbSalvar.Text = "&Salvar";
            this.pbSalvar.UseVisualStyleBackColor = false;
            this.pbSalvar.Click += new System.EventHandler(this.pbSalvar_Click);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.pbCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbCancelar.Location = new System.Drawing.Point(328, 217);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(86, 29);
            this.pbCancelar.TabIndex = 5;
            this.pbCancelar.Text = "&Cancelar";
            this.pbCancelar.UseVisualStyleBackColor = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // cbLivro
            // 
            this.cbLivro.DataSource = this.lIVROBindingSource;
            this.cbLivro.DisplayMember = "titulo";
            this.cbLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLivro.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(76, 170);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(338, 30);
            this.cbLivro.TabIndex = 3;
            this.cbLivro.ValueMember = "id";
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
            // aUTORBindingSource
            // 
            this.aUTORBindingSource.DataMember = "AUTOR";
            this.aUTORBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(76, 71);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 19);
            this.txtId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // chkPerdido
            // 
            this.chkPerdido.AutoSize = true;
            this.chkPerdido.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPerdido.Location = new System.Drawing.Point(21, 100);
            this.chkPerdido.Name = "chkPerdido";
            this.chkPerdido.Size = new System.Drawing.Size(87, 26);
            this.chkPerdido.TabIndex = 1;
            this.chkPerdido.Text = "Perdido";
            this.chkPerdido.UseVisualStyleBackColor = true;
            // 
            // aUTORTableAdapter
            // 
            this.aUTORTableAdapter.ClearBeforeFill = true;
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "1 Consulta Interna",
            "2 Locação"});
            this.cbTipo.Location = new System.Drawing.Point(76, 132);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(150, 30);
            this.cbTipo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Biblioteca.Properties.Resources.exemplar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(13, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 50);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 56);
            this.panel1.TabIndex = 15;
            // 
            // ExemplarViewEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(433, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.chkPerdido);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.cbLivro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ExemplarViewEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExemplarViewEditar";
            this.Load += new System.EventHandler(this.ExemplarViewEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbSalvar;
        private System.Windows.Forms.Button pbCancelar;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPerdido;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource aUTORBindingSource;
        private bibliotecaDataSetTableAdapters.AUTORTableAdapter aUTORTableAdapter;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private bibliotecaDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}