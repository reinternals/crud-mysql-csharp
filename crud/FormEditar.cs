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
    public partial class FormEditar : Form
    {
        public string jb_id;
        public string dpt_id;
        public FormEditar()
        {
            InitializeComponent();
            beforeUpdate();
        }

        public void beforeUpdate()
        {
            textPrimeiroNome.Text = Classes.Propriedade.PrimeiroNome;
            textUltimoNome.Text = Classes.Propriedade.UltimoNome;
            textEmail.Text = Classes.Propriedade.Email;
            textTelefone.Text = Classes.Propriedade.Telefone;
            jb_id = Classes.Propriedade.Job;
            textSalario.Text = Classes.Propriedade.Salario;
            dpt_id = Classes.Propriedade.Departamento;

            switch (jb_id)
            {
                case "President":
                    comboJob.SelectedIndex = 0;
                    break;
                case "Administration Vice President":
                    comboJob.SelectedIndex = 1;
                    break;
                case "Administration Assistant":
                    comboJob.SelectedIndex = 2;
                    break;
                case "Finance Manager":
                    comboJob.SelectedIndex = 3;
                    break;
                case "Accountant":
                    comboJob.SelectedIndex = 4;
                    break;
                case "Accounting Manager":
                    comboJob.SelectedIndex = 5;
                    break;
                case "Public Accountant":
                    comboJob.SelectedIndex = 6;
                    break;
                case "Sales Manager":
                    comboJob.SelectedIndex = 7;
                    break;
                case "Sales Representative":
                    comboJob.SelectedIndex = 8;
                    break;
                case "Purchasing Clerk":
                    comboJob.SelectedIndex = 9;
                    break;
                default:
                    break;
            }

            switch (dpt_id)
            {
                case "IT Helpdesk":
                    comboDepartamento.SelectedIndex = 0;
                    break;
                case "Government Sales":
                    comboDepartamento.SelectedIndex = 1;
                    break;
                case "Retail Sales":
                    comboDepartamento.SelectedIndex = 2;
                    break;
                case "Recruiting":
                    comboDepartamento.SelectedIndex = 3;
                    break;
                case "Payroll":
                    comboDepartamento.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int job_id = 0;
            int department_id = 0;

            switch (comboJob.SelectedIndex)
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

            switch (comboDepartamento.SelectedIndex)
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
            dpt_id = department_id.ToString();

            Classes.Propriedade.PrimeiroNome = textPrimeiroNome.Text;
            Classes.Propriedade.UltimoNome = textUltimoNome.Text;
            Classes.Propriedade.Email = textEmail.Text;
            Classes.Propriedade.Telefone = textTelefone.Text;
            Classes.Propriedade.Job = jb_id;
            Classes.Propriedade.Salario = textSalario.Text;
            Classes.Propriedade.Departamento = dpt_id;

            Classes.Banco objetoUpdate = new Classes.Banco();
            objetoUpdate.realizaUpdate();

            textPrimeiroNome.Clear();
            textUltimoNome.Clear();
            textEmail.Clear();
            textTelefone.Clear();
            textSalario.Clear();
            this.Close();
        }
    }
}
