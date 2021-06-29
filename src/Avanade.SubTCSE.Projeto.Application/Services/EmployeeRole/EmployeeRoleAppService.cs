using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole
{
    public class EmployeeRoleAppService : IEmployeeRoleAppService
    {
        Task<EmployeeRoleDTO> IEmployeeRoleAppService.AddEmployeeRole(EmployeeRoleDTO employeeRoleDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
