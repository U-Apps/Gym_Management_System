using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadJobDTO ([Required] byte JobId, string JobTitle);

    public record CreateJobDTO ( string JobTitle );

    public record UpdateJobDTO
      (
            [Required]
            byte JobId,
            string JobTitle

      );
}
