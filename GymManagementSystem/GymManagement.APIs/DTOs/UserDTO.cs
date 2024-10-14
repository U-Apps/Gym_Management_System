using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadUserDTO 
        (
             string UserName,
             bool IsActive

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
