using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TesteGlobal
{
    public partial class Consulta : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GT5HTDC;Initial Catalog=globall;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        int i = 0;
        int cod;
        double val1, val2, resu;

        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Select * from produtos Where nome='" + cmb1.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.Read())
            {
                cmb1.Text = Convert.ToString(dr["nome"]);
                txtValor.Text = Convert.ToString(dr["valor"]);
                cod = Convert.ToInt32(dr["cod_prod"]);
            }

            btnAdd.Visible = true;
            conn.Close();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'globallDataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.globallDataSet1.produtos);
            // TODO: esta linha de código carrega dados na tabela 'globallDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.

            comando.Connection = conn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gdTabela.Rows.Add();
            this.gdTabela.Rows[i].Cells[0].Value = cmb1.Text;
            this.gdTabela.Rows[i].Cells[1].Value = txtQuant.Text;
            this.gdTabela.Rows[i].Cells[2].Value = txtValor.Text;
            i++;

            conn.Open();
            comando.CommandText = "select valor from produtos where cod_prod ='" + cod + "'";
            dr = comando.ExecuteReader();

            
            val1 = double.Parse(txtQuant.Text);
            val2 = double.Parse(txtValor.Text);
            resu += val1 * val2;

            label1.Text = "R$ " + Convert.ToString(resu);

            conn.Close();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            Entrega b = new Entrega(resu);
            b.ShowDialog();
        }
        private void txtQuant_Leave(object sender, EventArgs e)
        {
            if (txtQuant.Text != null)
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
