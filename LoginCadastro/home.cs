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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCliente formCadCliente = new CadastrarCliente();
            formCadCliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarProduto formsCadProduto = new CadastrarProduto();
            formsCadProduto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastrarColaborador formsCadColaborador = new CadastrarColaborador();
            formsCadColaborador.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarCadastros formsListCadastro =  new ListarCadastros();
            formsListCadastro.Show();
            this.Hide();

        }
    }
}
