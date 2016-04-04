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
            this.pbAutor = new System.Windows.Forms.Button();
            this.pbLivro = new System.Windows.Forms.Button();
            this.pbExemplar = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbEmprestimo = new System.Windows.Forms.Button();
            this.pbDevolucao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbAutor
            // 
            this.pbAutor.Location = new System.Drawing.Point(12, 12);
            this.pbAutor.Name = "pbAutor";
            this.pbAutor.Size = new System.Drawing.Size(75, 23);
            this.pbAutor.TabIndex = 0;
            this.pbAutor.Text = "&Autor";
            this.pbAutor.UseVisualStyleBackColor = true;
            this.pbAutor.Click += new System.EventHandler(this.pbAutor_Click);
            // 
            // pbLivro
            // 
            this.pbLivro.Location = new System.Drawing.Point(94, 13);
            this.pbLivro.Name = "pbLivro";
            this.pbLivro.Size = new System.Drawing.Size(75, 23);
            this.pbLivro.TabIndex = 1;
            this.pbLivro.Text = "&Livro";
            this.pbLivro.UseVisualStyleBackColor = true;
            this.pbLivro.Click += new System.EventHandler(this.pbLivro_Click);
            // 
            // pbExemplar
            // 
            this.pbExemplar.Location = new System.Drawing.Point(176, 13);
            this.pbExemplar.Name = "pbExemplar";
            this.pbExemplar.Size = new System.Drawing.Size(75, 23);
            this.pbExemplar.TabIndex = 2;
            this.pbExemplar.Text = "&Exemplar";
            this.pbExemplar.UseVisualStyleBackColor = true;
            this.pbExemplar.Click += new System.EventHandler(this.pbExemplar_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(258, 12);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(75, 23);
            this.pbPerfil.TabIndex = 3;
            this.pbPerfil.Text = "&Perfil";
            this.pbPerfil.UseVisualStyleBackColor = true;
            this.pbPerfil.Click += new System.EventHandler(this.pbPerfil_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Location = new System.Drawing.Point(340, 12);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(75, 23);
            this.pbUsuario.TabIndex = 4;
            this.pbUsuario.Text = "&Usuario";
            this.pbUsuario.UseVisualStyleBackColor = true;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.Location = new System.Drawing.Point(12, 54);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(75, 23);
            this.pbLogin.TabIndex = 5;
            this.pbLogin.Text = "Login";
            this.pbLogin.UseVisualStyleBackColor = true;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(456, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário Logado:";
            // 
            // pbEmprestimo
            // 
            this.pbEmprestimo.Location = new System.Drawing.Point(12, 94);
            this.pbEmprestimo.Name = "pbEmprestimo";
            this.pbEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.pbEmprestimo.TabIndex = 7;
            this.pbEmprestimo.Text = "E&mpréstimo";
            this.pbEmprestimo.UseVisualStyleBackColor = true;
            this.pbEmprestimo.Click += new System.EventHandler(this.pbEmprestimo_Click);
            // 
            // pbDevolucao
            // 
            this.pbDevolucao.Location = new System.Drawing.Point(107, 93);
            this.pbDevolucao.Name = "pbDevolucao";
            this.pbDevolucao.Size = new System.Drawing.Size(75, 23);
            this.pbDevolucao.TabIndex = 8;
            this.pbDevolucao.Text = "&Devolução";
            this.pbDevolucao.UseVisualStyleBackColor = true;
            this.pbDevolucao.Click += new System.EventHandler(this.pbDevolucao_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 312);
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
    }
}