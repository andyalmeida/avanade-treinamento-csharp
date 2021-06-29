using System;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.Employee
{
    public class EmployeeDTO : Base.BaseDTO
    {
        public string PrimeiroNome { get; set; }
        
        public string Sobrenome { get; set; }

        public DateTime Aniversario { get; set; }

        public bool Ativo { get; set; }

        public decimal Salario { get; set; }

        public EmployeeRole.EmployeeRoleDTO Cargo { get; set; }
    }
}
