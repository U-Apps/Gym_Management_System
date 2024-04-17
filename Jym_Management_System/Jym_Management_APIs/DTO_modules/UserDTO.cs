using Jym_Management_DataAccessLayer.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadUserDTO 
        (
              int PersonId,
             bool IsActive,

              ReadPersonDTO Person

        
        );

    public record CreateUserDTO
       (
         [Required]
             string UserName,
          [Required]
             string Password ,

             bool IsActive,
             [Required]
             byte PermissionsId,
             [Required]
             int PersonId

       );

    public record UpdateUserDTO
      (
            [Required]
            short UserId ,

            string UserName, 
            string Password ,

            bool IsActive,

            [Required]
            byte PermissionsId,
            [Required]
            int PersonId

      );
}
