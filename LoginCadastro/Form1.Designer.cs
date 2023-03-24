namespace LoginCadastro
{
    partial class Form1
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
            btnLogin = new Button();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            LblUsuario = new Label();
            LblSenha = new Label();
            panel1 = new Panel();
            LnkLblCadastrar = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(138, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.AccessibleRole = AccessibleRole.Window;
            txtBoxUsuario.BackColor = SystemColors.Window;
            txtBoxUsuario.Location = new Point(89, 183);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(253, 23);
            txtBoxUsuario.TabIndex = 1;
            txtBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(89, 277);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PasswordChar = '*';
            txtBoxSenha.Size = new Size(253, 23);
            txtBoxSenha.TabIndex = 2;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LblUsuario.ForeColor = Color.Black;
            LblUsuario.Location = new Point(89, 141);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(100, 29);
            LblUsuario.TabIndex = 3;
            LblUsuario.Text = "Usuario";
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LblSenha.ForeColor = Color.Black;
            LblSenha.Location = new Point(89, 235);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(78, 29);
            LblSenha.TabIndex = 4;
            LblSenha.Text = "Senha";
            LblSenha.Click += LblSenha_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(LnkLblCadastrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxSenha);
            panel1.Controls.Add(LblSenha);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(LblUsuario);
            panel1.Controls.Add(txtBoxUsuario);
            panel1.Location = new Point(473, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 497);
            panel1.TabIndex = 5;
            // 
            // LnkLblCadastrar
            // 
            LnkLblCadastrar.AutoSize = true;
            LnkLblCadastrar.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LnkLblCadastrar.LinkColor = Color.White;
            LnkLblCadastrar.Location = new Point(182, 361);
            LnkLblCadastrar.Name = "LnkLblCadastrar";
            LnkLblCadastrar.Size = new Size(73, 18);
            LnkLblCadastrar.TabIndex = 6;
            LnkLblCadastrar.TabStop = true;
            LnkLblCadastrar.Text = "Cadastrar";
            LnkLblCadastrar.LinkClicked += LnkLblCadastrar_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(159, 58);
            label1.Name = "label1";
            label1.Size = new Size(115, 43);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4957136_removebg_preview;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 438);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 472);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void LblSenha_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Label LblUsuario;
        private Label LblSenha;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel LnkLblCadastrar;
    }
}