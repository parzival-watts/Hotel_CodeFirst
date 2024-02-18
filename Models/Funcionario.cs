using System.Collections.Generic;
using Microsoft.Identity.Client;

namespace Hotel_CodeFirst.Models
{ 
    public class Funcionario
    { 
        public int Codigo_Funcionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public int Codigo_TipoFuncionario { get; set; }

        public TipoFuncionario TipoFuncionario { get; set; }
    }
}