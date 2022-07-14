using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Classes
{
    class Propriedade
    {
        public static string PrimeiroNome { get; set; }
        public static string UltimoNome { get; set; }
        public static string Email { get; set; }
        public static string Telefone { get; set; }
        public static string Job { get; set; }
        public static string Departamento { get; set; }
        public static string Salario { get; set; }
        public static string Search { get; set; }
        public static string Delete { get; set; }
        public static string Editar { get; set; }
 

        public Propriedade (string primeiroNome, string ultimoNome, string email, string telefone, string job, string departamento, string salario, string search, string delete, string editar)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Email = email;
            Telefone = telefone;
            Job = job;
            Departamento = departamento;
            Salario = salario;
            Search = search;
            Delete = delete;
            Editar = editar;
        }
    }
}
