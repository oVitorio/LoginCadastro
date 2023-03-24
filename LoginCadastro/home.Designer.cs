namespace LoginCadastro
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            BtnCadastrar = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 478);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnCadastrar);
            panel1.Location = new Point(483, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 497);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(285, 362);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 4;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(174, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 43);
            label1.TabIndex = 3;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(50, 256);
            button3.Name = "button3";
            button3.Size = new Size(346, 49);
            button3.TabIndex = 2;
            button3.Text = "Cadastrar Colaborador";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(50, 183);
            button2.Name = "button2";
            button2.Size = new Size(346, 49);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Produto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.BackColor = Color.White;
            BtnCadastrar.FlatStyle = FlatStyle.Popup;
            BtnCadastrar.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnCadastrar.Location = new Point(50, 112);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(346, 49);
            BtnCadastrar.TabIndex = 0;
            BtnCadastrar.Text = "Cadastrar Cliente";
            BtnCadastrar.UseVisualStyleBackColor = false;
            BtnCadastrar.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(50, 362);
            button4.Name = "button4";
            button4.Size = new Size(217, 32);
            button4.TabIndex = 5;
            button4.Text = "Listar Cadastro";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 472);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "home";
            Text = "home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button BtnCadastrar;
        private Button button1;
        private Button button4;
    }
}