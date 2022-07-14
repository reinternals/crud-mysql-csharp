using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            Classes.Banco objetoConexao = new Classes.Banco();
            objetoConexao.estabeleceConexao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormNovo formNovo = new FormNovo();
            formNovo.ShowDialog();
        }

        public void btnLupa_Click(object sender, EventArgs e)
        {
            string buscar = textSearch.Text;
            Classes.Propriedade.Search = buscar.Trim();

            Classes.Banco objetoCarrega = new Classes.Banco();
            objetoCarrega.CarregarDataGrid(dtView);
        }

        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Classes.Propriedade.Editar = dtView.Rows[e.RowIndex].Cells[2].Value.ToString();

                Classes.Propriedade.PrimeiroNome = dtView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Classes.Propriedade.UltimoNome = dtView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Classes.Propriedade.Email = dtView.Rows[e.RowIndex].Cells[5].Value.ToString();
                Classes.Propriedade.Telefone = dtView.Rows[e.RowIndex].Cells[6].Value.ToString();
                Classes.Propriedade.Job = dtView.Rows[e.RowIndex].Cells[8].Value.ToString();
                Classes.Propriedade.Salario = dtView.Rows[e.RowIndex].Cells[9].Value.ToString();
                Classes.Propriedade.Departamento = dtView.Rows[e.RowIndex].Cells[10].Value.ToString();

                FormEditar formEditar = new FormEditar();
                formEditar.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Deseja deletar o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Classes.Propriedade.Delete =  dtView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Classes.Banco objetoDelete = new Classes.Banco();
                    objetoDelete.realizaDelete();
                }
                return;
            }

        }
    }
}
