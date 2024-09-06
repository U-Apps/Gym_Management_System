using Jym_Management_DataAccessLayer.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadUserDTO 
        (
             string UserName,
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
