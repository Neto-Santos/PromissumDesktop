﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.Orcamento
{
    public partial class frmFiltroOrcamento : Form
    {
        public frmFiltroOrcamento()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorioOrçamento frm = new frmRelatorioOrçamento();
            frm.ShowDialog();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            frmRelatorioOrçamento frm = new frmRelatorioOrçamento();
            frm.ShowDialog();
        }
    }
}
