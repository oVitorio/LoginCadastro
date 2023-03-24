using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCadastro
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuarioCadastro.Text.Length != 0 && txtBoxEmail.Text.Length != 0 && txtBoxSenhaCadastro.Text.Length != 0 && txtBoxConfirmaSenhaCadastro.Text.Length != 0)
            {

                if (txtBoxSenhaCadastro.Text == txtBoxConfirmaSenhaCadastro.Text)
                {
                    Form1 formsHome = new Form1();
                    formsHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("As Senhas não são identicas", "ERRO");
                }
            }
            else
            {
                MessageBox.Show("Todos os capos devem ser preenchidos", "ERRO");
            }

        }
    }
}
