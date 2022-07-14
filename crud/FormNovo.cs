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
    public partial class FormNovo : Form
    {
        public FormNovo()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int job_id = 0;
            int department_id = 0;

            string jb_id;
            string dp_id;

            switch(comboJob.SelectedIndex)
            {
                case 0:
                    job_id = 1;
                    break;
                case 1:
                    job_id = 2;
                    break;
                case 2:
                    job_id = 3;
                    break;
                case 3:
                    job_id = 4;
                    break;
                case 4:
                    job_id = 5;
                    break;
                case 5:
                    job_id = 6;
                    break;
                case 6:
                    job_id = 7;
                    break;
                case 7:
                    job_id = 8;
                    break;
                case 8:
                    job_id = 9;
                    break;
                case 9:
                    job_id = 10;
                    break;
                default:
                    MessageBox.Show("Erro - Escolha uma opção!");
                    break;
            }

            switch(comboDepartamento.SelectedIndex)
            {
                case 0:
                    department_id = 1;
                    break;
                case 1:
                    department_id = 2;
                    break;
                case 2:
                    department_id = 3;
                    break;
                case 3:
                    department_id = 4;
                    break;
                case 4:
                    department_id = 5;
                    break;
                default:
                    MessageBox.Show("Erro - Escolha uma opção!");
                    break;
            }

            jb_id = job_id.ToString();
            dp_id = department_id.ToString();

            Classes.Propriedade.PrimeiroNome = textPrimeiroNome.Text;
            Classes.Propriedade.UltimoNome = textUltimoNome.Text;
            Classes.Propriedade.Email = textEmail.Text;
            Classes.Propriedade.Telefone = textTelefone.Text;
            Classes.Propriedade.Job = jb_id;
            Classes.Propriedade.Salario = textSalario.Text;
            Classes.Propriedade.Departamento = dp_id;

            Classes.Banco objetoInsert = new Classes.Banco();
            objetoInsert.realizaInsert();

            textPrimeiroNome.Clear();
            textUltimoNome.Clear();
            textEmail.Clear();
            textTelefone.Clear();
            textSalario.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
