using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadRoleDTO(int RoleId ,string RoleName);

    public record CreateRoleDTO ([Required] string RoleName);

    public record UpdateRoleDTO ([Required] int RoleId , [Required] string RoleName);
}
