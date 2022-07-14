using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud.Classes
{
    public class Banco
    {
        MySqlConnection conn = new MySqlConnection();

        private string DatabaseSource = "server=localhost;port=3306;user id=hr;password=hr;database=rh;";
        public MySqlConnection estabeleceConexao()
        {
            try
            {
                conn.ConnectionString = DatabaseSource;
                conn.Open();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! - " + ex.ToString());
            }
            finally
            {
                // conn.Close();
            }
            return conn;
        }

        public MySqlConnection realizaInsert()
        {
            string cmdInsert = $"INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id) VALUES ( '{Classes.Propriedade.PrimeiroNome}' , '{Classes.Propriedade.UltimoNome}' , '{ Classes.Propriedade.Email}' , '{ Classes.Propriedade.Telefone}' , CURDATE() , { Classes.Propriedade.Job} , { Classes.Propriedade.Salario} , NULL , NULL , { Classes.Propriedade.Departamento});";
            
            MySqlCommand comando = new MySqlCommand(cmdInsert, conn);

            try
            {
                conn.ConnectionString = DatabaseSource;
                conn.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! - " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }

        public DataTable CarregarDataGrid(DataGridView DtView)
        {
            string cmdSelect = $"SELECT e.id, e.first_name, e.last_name, e.email, e.phone_number, e.hire_date, j.job_title, e.salary, d.department_name FROM employee e INNER JOIN job j ON (e.job_id = j.id) INNER JOIN department d ON (e.department_id = d.id) WHERE e.id LIKE '{Classes.Propriedade.Search}%' ORDER BY e.id ASC;";

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand(cmdSelect, conn);
            DataTable data = new DataTable();

            try
            {
                conn.ConnectionString = DatabaseSource;
                conn.Open();
                data.Load(comando.ExecuteReader());
                DtView.DataSource = data;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! - " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return data;
        }

        public MySqlConnection realizaUpdate()
        {
            string cmdUpdate = $"UPDATE employee SET first_name = '{Classes.Propriedade.PrimeiroNome}', last_name = '{Classes.Propriedade.UltimoNome}', email = '{Classes.Propriedade.Email}', phone_number = '{Classes.Propriedade.Telefone}', job_id = {Classes.Propriedade.Job}, salary = {Classes.Propriedade.Salario}, department_id = {Classes.Propriedade.Departamento} WHERE id = {Classes.Propriedade.Editar};";

            MySqlCommand comando = new MySqlCommand(cmdUpdate, conn);

            try
            {
                conn.ConnectionString = DatabaseSource;
                conn.Open();
                comando.ExecuteReader();
                MessageBox.Show("Registro editado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! - " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }

        public MySqlConnection realizaDelete()
        {
            string cmdDelete = $"DELETE FROM employee WHERE id = {Classes.Propriedade.Delete};";

            MySqlCommand comando = new MySqlCommand(cmdDelete, conn);

            try
            {
                conn.ConnectionString = DatabaseSource;
                conn.Open();
                comando.ExecuteReader();
                MessageBox.Show("Registro deletado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! - " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}
