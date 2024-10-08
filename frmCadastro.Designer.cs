namespace projeto_agenda
{
    partial class frmCadastro
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
            txtTelefone = new TextBox();
            txtUser = new TextBox();
            lblSenha = new Label();
            lblName = new Label();
            txtRepeteSenha = new TextBox();
            txtSenha = new TextBox();
            lblRepeteSenha = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblTelefone = new Label();
            btnLogin = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(37, 275);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(350, 58);
            txtTelefone.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(37, 63);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 58);
            txtUser.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(37, 336);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(139, 42);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(37, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 42);
            lblName.TabIndex = 4;
            lblName.Text = "Nome";
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.Location = new Point(37, 496);
            txtRepeteSenha.Multiline = true;
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(350, 58);
            txtRepeteSenha.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(37, 381);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(350, 58);
            txtSenha.TabIndex = 10;
            // 
            // lblRepeteSenha
            // 
            lblRepeteSenha.AutoSize = true;
            lblRepeteSenha.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepeteSenha.Location = new Point(37, 442);
            lblRepeteSenha.Name = "lblRepeteSenha";
            lblRepeteSenha.Size = new Size(353, 42);
            lblRepeteSenha.TabIndex = 9;
            lblRepeteSenha.Text = "Repita sua senha";
            lblRepeteSenha.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(37, 124);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(350, 42);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Nome de usuário";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(37, 169);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 58);
            txtUsername.TabIndex = 12;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(37, 230);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(187, 42);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(37, 571);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 58);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Red;
            btnCadastrar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(217, 571);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(170, 58);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 645);
            Controls.Add(btnLogin);
            Controls.Add(btnCadastrar);
            Controls.Add(lblTelefone);
            Controls.Add(txtUsername);
            Controls.Add(txtRepeteSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblRepeteSenha);
            Controls.Add(lblUsername);
            Controls.Add(txtTelefone);
            Controls.Add(txtUser);
            Controls.Add(lblSenha);
            Controls.Add(lblName);
            Name = "frmCadastro";
            Text = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private TextBox txtUser;
        private Label lblSenha;
        private Label lblName;
        private TextBox txtRepeteSenha;
        private TextBox txtSenha;
        private Label lblRepeteSenha;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblTelefone;
        private Button btnLogin;
        private Button btnCadastrar;
    }
}