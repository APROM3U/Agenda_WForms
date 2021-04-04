using System;
using System.Windows.Forms;

namespace CadConsultaForms
{
    public partial class frmConsulta : Form
    {
        #region Page Load

        // Varíáveis
        private string strConexao = "Data Source = CENTER; Initial Catalog = projet; Integrated Security = True";
        private int? _Ini = null;
        private int? _Fin = null;
        public int codigo = 0;
        public char tipo;

        // Construtor
        public frmConsulta()
        {
            InitializeComponent();
        }

        #endregion

        #region Inserir

        private void lblInserir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro oCad = new frmCadastro();
            oCad.Show();
            Close();
        }

        #endregion

        #region Botão

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!Valida()) return;

            CarregaDados();

            pnlGrid.Visible = true;
        }

        #endregion

        #region Pesquisar

        private void CarregaDados()
        {
            Conexao oConnect = new Conexao(strConexao);
            DALCadastro oConsulta = new DALCadastro(oConnect);

            gvConsulta.DataSource = oConsulta.Pesquisar(_Ini, _Fin);

            gvConsulta.Columns[0].HeaderText = "Código";
            gvConsulta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gvConsulta.Columns[0].Width = 50;

            gvConsulta.Columns[1].HeaderText = "Nome";
            gvConsulta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gvConsulta.Columns[1].Width = 240;

            gvConsulta.Columns[2].HeaderText = "Telefone";
            gvConsulta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gvConsulta.Columns[2].Width = 100;

            gvConsulta.Columns[3].HeaderText = "E-mail";
            gvConsulta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gvConsulta.Columns[3].Width = 240;

        }

        #endregion

        #region Validar

        private bool Valida()
        {
            /* Trata Null */
            if (txtCodInicial.Text.Trim() != "")
                _Ini = Convert.ToInt32(txtCodInicial.Text);
            else
                _Ini = 1;

            if (txtCodFinal.Text.Trim() != "")
                _Fin = Convert.ToInt32(txtCodFinal.Text);
            else
                _Fin = 99999999;

            if (_Ini > _Fin)
            {
                MessageBox.Show("O código inicial não pode ser maior que código final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region Grid

        private void gvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(gvConsulta.Rows[e.RowIndex].Cells[0].Value);
                this.tipo = 'C';
                this.Close();

                // Acessa cadastro
                frmCadastro cad = new frmCadastro(codigo, tipo);
                cad.Show();

            }
        }

        #endregion
    }
}
