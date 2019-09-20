using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;
using BLL;
using DAL.EntityFramework;
using MODELO;
using Ferramentas;
using Promissum.Consulta;

namespace Beta1._0.Os
{
    public partial class frmCadastroOrcamento : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public int codigo;
        private string status = "";
        private string referencia = "";
        public double TotalVenda { get; set; }


        public frmCadastroOrcamento(int codigoOrcamento)
        {
            InitializeComponent();
            this.codigo = codigoOrcamento;
        }

        void limpaCampos()
        {
            txtCodProduto.Clear();
            lbProduto.Text = "Insira o código do produto";
            txtQuantidade.Text = "0";
            txtPrecoUnitario.Text = "0";
            txtTotalProduto.Text = "0";
            txtDescontoReal.Text = "0";
            txtDesconto.Text = "0";
        }
        private bool verificaValorExiste(string codigoProcurado)
        {
            bool retorno = false;

            foreach (DataGridViewRow row in this.dgvItensVenda.Rows)
            {
                string busca = (row.Cells[0].Value.ToString());

                if (busca == codigoProcurado)
                {
                    retorno = true;
                    row.Cells[0].Style.BackColor = Color.Red;
                }

            }
            return retorno;
        }

        // CONSULTA CLIENTE
        private void button5_Click(object sender, EventArgs e)
        {
            Consulta.frmConsultaCliente frm = new Consulta.frmConsultaCliente();
            frm.ShowDialog();

            int cod = Convert.ToInt32(frm.codigo);
            var modelo = contexto.cliente.Find(cod);
            txtCodCliente.Text = modelo.cli_cod.ToString();
            txtEmail.Text = modelo.cli_email;
            lbCliente.Text = modelo.cli_nome;
        }


        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliente.Text))
            {
                Consulta.frmConsultaProduto frm = new Consulta.frmConsultaProduto();
                frm.codCliente = txtCodCliente.Text;

                frm.ShowDialog();

                int codProduto = Convert.ToInt32(frm.codigo);
                int codCliente = Convert.ToInt32(frm.codCliente);


                //bllClienteProduto.CarregarModelo(Convert.ToInt32(frm.codCliente), modeloProduto.ProCod, frm.referencia);
                dynamic modeloClienteProduto = contexto.ClienteProduto.Include("produto").Where(x => x.codCliente == codCliente &&
                                            x.codProduto == codProduto &&
                                            x.referencia == frm.referencia).Select(c => new { c.cod, c.produto.pro_nome, c.produto.pro_valorvenda, c.referencia }).FirstOrDefault();

                if (modeloClienteProduto != null)
                {
                    gbValores.Enabled = true;
                    txtCodProduto.Text = modeloClienteProduto.cod.ToString();
                    lbProduto.Text = modeloClienteProduto.pro_nome;
                    txtDesconto.Text = "0";
                    txtDescontoReal.Text = "0";
                    txtPrecoUnitario.Text = modeloClienteProduto.pro_valorvenda.ToString();
                    txtVlrBase.Text = modeloClienteProduto.pro_valorvenda.ToString();
                    txtQuantidade.Text = "1";
                    txtTotalProduto.Text = modeloClienteProduto.pro_valorvenda.ToString();
                    referencia = modeloClienteProduto.referencia.ToString();

                }
            }
            else
            {
                MessageBox.Show("Não há cliente selecionado para o orçamento");
            }

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if ((txtCodProduto.Text != "") && (txtQuantidade.Text != "") && (txtPrecoUnitario.Text != ""))
            {

                double totalLocal = Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtPrecoUnitario.Text);

                this.TotalVenda = TotalVenda + totalLocal;

                String[] i = new String[] { txtCodProduto.Text, referencia, cbOperacao.Text, lbProduto.Text, txtQuantidade.Text, txtVlrBase.Text, txtDescontoReal.Text, txtPrecoUnitario.Text, totalLocal.ToString(), cbOperacao.SelectedValue.ToString() };

                dgvItensVenda.Rows.Add(i);

                limpaCampos();

                txtTotal.Text = this.TotalVenda.ToString();
            }
        }

        private void frmCadastroOrcamento_Load(object sender, EventArgs e)
        {
            try
            {
                cbOperacao.DisplayMember = "op_nome";
                cbOperacao.ValueMember = "op_cod";
                cbOperacao.DataSource = contexto.operacao.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            nupdDiasEmail.Value = 30;

            if (this.codigo > 0)
            {
                //Desabilita o botão para buscar cliente
                button5.Enabled = false;

                //habilitando o botão de impressão
                button8.Enabled = true;
                //Habilita o groupBox para cadastrar valores(qtd,desconto,valorBase etc..)
                gbValores.Enabled = true;
                //dtDataSaida.Format = DateTimePickerFormat.Custom;
                dtDataSaida.CustomFormat = " ";
                dtDataSaida.Text = null;
                //Carregando os campos da Ordem de Serviço
                try
                {
                    int codVenda = Convert.ToInt32(codigo);

                    var modelo = contexto.venda.Find(codVenda);
                    //cbOperacao.SelectedValue = modelo.op_cod;
                    txtCodCliente.Text = modelo.cli_cod.ToString();

                    var modeloCliente = contexto.cliente.Find(modelo.cli_cod);
                    lbCliente.Text = modeloCliente.cli_nome;
                    txtEmail.Text = modeloCliente.cli_email;

                    nupdDiasEmail.Value = (int)modelo.ven_diasProximaRevisao;

                    if (modelo.ven_status == "Aberto")
                    {
                        rbAberto.Checked = true;
                    }
                    if (modelo.ven_status == "Finalizado")
                    {
                        dtDataEntrada.Value = modelo.ven_data_entrada.Value;
                        dtHoraEntrada.Value = modelo.ven_hora_entrada.Value;

                        dtDataEntrada.Enabled = false;
                        dtHoraEntrada.Enabled = false;

                        rbFinalizado.Checked = true;
                        dtDataSaida.Value = (DateTime)modelo.ven_data_saida;
                    }
                    if (modelo.ven_lembrete == "Pendente")
                    {
                        rbLembretePendente.Checked = true;
                    }
                    else
                    {
                        rbLembreteEnviado.Checked = true;
                    }

                    txtDefeitoApresentado.Text = modelo.ven_defeito_apresentado;
                    txtServicoEfetuado.Text = modelo.ven_servico_efetuado;
                    txtTotal.Text = modelo.ven_total.ToString();
                    dtDataEntrada.Value = modelo.ven_data_entrada.Value;


                    #region Carregando Itens da Compra
                    //Modelo = Venda

                    foreach (var item in modelo.itensvenda)
                    {

                        string codProduto = item.cp_cod.ToString();
                        string iNome = item.ClienteProduto.produto.pro_nome;
                        string iQtd = item.itv_qtde.ToString();
                        string iValorUnitario = item.itv_valor.ToString();
                        double totalLocal = Convert.ToDouble(item.itv_qtde * (double)item.itv_valor);
                        string valorBase = item.itv_valorBase.ToString();
                        string desconto = item.itv_desconto.ToString();
                        string referencia = item.referencia;
                        string codOperacao = item.op_cod.ToString();
                        string operacao = item.operacao.op_nome;
                        this.TotalVenda = TotalVenda + totalLocal;


                        //String[] linha = new String[] { iCod, iNome, iQtd, valorBase, desconto, iValorUnitario, totalLocal.ToString(), };
                        // sequência do datagrid codigo - ref - operação - produto - quantidade,valor un,desconto,valor un,total,codOperação
                        String[] linha = new String[] { codProduto, referencia, operacao, iNome, iQtd, valorBase, desconto, iValorUnitario, totalLocal.ToString(), codOperacao };

                        dgvItensVenda.Rows.Add(linha);
                    }

                }
                catch (Exception)
                {

                    throw new Exception();
                }

                #endregion 
            }
            else
            {

            }
        }

        private void dtDataSaida_ValueChanged(object sender, EventArgs e)
        {
            if (dtDataSaida.Value < dtDataEntrada.Value)
            {
                MessageBox.Show("Data de Término não pode ser menor que a data inicial", "Aviso");
                dtDataSaida.Value = DateTime.Now;
            }
        }

        private void dgvItensVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProduto.Text = dgvItensVenda.Rows[e.RowIndex].Cells["cod"].Value.ToString();
            lbProduto.Text = dgvItensVenda.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
            txtQuantidade.Text = dgvItensVenda.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString();
            txtVlrBase.Text = dgvItensVenda.Rows[e.RowIndex].Cells["ValorBase"].Value.ToString();
            txtPrecoUnitario.Text = dgvItensVenda.Rows[e.RowIndex].Cells["ValorUn"].Value.ToString();
            txtTotalProduto.Text = dgvItensVenda.Rows[e.RowIndex].Cells["Total"].Value.ToString();
            txtDescontoReal.Text = dgvItensVenda.Rows[e.RowIndex].Cells["Desconto"].Value.ToString();
            cbOperacao.SelectedValue = Convert.ToInt32(dgvItensVenda.Rows[e.RowIndex].Cells["CodOperacao"].Value);

            var descontoPorCento = (Convert.ToDouble(txtDescontoReal.Text) / Convert.ToDouble(txtVlrBase.Text)) * 100;

            txtDesconto.Text = descontoPorCento.ToString();
            this.TotalVenda = this.TotalVenda - Convert.ToDouble(txtTotalProduto.Text);
            referencia = dgvItensVenda.Rows[e.RowIndex].Cells["Ref"].Value.ToString();
            txtTotal.Text = this.TotalVenda.ToString();
            dgvItensVenda.Rows.RemoveAt(e.RowIndex);
        }

        private void btnConfirmaOrcamento_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtTotal.Text))
            {
                //Alimentando o modelo Venda===============================
                venda modeloVenda = new venda();
                modeloVenda.cli_cod = Convert.ToInt32(txtCodCliente.Text);
                modeloVenda.tpa_cod = 0;
                modeloVenda.ven_avista = 0;
                modeloVenda.ven_data = DateTime.Now;
                modeloVenda.ven_data_entrada = dtDataEntrada.Value;
                modeloVenda.ven_hora_entrada = dtHoraEntrada.Value;
                modeloVenda.ven_defeito_apresentado = txtDefeitoApresentado.Text;
                modeloVenda.ven_servico_efetuado = txtServicoEfetuado.Text;
                modeloVenda.ven_status = status;
                modeloVenda.ven_data_saida = dtDataSaida.Value;
                modeloVenda.ven_hora_saida = dtHoraSaida.Value;
                modeloVenda.ven_total = (decimal)this.TotalVenda;
                modeloVenda.ven_diasProximaRevisao = Convert.ToInt32(nupdDiasEmail.Value);
                modeloVenda.ven_lembrete = rbLembretePendente.Checked ? "Pendente" : "Enviado";
                //modeloVenda.op_cod = Convert.ToInt32(cbOperacao.SelectedValue);
                //-------------------------------------------------------------------


                //Verificando se o status esta finalizado ou em aberto
                if (rbFinalizado.Checked)
                {
                    modeloVenda.ven_data_saida = dtDataSaida.Value;
                    modeloVenda.ven_hora_saida = dtDataSaida.Value;
                    modeloVenda.ven_status = "Finalizado";
                }
                if (rbAberto.Checked)
                {
                    modeloVenda.ven_status = "Aberto";
                }

                if (this.codigo <= 0)
                {
                    //Incluindo a Venda
                    contexto.venda.Add(modeloVenda);


                    //Cadastrar itens da compra.
                    itensvenda itensVenda = new itensvenda();
                    #region Cadastrando Os Itens da venda no banco de dados

                    for (int i = 0; i < dgvItensVenda.Rows.Count; i++)
                    {
                        itensVenda.ven_cod = modeloVenda.ven_cod;
                        itensVenda.cp_cod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells["cod"].Value.ToString());
                        itensVenda.itv_qtde = Convert.ToDouble(dgvItensVenda.Rows[i].Cells["Quantidade"].Value.ToString());
                        itensVenda.itv_valor = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["ValorUn"].Value.ToString());
                        itensVenda.referencia = dgvItensVenda.Rows[i].Cells["Ref"].Value.ToString();
                        itensVenda.itv_valorBase = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["ValorBase"].Value.ToString());
                        itensVenda.itv_desconto = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["Desconto"].Value.ToString());
                        itensVenda.op_cod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells["codOperacao"].Value.ToString());

                        contexto.itensvenda.Add(itensVenda);

                    }

                    var enviarEmail = MessageBox.Show("Deseja enviar email Para o Cliente?", "Email", MessageBoxButtons.YesNo);
                    if (enviarEmail == DialogResult.Yes)
                    {

                        var email = Ferramentas.xmlConfig.config.carregaEmail();

                        var data = DateTime.Now.AddDays(Convert.ToInt32(nupdDiasEmail.Value)).ToString();

                        StringBuilder sbCorpo = new StringBuilder();

                        sbCorpo.Append(email.corpo + "<br>");
                        sbCorpo.Append("Data sugerida para próxima manutenção corretiva/preventiva " + data);
                        sbCorpo.Append("<br><br><br><br>");
                        sbCorpo.AppendFormat("<p>{0}</p><p>{1}</p><p>{2}</p>", email.rodape1, email.rodape2, email.rodape3);

                        EnviodeEmail.EnviaEmail(txtEmail.Text, "", "", email.assunto, sbCorpo.ToString(), "", email.nome, email.senha);

                    }

                    contexto.SaveChanges();
                    #endregion
                }
                else
                {


                    modeloVenda.ven_cod = Convert.ToInt32(this.codigo);
                    var objVenda = contexto.venda.Find(this.codigo);
                    objVenda.cli_cod = Convert.ToInt32(txtCodCliente.Text);
                    objVenda.tpa_cod = 0;
                    objVenda.ven_avista = 0;
                    objVenda.ven_data = DateTime.Now;
                    objVenda.ven_data_entrada = dtDataEntrada.Value;
                    objVenda.ven_hora_entrada = dtHoraEntrada.Value;
                    objVenda.ven_defeito_apresentado = txtDefeitoApresentado.Text;
                    objVenda.ven_servico_efetuado = txtServicoEfetuado.Text;
                    objVenda.ven_status = status;
                    objVenda.ven_data_saida = dtDataSaida.Value;
                    objVenda.ven_hora_saida = dtHoraSaida.Value;
                    objVenda.ven_total = (decimal)this.TotalVenda;
                    objVenda.ven_diasProximaRevisao = Convert.ToInt32(nupdDiasEmail.Value);
                    objVenda.ven_lembrete = rbLembretePendente.Checked ? "Pendente" : "Enviado";

                    if (rbFinalizado.Checked)
                    {
                        objVenda.ven_data_saida = dtDataSaida.Value;
                        objVenda.ven_hora_saida = dtDataSaida.Value;
                        objVenda.ven_status = "Finalizado";
                    }
                    if (rbAberto.Checked)
                    {
                        objVenda.ven_status = "Aberto";
                    }
                    //Excluindo todos os itens da venda.
                    foreach (var item in contexto.itensvenda.Where(i => i.ven_cod == modeloVenda.ven_cod).ToList())
                    {
                        contexto.itensvenda.Remove(item);
                    }


                    #region Cadastrando Os Itens da venda no banco de dados
                    itensvenda _itensVenda = new itensvenda();
                    for (int i = 0; i < dgvItensVenda.Rows.Count; i++)
                    {
                        //modeloItensVenda.itvCod = i + 1;

                        _itensVenda.ven_cod = modeloVenda.ven_cod;
                        _itensVenda.cp_cod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells["cod"].Value.ToString());
                        _itensVenda.itv_qtde = Convert.ToDouble(dgvItensVenda.Rows[i].Cells["Quantidade"].Value.ToString());
                        _itensVenda.itv_valor = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["ValorUn"].Value.ToString());
                        _itensVenda.referencia = dgvItensVenda.Rows[i].Cells["Ref"].Value.ToString();
                        _itensVenda.itv_valorBase = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["ValorBase"].Value.ToString());
                        _itensVenda.itv_desconto = Convert.ToDecimal(dgvItensVenda.Rows[i].Cells["Desconto"].Value.ToString());
                        _itensVenda.op_cod = Convert.ToInt32(dgvItensVenda.Rows[i].Cells["codOperacao"].Value.ToString());

                        contexto.itensvenda.Add(_itensVenda);
                        contexto.SaveChanges();
                    }

                    contexto.Entry(objVenda).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    var enviarEmail = MessageBox.Show("Deseja enviar email Para o Cliente?", "Email", MessageBoxButtons.YesNo);
                    if (enviarEmail == DialogResult.Yes)
                    {
                        var email = Ferramentas.xmlConfig.config.carregaEmail();

                        var data = DateTime.Now.AddDays(Convert.ToInt32(nupdDiasEmail.Value)).ToString();

                        StringBuilder sbCorpo = new StringBuilder();

                        sbCorpo.Append(email.corpo + "<br>");
                        sbCorpo.Append("Data sugerida para próxima manutenção corretiva/preventiva " + data);
                        sbCorpo.Append("<br><br><br><br>");
                        sbCorpo.AppendFormat("<p>{0}</p><p>{1}</p><p>{2}</p>", email.rodape1, email.rodape2, email.rodape3);

                        EnviodeEmail.EnviaEmail(txtEmail.Text, "", "", email.assunto, sbCorpo.ToString(), "", email.nome, email.senha);
                    }

                    #endregion
                }


            }
        }




        private void rbFinalizado_Click(object sender, EventArgs e)
        {
            if (rbFinalizado.Checked)
            {
                dtDataSaida.Enabled = true;
                dtHoraSaida.Enabled = true;
                dtDataEntrada.Enabled = false;
                dtHoraEntrada.Enabled = false;

                status = "Finalizado";
            }
        }

        private void rbAberto_Click(object sender, EventArgs e)
        {
            if (this.codigo > 0)
            {

                try
                {
                    int codVenda = Convert.ToInt32(this.codigo);
                    var modelo = contexto.venda.Find(codVenda);
                    if (modelo.ven_status == "Finalizado")
                    {
                        MessageBox.Show("Status da venda não pode ser alterado");
                        rbFinalizado.Checked = true;
                    }
                    else
                    {
                        if (rbAberto.Checked)
                        {
                            dtDataSaida.Enabled = false;
                            dtHoraSaida.Enabled = false;

                            dtDataEntrada.Enabled = true;
                            dtHoraEntrada.Enabled = true;

                            status = "Aberto";
                        }
                    }
                }
                catch (Exception) { }
            }
            else
            {
                if (rbAberto.Checked)
                {
                    dtDataSaida.Enabled = false;
                    dtHoraSaida.Enabled = false;

                    dtDataEntrada.Enabled = true;
                    dtHoraEntrada.Enabled = true;

                    status = "Aberto";
                }
            }
        }

        private void rbCancelado_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {
                dtDataSaida.Enabled = false;
                dtHoraSaida.Enabled = false;

                status = "Cancelado";
            }

        }

        //botão de imprimir
        private void button8_Click(object sender, EventArgs e)
        {

            Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento frm = new Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento();

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();

        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDesconto.Text))
            {
                var desconto = Convert.ToDouble(txtDesconto.Text);
                desconto = desconto / 100;

                var precoUnitario = Convert.ToDouble(txtVlrBase.Text);
                var descontoReal = precoUnitario * desconto;

                txtDescontoReal.Text = descontoReal.ToString();

                var valorFinal = precoUnitario - descontoReal;
                txtPrecoUnitario.Text = valorFinal.ToString();

                var quantidade = Convert.ToDouble(txtQuantidade.Text);
                var totalProduto = valorFinal * quantidade;
                txtTotalProduto.Text = totalProduto.ToString();
            }

        }

        private void txtVlrBase_Leave(object sender, EventArgs e)
        {

            txtDesconto_Leave(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ferramentas.Mascaras.Formatar("PLACA", txtPlaca);
        }

        //CONSULTAR VEICULO
        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultaMontadora frm = new frmConsultaMontadora();
            frm.ShowDialog();
        }

        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita somente números
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtkm_Leave(object sender, EventArgs e)
        {
            FormataMoeda.formatarMoeda(txtkm);
        }
    }
}


