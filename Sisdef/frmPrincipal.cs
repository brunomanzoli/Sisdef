using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sisdef
{
    public partial class frmPrincipal : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_Sisdef;User ID=sa;Password=sql2017";
        SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

       private bool ValidarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }
            else
            {
                string[] separador = email.Split('@');
                string local = separador[0];
                string dominio = separador[1];

                if(local.Length == 0)
                {
                    return false;
                }
                else
                {
                    if (dominio.Length > 4)
                    {
                        if (dominio.Substring(dominio.Length-4,4).ToUpper() == ".COM")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text;
            string senha = txtSenha.Text;
            string teste = "Isso é um teste";
            string teste2 = "outro";

            if (!ValidarEmail(email)) 
            {
                MessageBox.Show("Email não atende as regras de validação!");
            }
            else
            {
                conexao = new SqlConnection(strConexao);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT count(*) FROM tblUsuario WHERE email = @mail AND senha = @password";
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@password", senha);
                conexao.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
                {
                    //CARREGANDO OS EQUIPAMENTOS
                    SqlDataAdapter daEquipamento = new SqlDataAdapter("SELECT * FROM tblEquipamento",strConexao);
                    DataTable tabelaEquipamento = new DataTable();
                    daEquipamento.Fill(tabelaEquipamento);
                    cbEquipamento.DataSource = tabelaEquipamento;
                    cbEquipamento.DisplayMember = "nomeEquipamento";
                    cbEquipamento.ValueMember = "codEquipamento";

                    //CARREGANDO OS DEFEITOS
                    SqlDataAdapter daDefeito = new SqlDataAdapter("SELECT * FROM tblDefeito", strConexao);
                    DataTable tabelaDefeito = new DataTable();
                    daDefeito.Fill(tabelaDefeito);
                    cbTipoDefeito.DataSource = tabelaDefeito;
                    cbTipoDefeito.DisplayMember = "nomeDefeito";
                    cbTipoDefeito.ValueMember = "codDefeito";

                    pnLogin.Visible = false;
                    pnDefeitos.Visible = true;
                    btnDefeitos.Visible = true;
                    btnRelatorios.Visible = true;


                }
                else
                {
                    MessageBox.Show("ERRO: usuário e/ou senha incorretos");
                }
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.ResetText();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length == 0)
            {
                txtLogin.Text = "Login";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.ResetText();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length == 0)
            {
                txtSenha.Text = "Senha";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataRegistro = Convert.ToDateTime(mtxtData.Text);
            int codigoEquipamento = Convert.ToInt32(cbEquipamento.SelectedValue);
            int codigoDefeito = Convert.ToInt32(cbTipoDefeito.SelectedValue);
            DateTime horarioInicio = Convert.ToDateTime(mtxtHorarioInicio.Text);
            DateTime horarioFinal = Convert.ToDateTime(mtxtHorarioFinal.Text);

            conexao = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO tblRegistroDefeito VALUES(@data,@equipamento,@defeito,@inicio,@final)";
            cmd.Parameters.AddWithValue("@data", dataRegistro);
            cmd.Parameters.AddWithValue("@equipamento", codigoEquipamento);
            cmd.Parameters.AddWithValue("@defeito", codigoDefeito);
            cmd.Parameters.AddWithValue("@inicio", horarioInicio);
            cmd.Parameters.AddWithValue("@final", horarioFinal);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSisdef.DataTableControleDefeitos' table. You can move, or remove it, as needed.
            this.dataTableControleDefeitosTableAdapter.FillControleDefeitos(this.dataSetSisdef.DataTableControleDefeitos);
            pnDefeitos.Visible = false;
            btnDefeitos.Visible = false;
            btnRelatorios.Visible = false;
            this.reportViewer.RefreshReport();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            pnDefeitos.Visible = false;
            pnLogin.Visible = true;
            btnDefeitos.Visible = false;
            btnRelatorios.Visible = false;
            reportViewer.Visible = false;
        }

        private void Limpar()
        {
            mtxtData.ResetText();
            cbEquipamento.ResetText();
            cbTipoDefeito.ResetText();
            mtxtHorarioFinal.ResetText();
            mtxtHorarioInicio.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;
            pnDefeitos.Visible=false;
        }

        private void btnDefeitos_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = false;
            pnDefeitos.Visible = true;
        }
    }
}
