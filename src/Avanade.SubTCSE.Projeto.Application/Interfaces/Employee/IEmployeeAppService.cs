using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO);
    }
}
