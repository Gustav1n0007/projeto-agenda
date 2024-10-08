namespace projeto_agenda
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(37, 38);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(350, 42);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Nome de usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(37, 174);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(139, 42);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Verdana", 20F);
            txtUser.Location = new Point(37, 99);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 58);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Verdana", 20F);
            txtSenha.Location = new Point(37, 234);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(350, 58);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Red;
            btnCadastrar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(217, 317);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(170, 58);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Enabled = false;
            btnLogin.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(37, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 58);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Button btnLogin;
    }
}
