﻿using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadRoleDTO(int RoleId ,string RoleName);

    public record CreateRoleDTO ([Required] string RoleName);

    public record UpdateRoleDTO ([Required] int RoleId , [Required] string RoleName);
}
