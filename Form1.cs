using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;


namespace WinFormsExercicio_1
{
    public partial class Form1 : Form
    {

        List<ListaProduto> listaProduto = new List<ListaProduto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            double total = 0;
            foreach (ListaProduto produto in listaProduto)
            {
                total += produto.SubTotal;
            }
            textBox_Total.Text = string.Format("{0:C}", total);
        }

        private void button_AdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Quantidade.Text == "0")
                {
                    throw new Exception("Quantidade não pode ser ZERO");
                }

                listaProduto.Add(new ListaProduto(textBox_Produto.Text,
                                                  Convert.ToInt32(textBox_Quantidade.Text),
                                                  Convert.ToDouble(textBox_PrecoUnitario.Text),
                                                  Convert.ToDouble(Convert.ToInt32(textBox_Quantidade.Text) * Convert.ToDouble(textBox_PrecoUnitario.Text))));


                richTextBox_Produto.Clear();
                richTextBox_Quantidade.Clear();
                richTextBox_precoUnitario.Clear();
                richTextBox_SubTotal.Clear();

                foreach (ListaProduto produto in listaProduto)
                {
                    richTextBox_Produto.Text += produto.Produto + "\n";
                    richTextBox_Quantidade.Text += produto.Quantidade + "\n";
                    richTextBox_precoUnitario.Text += string.Format("{0:C}", produto.PrecoUnitario) + "\n";
                    richTextBox_SubTotal.Text += string.Format("{0:C}", produto.SubTotal) + "\n";
                }

                textBox_Produto.Clear();
                textBox_Quantidade.Clear();
                textBox_PrecoUnitario.Clear();
                textBox_SubTotal.Clear();

                CalcularTotal();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_CancelarVenda_Click(object sender, EventArgs e)
        {
            textBox_Produto.Clear();
            textBox_Quantidade.Clear();
            textBox_PrecoUnitario.Clear();
            textBox_SubTotal.Clear();

            richTextBox_Produto.Clear();
            richTextBox_Quantidade.Clear();
            richTextBox_precoUnitario.Clear();
            richTextBox_SubTotal.Clear();
        }

        private void button_RemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Produto.Clear();
                richTextBox_Quantidade.Clear();
                richTextBox_precoUnitario.Clear();
                richTextBox_SubTotal.Clear();

                if (listaProduto.Count == 0)
                {
                    throw new Exception("Lista vazia");
                }

                listaProduto.Remove(listaProduto.Last());

                foreach (ListaProduto produto in listaProduto)
                {
                    richTextBox_Produto.Text += produto.Produto + "\n";
                    richTextBox_Quantidade.Text += produto.Quantidade + "\n";
                    richTextBox_precoUnitario.Text += string.Format("{0:C}", produto.PrecoUnitario) + "\n";
                    richTextBox_SubTotal.Text += string.Format("{0:C}", produto.SubTotal) + "\n";
                }
                CalcularTotal();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_FecharVenda_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_PrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }
        private void CalcularSubTotal()
        {
            if (textBox_Quantidade.Text != "")
            {
                if (textBox_PrecoUnitario.Text != "")
                {
                    double total = 0;
                    total = Convert.ToDouble(Convert.ToInt32(textBox_Quantidade.Text) * Convert.ToDouble(textBox_PrecoUnitario.Text));
                    textBox_SubTotal.Text = string.Format("{0:C}", total);
                }

            }
        }

        private void textBox_PrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void textBox_Quantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }
    }
}