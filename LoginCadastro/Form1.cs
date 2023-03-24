namespace LoginCadastro
{
    public partial class Form1 : Form
    {
        string mockSenha = "1234";
        string mockUsuario = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUsuario.Text;
            string senha = txtBoxSenha.Text;

            if (usuario == mockUsuario && senha == mockSenha)
            {

                home formHome = new home();
                formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalidos", "ERRO");
            }
        }

        private void LnkLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastrar formCadastrar = new Cadastrar();
            formCadastrar.Show();
            this.Hide();
        }
    }
}