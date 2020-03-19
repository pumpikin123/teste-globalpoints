using System;
using System.Windows.Forms;

namespace TesteGlobal
{
    public partial class Entrega : MetroFramework.Forms.MetroForm
    {
        double valortotal = 0;
        public Entrega()
        {
            InitializeComponent();
        }

        public Entrega(double Valor)
        {
            InitializeComponent();
            valortotal = Valor;
            lblTotal.Text += " R$ " + valortotal;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var WS = new wfconsulta.AtendeClienteClient();
                var resposta = WS.consultaCEP(txtCep.Text);
                txtRua.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
                txtEstado.Text = resposta.uf;
                

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os campos digitados!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                CamposVazios(this);
                MessageBox.Show("Pedido finalizado");
                txtCep.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                txtRua.Clear();
                valortotal = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
            public static void CamposVazios(Control _ctrl)
            {
                foreach (Control c in _ctrl.Controls)
                {
                    if (c.HasChildren)
                    {
                        CamposVazios(c);
                    }
                    else if (c is TextBox)
                    {
                        if (String.IsNullOrEmpty(((TextBox)c).Text))
                        {
                            throw new Exception("Campo " + c.Text + " está vazio");
                        }
                    }
                }
            }

        private void Entrega_Load(object sender, EventArgs e)
        {

        }
    }
    }

