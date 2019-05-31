using SistemaMysql.Entidades;
using SistemaMysql.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMysql.View
{
    public partial class frmVendas : Form
    {
        ClienteModel clienteModel = new ClienteModel();
        VendaModel model = new VendaModel();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = clienteModel.Listar();
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "nome";

            
            cbBuscar.DataSource = clienteModel.Listar();
            cbBuscar.ValueMember = "id";
            cbBuscar.DisplayMember = "nome";

           

            Listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
        }

        public void HabilitarCampos()
        {
            txtValor.Enabled = true;
            cbCliente.Enabled = true;
            dtVenda.Enabled = true;
        }

        public void DesabilitarCampos()
        {
            txtValor.Enabled = false;
            cbCliente.Enabled = false;
            dtVenda.Enabled = false;
        }

        public void LimparCampos()
        {
            txtValor.Text = "";
            
            txtCodigo.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Vendas dados = new Vendas();
            Salvar(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
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



        public void Salvar(Vendas dado)
        {

            try
            {
                dado.Data = Convert.ToDateTime(dtVenda.Text);
                dado.Valor = Convert.ToDecimal(txtValor.Text);
                dado.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                

                model.Salvar(dado);
                MessageBox.Show("Venda Salva com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }
            Vendas dados = new Vendas();
            Editar(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
        }



        public void Editar(Vendas dado)
        {

            try
            {
                dado.Id = Convert.ToInt32(txtCodigo.Text);
                dado.Data = Convert.ToDateTime(dtVenda.Text);
                dado.Valor = Convert.ToDecimal(txtValor.Text);
                dado.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);

                model.Editar(dado);
                MessageBox.Show("Venda Editada com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }


        public void Excluir(Vendas dado)
        {

            try
            {
                dado.Id = Convert.ToInt32(txtCodigo.Text);


                model.Excluir(dado);
                MessageBox.Show("Venda excluida com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir a Venda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Vendas dados = new Vendas();
            Excluir(dados);
            Listar();
            LimparCampos();
            DesabilitarCampos();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = grid.CurrentRow.Cells[0].Value.ToString();
            dtVenda.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = grid.CurrentRow.Cells[2].Value.ToString();
            cbCliente.SelectedValue = grid.CurrentRow.Cells[3].Value.ToString();
            
            HabilitarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void Buscar(Vendas dado)
        {
            try
            {
               
                dado.Id_cliente = Convert.ToInt32(cbBuscar.SelectedValue);
                grid.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vendas dados = new Vendas();
            Buscar(dados);

            if(cbBuscar.Text == "")
            {
                Listar();
                return;
            }
        }

       
    }
}
