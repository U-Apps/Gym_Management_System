using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadUserDTO 
        (
              short UserId ,
              string UserName, 
              string Password ,

              bool IsActive,
              byte PermissionsId,

               ReadPermssionDTO Permissions,
               ReadPersonDTO Person 

        
        );

    public record CreateUserDTO
       (

             string UserName,
             string Password ,

             bool IsActive,
             [Required]
             byte PermissionsId

       );

    public record UpdateUserDTO
      (
            [Required]
            short UserId ,

            string UserName, 
            string Password ,

            bool IsActive,

            [Required]
            byte PermissionsId

      );
}
