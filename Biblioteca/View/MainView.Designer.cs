namespace Biblioteca.View
{
    partial class MainView
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
            this.pbAutor = new System.Windows.Forms.Button();
            this.pbLivro = new System.Windows.Forms.Button();
            this.pbExemplar = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbEmprestimo = new System.Windows.Forms.Button();
            this.pbDevolucao = new System.Windows.Forms.Button();
            this.pbMulta = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pbAutor
            // 
            this.pbAutor.BackgroundImage = global::Biblioteca.Properties.Resources.autor;
            this.pbAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAutor.FlatAppearance.BorderSize = 0;
            this.pbAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbAutor.Location = new System.Drawing.Point(12, 12);
            this.pbAutor.Name = "pbAutor";
            this.pbAutor.Size = new System.Drawing.Size(62, 59);
            this.pbAutor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pbAutor, "Autor");
            this.pbAutor.UseVisualStyleBackColor = true;
            this.pbAutor.Click += new System.EventHandler(this.pbAutor_Click);
            this.pbAutor.MouseEnter += new System.EventHandler(this.pbAutor_MouseEnter);
            this.pbAutor.MouseLeave += new System.EventHandler(this.pbAutor_MouseLeave);
            // 
            // pbLivro
            // 
            this.pbLivro.BackgroundImage = global::Biblioteca.Properties.Resources.livro;
            this.pbLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLivro.FlatAppearance.BorderSize = 0;
            this.pbLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbLivro.Location = new System.Drawing.Point(94, 12);
            this.pbLivro.Name = "pbLivro";
            this.pbLivro.Size = new System.Drawing.Size(62, 59);
            this.pbLivro.TabIndex = 1;
            this.toolTip1.SetToolTip(this.pbLivro, "Livro");
            this.pbLivro.UseVisualStyleBackColor = true;
            this.pbLivro.Click += new System.EventHandler(this.pbLivro_Click);
            this.pbLivro.MouseEnter += new System.EventHandler(this.pbLivro_MouseEnter);
            this.pbLivro.MouseLeave += new System.EventHandler(this.pbLivro_MouseLeave);
            // 
            // pbExemplar
            // 
            this.pbExemplar.BackgroundImage = global::Biblioteca.Properties.Resources.exemplar;
            this.pbExemplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExemplar.FlatAppearance.BorderSize = 0;
            this.pbExemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbExemplar.Location = new System.Drawing.Point(179, 12);
            this.pbExemplar.Name = "pbExemplar";
            this.pbExemplar.Size = new System.Drawing.Size(62, 59);
            this.pbExemplar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.pbExemplar, "Exemplar");
            this.pbExemplar.UseVisualStyleBackColor = true;
            this.pbExemplar.Click += new System.EventHandler(this.pbExemplar_Click);
            this.pbExemplar.MouseEnter += new System.EventHandler(this.pbExemplar_MouseEnter);
            this.pbExemplar.MouseLeave += new System.EventHandler(this.pbExemplar_MouseLeave);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BackgroundImage = global::Biblioteca.Properties.Resources.perfil;
            this.pbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPerfil.FlatAppearance.BorderSize = 0;
            this.pbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbPerfil.Location = new System.Drawing.Point(271, 12);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(62, 59);
            this.pbPerfil.TabIndex = 3;
            this.toolTip1.SetToolTip(this.pbPerfil, "Perfil");
            this.pbPerfil.UseVisualStyleBackColor = true;
            this.pbPerfil.Click += new System.EventHandler(this.pbPerfil_Click);
            this.pbPerfil.MouseEnter += new System.EventHandler(this.pbPerfil_MouseEnter);
            this.pbPerfil.MouseLeave += new System.EventHandler(this.pbPerfil_MouseLeave);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackgroundImage = global::Biblioteca.Properties.Resources.usuario;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsuario.FlatAppearance.BorderSize = 0;
            this.pbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbUsuario.Location = new System.Drawing.Point(363, 12);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(62, 59);
            this.pbUsuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pbUsuario, "Usuário");
            this.pbUsuario.UseVisualStyleBackColor = true;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            this.pbUsuario.MouseEnter += new System.EventHandler(this.pbUsuario_MouseEnter);
            this.pbUsuario.MouseLeave += new System.EventHandler(this.pbUsuario_MouseLeave);
            // 
            // pbLogin
            // 
            this.pbLogin.BackgroundImage = global::Biblioteca.Properties.Resources.login;
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogin.FlatAppearance.BorderSize = 0;
            this.pbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbLogin.Location = new System.Drawing.Point(12, 77);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(62, 59);
            this.pbLogin.TabIndex = 5;
            this.toolTip1.SetToolTip(this.pbLogin, "Login");
            this.pbLogin.UseVisualStyleBackColor = true;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            this.pbLogin.MouseEnter += new System.EventHandler(this.pbLogin_MouseEnter);
            this.pbLogin.MouseLeave += new System.EventHandler(this.pbLogin_MouseLeave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(111, 100);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 20);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário Logado:";
            // 
            // pbEmprestimo
            // 
            this.pbEmprestimo.BackgroundImage = global::Biblioteca.Properties.Resources.emprestimo;
            this.pbEmprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmprestimo.FlatAppearance.BorderSize = 0;
            this.pbEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbEmprestimo.Location = new System.Drawing.Point(12, 142);
            this.pbEmprestimo.Name = "pbEmprestimo";
            this.pbEmprestimo.Size = new System.Drawing.Size(62, 59);
            this.pbEmprestimo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.pbEmprestimo, "Empréstimo");
            this.pbEmprestimo.UseVisualStyleBackColor = true;
            this.pbEmprestimo.Click += new System.EventHandler(this.pbEmprestimo_Click);
            this.pbEmprestimo.MouseEnter += new System.EventHandler(this.pbEmprestimo_MouseEnter);
            this.pbEmprestimo.MouseLeave += new System.EventHandler(this.pbEmprestimo_MouseLeave);
            // 
            // pbDevolucao
            // 
            this.pbDevolucao.BackgroundImage = global::Biblioteca.Properties.Resources.devolucao;
            this.pbDevolucao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDevolucao.FlatAppearance.BorderSize = 0;
            this.pbDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbDevolucao.Location = new System.Drawing.Point(94, 142);
            this.pbDevolucao.Name = "pbDevolucao";
            this.pbDevolucao.Size = new System.Drawing.Size(62, 59);
            this.pbDevolucao.TabIndex = 8;
            this.toolTip1.SetToolTip(this.pbDevolucao, "Devolução");
            this.pbDevolucao.UseVisualStyleBackColor = true;
            this.pbDevolucao.Click += new System.EventHandler(this.pbDevolucao_Click);
            this.pbDevolucao.MouseEnter += new System.EventHandler(this.pbDevolucao_MouseEnter);
            this.pbDevolucao.MouseLeave += new System.EventHandler(this.pbDevolucao_MouseLeave);
            // 
            // pbMulta
            // 
            this.pbMulta.BackgroundImage = global::Biblioteca.Properties.Resources.multa;
            this.pbMulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMulta.FlatAppearance.BorderSize = 0;
            this.pbMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMulta.Location = new System.Drawing.Point(179, 142);
            this.pbMulta.Name = "pbMulta";
            this.pbMulta.Size = new System.Drawing.Size(62, 59);
            this.pbMulta.TabIndex = 9;
            this.toolTip1.SetToolTip(this.pbMulta, "Multa");
            this.pbMulta.UseVisualStyleBackColor = true;
            this.pbMulta.Click += new System.EventHandler(this.pbMulta_Click);
            this.pbMulta.MouseEnter += new System.EventHandler(this.pbMulta_MouseEnter);
            this.pbMulta.MouseLeave += new System.EventHandler(this.pbMulta_MouseLeave);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(431, 208);
            this.Controls.Add(this.pbMulta);
            this.Controls.Add(this.pbDevolucao);
            this.Controls.Add(this.pbEmprestimo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.pbExemplar);
            this.Controls.Add(this.pbLivro);
            this.Controls.Add(this.pbAutor);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbAutor;
        private System.Windows.Forms.Button pbLivro;
        private System.Windows.Forms.Button pbExemplar;
        private System.Windows.Forms.Button pbPerfil;
        private System.Windows.Forms.Button pbUsuario;
        private System.Windows.Forms.Button pbLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button pbEmprestimo;
        private System.Windows.Forms.Button pbDevolucao;
        private System.Windows.Forms.Button pbMulta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}