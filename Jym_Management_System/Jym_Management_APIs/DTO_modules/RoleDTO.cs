using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadRoleDTO(byte RoleId ,string RoleName);

    public record CreateRoleDTO (string RoleName);

    public record UpdateRoleDTO ([Required] byte RoleId ,string RoleName);
}
