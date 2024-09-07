using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadJobDTO (byte JobId, string JobTitle);

    public record CreateJobDTO (

          [Required]
          [StringLength(20, MinimumLength = 5)]
        string JobTitle
        
        
        
        );

    public record UpdateJobDTO
      (
            [Required]
            byte JobId,
            [Required]
          [StringLength(20, MinimumLength = 5)]
            string JobTitle

      );
}
