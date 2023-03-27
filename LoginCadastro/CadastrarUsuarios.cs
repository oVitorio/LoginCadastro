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
    public partial class CadastrarUsuarios : Form
    {
        public CadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtBoxUsuarioCadastro.Text.Length != 0 && txtBoxEmail.Text.Length != 0 && txtBoxSenhaCadastro.Text.Length != 0 && txtBoxConfirmaSenhaCadastro.Text.Length != 0)
            {
                if(txtBoxSenhaCadastro.Text == txtBoxConfirmaSenhaCadastro.Text)
                {

                    string usuario = txtBoxUsuarioCadastro.Text;
                    string senha = txtBoxSenhaCadastro.Text;
                    string email = txtBoxEmail.Text;
                    MyslqAdapiter adapiter = new MyslqAdapiter();
                    adapiter.sqlQuerryInsert("usuarios", " usuario, senha, email", $" {usuario},{senha},{email}");
                    //MessageBox.Show("usuario cadastrado");
                    Form1 formslogin = new Form1();
                    formslogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("as senha não são identicas");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
