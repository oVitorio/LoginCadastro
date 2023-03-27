namespace LoginCadastro
{
    partial class CadastrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUsuarios));
            txtBoxUsuarioCadastro = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            txtBoxSenhaCadastro = new TextBox();
            label1 = new Label();
            txtBoxEmail = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            txtBoxConfirmaSenhaCadastro = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxUsuarioCadastro
            // 
            txtBoxUsuarioCadastro.Location = new Point(97, 114);
            txtBoxUsuarioCadastro.Name = "txtBoxUsuarioCadastro";
            txtBoxUsuarioCadastro.Size = new Size(256, 23);
            txtBoxUsuarioCadastro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(97, 222);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(135, 366);
            button1.Name = "button1";
            button1.Size = new Size(177, 35);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 152);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(209, 404);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(41, 18);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtBoxSenhaCadastro
            // 
            txtBoxSenhaCadastro.Location = new Point(97, 254);
            txtBoxSenhaCadastro.Name = "txtBoxSenhaCadastro";
            txtBoxSenhaCadastro.Size = new Size(256, 23);
            txtBoxSenhaCadastro.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(97, 82);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 2;
            label1.Text = "Usuario ";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(97, 184);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(256, 23);
            txtBoxEmail.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxConfirmaSenhaCadastro);
            panel1.Controls.Add(txtBoxUsuarioCadastro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtBoxSenhaCadastro);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxEmail);
            panel1.Location = new Point(440, -23);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 497);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(165, 33);
            label5.Name = "label5";
            label5.Size = new Size(133, 29);
            label5.TabIndex = 10;
            label5.Text = "CADASTRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(97, 292);
            label4.Name = "label4";
            label4.Size = new Size(201, 29);
            label4.TabIndex = 9;
            label4.Text = "Confirmar Senha";
            // 
            // txtBoxConfirmaSenhaCadastro
            // 
            txtBoxConfirmaSenhaCadastro.Location = new Point(97, 324);
            txtBoxConfirmaSenhaCadastro.Name = "txtBoxConfirmaSenhaCadastro";
            txtBoxConfirmaSenhaCadastro.Size = new Size(256, 23);
            txtBoxConfirmaSenhaCadastro.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-99, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(524, 443);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // CadastrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "CadastrarUsuarios";
            Text = "CadastrarUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxUsuarioCadastro;
        private Label label3;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox txtBoxSenhaCadastro;
        private Label label1;
        private TextBox txtBoxEmail;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private TextBox txtBoxConfirmaSenhaCadastro;
        private PictureBox pictureBox1;
    }
}