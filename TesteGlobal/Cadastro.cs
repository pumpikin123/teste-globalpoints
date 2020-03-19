using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TesteGlobal
{
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GT5HTDC;Initial Catalog=globall;Integrated Security=True");
        SqlCommand comando = new SqlCommand();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'globallDataSet2.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.globallDataSet2.produtos);
            // TODO: esta linha de código carrega dados na tabela 'globallDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            comando.Connection = conn;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conn.Open();
                    comando.CommandText = "INSERT INTO produtos (nome,valor) VALUES ('" + txtProd.Text + "','" + txtVal.Text + "')";
                    txtVal.Text.Replace(',', '.');
                    MessageBox.Show("Cadastrado");

                    txtProd.Clear();
                    txtVal.Clear();
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro desconhecido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta a = new Consulta();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
