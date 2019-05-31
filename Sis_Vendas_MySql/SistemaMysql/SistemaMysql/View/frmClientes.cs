using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Model;
using SistemaMysql.Entidades;

namespace SistemaMysql.View
{
    public partial class frmClientes : Form
    {
        ClienteModel model = new ClienteModel();

        public void HabilitarCampos()
        {
            txtCliente.Enabled = true;
            cbSexo.Enabled = true;
            dtNascimento.Enabled = true;
        }

        public void DesabilitarCampos()
        {
            txtCliente.Enabled = false;
            cbSexo.Enabled = false;
            dtNascimento.Enabled = false;
        }

        public void LimparCampos()
        {
            txtCliente.Text = "";
            cbSexo.Text = "";
            txtCodigo.Text = "";
        }


        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                grid.DataSource = model.Listar();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
        }



        public void Salvar(Clientes dado)
        {

            try
            {
                dado.Nome = txtCliente.Text;
                dado.Sexo = cbSexo.Text;
                dado.Nascimento = Convert.ToDateTime(dtNascimento.Text);

                model.Salvar(dado);
                MessageBox.Show("Cliente Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }


        public void Editar(Clientes dado)
        {

            try
            {
                dado.Id = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtCliente.Text;
                dado.Sexo = cbSexo.Text;
                dado.Nascimento = Convert.ToDateTime(dtNascimento.Text);

                model.Editar(dado);
                MessageBox.Show("Cliente Editado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }


        public void Excluir(Clientes dado)
        {

            try
            {
                dado.Id = Convert.ToInt32(txtCodigo.Text);
                

                model.Excluir(dado);
                MessageBox.Show("Cliente excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes dados = new Clientes();
            Salvar(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtCliente.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cbSexo.Text = grid.CurrentRow.Cells[2].Value.ToString();
            dtNascimento.Text = grid.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }
            Clientes dados = new Clientes();
            Editar(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Clientes dados = new Clientes();
            Excluir(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Clientes dados = new Clientes();
            Buscar(dados);

            if(txtBuscar.Text == "")
            {
                Listar();
                return;
            }
            
        }



        public void Buscar(Clientes dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;
                grid.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }


    }
}
