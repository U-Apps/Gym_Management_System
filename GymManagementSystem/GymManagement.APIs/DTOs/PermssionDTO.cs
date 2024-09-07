using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadPermssionDTO
        (
              byte Id ,
              string? Name,

              ReadRoleDTO? Role


        );

    public record CreatePermssionDTO
       (
             
              string? Name,

              [Required]
              byte? RoleId


       );

    public record UpdatePermssionDTO
      (
            [Required]
            byte Id,

            string? Name,
            [Required]
            byte? RoleId

      );
}
