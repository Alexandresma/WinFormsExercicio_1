namespace WinFormsExercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_AdicionarProduto_Click(object sender, EventArgs e)
        {
            richTextBox_Produto.Text = textBox_Produto.Text;
            richTextBox_Quantidade.Text = textBox_Quantidade.Text;
            richTextBox_precoUnitario.Text = textBox_PrecoUnitario.Text;
            richTextBox_SubTotal.Text = textBox_SubTotal.Text;
        }
    }
}