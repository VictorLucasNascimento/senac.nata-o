namespace nataçao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Criar uma intância de Pacientes.
            Aluno alunoNatacao = new Aluno();

            alunoNatacao.Professor = txtProfessor.Text;
            alunoNatacao.Nome = txtNome.Text;
            alunoNatacao.Aula = txtAula.Text;
            alunoNatacao.MarcaçãoDeAula = ll.Text;

            MessageBox.Show("O Aluno " + alunoNatacao.Nome + " foi cadastrado.");
        }

        public void CriadorMackup()
        {
            aluno
        }
    }
}