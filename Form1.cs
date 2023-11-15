namespace Folha_Pagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = "andre";
            string senha = "123456";
            if (txtemail.Text.Equals(email) && txtsenha.Text.Equals(senha))
            {
                Forms.Form_MenuPrincipal form = new Forms.Form_MenuPrincipal();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalida");
                return;
            }
            


        }
    }
}