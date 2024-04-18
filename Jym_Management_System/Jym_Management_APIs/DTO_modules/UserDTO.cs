using Jym_Management_DataAccessLayer.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadUserDTO 
        (
             string UserName,
              int PersonId,
             bool IsActive,
              ReadPersonDTO Person

        );

    public record CreateUserDTO
       (
         [Required]
         [StringLength(30, MinimumLength = 6)]
             string UserName,
          [Required]
          [DataType(DataType.Password)]
             string Password ,

             bool IsActive,
             [Required]
             int PersonId

       );

    public record UpdateUserDTO
      (
            [Required]
            short UserId ,
            [Required]
             [StringLength(30, MinimumLength = 6)]
            string UserName,
              [Required]
          [DataType(DataType.Password)]
            string Password ,

            bool IsActive,
            [Required]
            int PersonId

      );
}
