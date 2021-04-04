using System;
using System.Windows.Forms;

namespace CadConsultaForms
{
    public partial class frmCadastro : Form
    {
        #region Page Load

        // Variáveis
        private string strConexao = "Data Source = CENTER; Initial Catalog = projet; Integrated Security = True";
        private char tipo;
        public int id = 0;
        public string Nome = "";
        public string Email = "";
        public string Fone = "";

        // Construtor
        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(int codigo, char tp)
        {
            InitializeComponent();
            this.id = codigo;
            this.tipo = tp;

            tipo = 'C';
            txtCodigo.Text = id.ToString();
            habilitaBtn(false, true, false, false, true, true, true);
        }

        // Load
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (tipo != 'C')
            {
                tipo = 'I';
                habilitaBtn(true, true, true, false, false, false, true);
            }
            else
            {
                pnlDados.Enabled = false;
                habilitaBtn(false, true, false, false, true, true, true);
            }
        }

        #endregion

        #region Botões

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!Validacao()) return;

            try
            {
                Cad();

                Limpar();

                var resposta = MessageBox.Show("Deseja inserir novo registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta.ToString() == "Yes")
                {
                    tipo = 'I';
                    habilitaBtn(true, true, true, false, false, false, true);
                }
                else Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao(strConexao);
            DALCadastro d = new DALCadastro(c);
            Cadastro ctt = new Cadastro();

            var resposta = MessageBox.Show("Confirmar exclusão do contato", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta.ToString() == "Yes")
            {
                d.Excluir(ctt.Id);
                MessageBox.Show("Registro excluido!");
                Limpar();
                habilitaBtn(true, true, true, false, false, false, true);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tipo = 'U';
            pnlDados.Enabled = true;
            habilitaBtn(true, true, true, true, false, true, false);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            tipo = 'I';
            habilitaBtn(true, true, true, false, false, false, false);
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Close();
            frmConsulta oConsulta = new frmConsulta();
            oConsulta.Show();

            if (oConsulta.codigo != 0)
            {
                Conexao c = new Conexao(strConexao);
                DALCadastro d = new DALCadastro(c);
                Cadastro ctt = d.SelCadastro(oConsulta.codigo);

                txtCodigo.Text = ctt.Id.ToString();
                txtNome.Text = ctt.Nome;
                txtEmail.Text = ctt.Email;
                txtFone.Text = ctt.Fone;
            }

            habilitaBtn(false, true, false, false, true, false, true);
            pnlDados.Enabled = false;
        }

        #endregion

        #region Métodos

        // Limpar
        protected void Limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtFone.Text = "";
        }

        // Habilitar botões
        protected void habilitaBtn(bool gravar, bool cancelar, bool limpar, bool excluir, bool alterar, bool inserir, bool pesquisar)
        {
            btnGravar.Enabled = gravar;
            btnCancelar.Enabled = cancelar;
            btnLimpar.Enabled = limpar;
            btnExcluir.Enabled = excluir;
            btnAlterar.Enabled = alterar;
            btnInserir.Enabled = inserir;
            btnPesquisar.Enabled = pesquisar;
        }

        // Cadastro
        protected void Cad()
        {
            Cadastro cad = new Cadastro();
            Conexao con = new Conexao(strConexao);
            DALCadastro d = new DALCadastro(con);

            // Variáveis
            cad.Nome = txtNome.Text;
            cad.Email = txtEmail.Text;
            cad.Fone = txtFone.Text;

            try
            {
                switch (tipo)
                {
                    case 'I':
                        d.Incluir(cad);
                        MessageBox.Show("Cadastrado com sucesso! Número do registro: " + cad.Id.ToString());
                        break;
                    case 'U':
                        cad.Id = Convert.ToInt32(txtCodigo.Text);
                        d.Alterar(cad);
                        MessageBox.Show("Alterado com sucesso!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                cad = null;
                con = null;
                d = null;
            }
        }

        // Validação
        protected bool Validacao()
        {
            if (txtNome.Text == "" && txtFone.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Informe o nome e e-mail ou número de telefone para contato.");
                return false;
            }
            else if (txtNome.Text == "" && (txtFone.Text != "" || txtEmail.Text != ""))
            {
                MessageBox.Show("Informe o nome para cadastro.");
                return false;
            }
            else if (txtFone.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Informe um e-mail ou telefone para contato.");
                return false;
            }
            else return true;
        }

        #endregion

        #region TextChanged

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Conexao c = new Conexao(strConexao);
            DALCadastro d = new DALCadastro(c);
            Cadastro ctt = d.SelCadastro(id);

            if (!string.IsNullOrEmpty(id.ToString()))
            {

                txtNome.Text = ctt.Nome;
                txtEmail.Text = ctt.Email;
                txtFone.Text = ctt.Fone;
            }

        }

        #endregion

    }
}
