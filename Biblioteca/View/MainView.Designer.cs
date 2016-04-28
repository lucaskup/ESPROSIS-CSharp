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
            this.pbLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbDevolucao = new System.Windows.Forms.Button();
            this.pbMulta = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.Button();
            this.pbEmprestimo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAutor
            // 
            this.pbAutor.BackgroundImage = global::Biblioteca.Properties.Resources.autor;
            this.pbAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAutor.FlatAppearance.BorderSize = 0;
            this.pbAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbAutor.Location = new System.Drawing.Point(214, 27);
            this.pbAutor.Name = "pbAutor";
            this.pbAutor.Size = new System.Drawing.Size(89, 84);
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
            this.pbLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLivro.FlatAppearance.BorderSize = 0;
            this.pbLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbLivro.Location = new System.Drawing.Point(16, 27);
            this.pbLivro.Name = "pbLivro";
            this.pbLivro.Size = new System.Drawing.Size(89, 84);
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
            this.pbExemplar.Location = new System.Drawing.Point(115, 27);
            this.pbExemplar.Name = "pbExemplar";
            this.pbExemplar.Size = new System.Drawing.Size(89, 84);
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
            this.pbPerfil.Location = new System.Drawing.Point(313, 27);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(89, 84);
            this.pbPerfil.TabIndex = 3;
            this.toolTip1.SetToolTip(this.pbPerfil, "Perfil");
            this.pbPerfil.UseVisualStyleBackColor = true;
            this.pbPerfil.Click += new System.EventHandler(this.pbPerfil_Click);
            this.pbPerfil.MouseEnter += new System.EventHandler(this.pbPerfil_MouseEnter);
            this.pbPerfil.MouseLeave += new System.EventHandler(this.pbPerfil_MouseLeave);
            // 
            // pbLogin
            // 
            this.pbLogin.BackgroundImage = global::Biblioteca.Properties.Resources.login;
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogin.FlatAppearance.BorderSize = 0;
            this.pbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbLogin.Location = new System.Drawing.Point(16, 25);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(89, 84);
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
            this.lblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(135, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário Logado:";
            // 
            // pbDevolucao
            // 
            this.pbDevolucao.BackgroundImage = global::Biblioteca.Properties.Resources.devolucao;
            this.pbDevolucao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDevolucao.FlatAppearance.BorderSize = 0;
            this.pbDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbDevolucao.Location = new System.Drawing.Point(214, 25);
            this.pbDevolucao.Name = "pbDevolucao";
            this.pbDevolucao.Size = new System.Drawing.Size(89, 84);
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
            this.pbMulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMulta.FlatAppearance.BorderSize = 0;
            this.pbMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMulta.Location = new System.Drawing.Point(313, 25);
            this.pbMulta.Name = "pbMulta";
            this.pbMulta.Size = new System.Drawing.Size(89, 84);
            this.pbMulta.TabIndex = 9;
            this.toolTip1.SetToolTip(this.pbMulta, "Multa");
            this.pbMulta.UseVisualStyleBackColor = true;
            this.pbMulta.Click += new System.EventHandler(this.pbMulta_Click);
            this.pbMulta.MouseEnter += new System.EventHandler(this.pbMulta_MouseEnter);
            this.pbMulta.MouseLeave += new System.EventHandler(this.pbMulta_MouseLeave);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackgroundImage = global::Biblioteca.Properties.Resources.usuario;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsuario.FlatAppearance.BorderSize = 0;
            this.pbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbUsuario.Location = new System.Drawing.Point(412, 27);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(89, 84);
            this.pbUsuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pbUsuario, "Usuário");
            this.pbUsuario.UseVisualStyleBackColor = true;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            this.pbUsuario.MouseEnter += new System.EventHandler(this.pbUsuario_MouseEnter);
            this.pbUsuario.MouseLeave += new System.EventHandler(this.pbUsuario_MouseLeave);
            // 
            // pbEmprestimo
            // 
            this.pbEmprestimo.BackgroundImage = global::Biblioteca.Properties.Resources.emprestimo;
            this.pbEmprestimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmprestimo.FlatAppearance.BorderSize = 0;
            this.pbEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbEmprestimo.Location = new System.Drawing.Point(115, 25);
            this.pbEmprestimo.Name = "pbEmprestimo";
            this.pbEmprestimo.Size = new System.Drawing.Size(89, 84);
            this.pbEmprestimo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.pbEmprestimo, "Empréstimo");
            this.pbEmprestimo.UseVisualStyleBackColor = true;
            this.pbEmprestimo.Click += new System.EventHandler(this.pbEmprestimo_Click);
            this.pbEmprestimo.MouseEnter += new System.EventHandler(this.pbEmprestimo_MouseEnter);
            this.pbEmprestimo.MouseLeave += new System.EventHandler(this.pbEmprestimo_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 76);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(112, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Empréstimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(216, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(334, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Multa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(425, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pbLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbEmprestimo);
            this.groupBox1.Controls.Add(this.pbMulta);
            this.groupBox1.Controls.Add(this.pbDevolucao);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pbPerfil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pbAutor);
            this.groupBox2.Controls.Add(this.pbExemplar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pbUsuario);
            this.groupBox2.Controls.Add(this.pbLivro);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 159);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(333, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Perfil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(234, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label7.Location = new System.Drawing.Point(121, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Exemplar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label8.Location = new System.Drawing.Point(37, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Livro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(170)))));
            this.label9.Location = new System.Drawing.Point(36, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Login";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(540, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pbAutor;
        private System.Windows.Forms.Button pbLivro;
        private System.Windows.Forms.Button pbExemplar;
        private System.Windows.Forms.Button pbPerfil;
        private System.Windows.Forms.Button pbLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pbDevolucao;
        private System.Windows.Forms.Button pbMulta;
        private System.Windows.Forms.Button pbUsuario;
        private System.Windows.Forms.Button pbEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}