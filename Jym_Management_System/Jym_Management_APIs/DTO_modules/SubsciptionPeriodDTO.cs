using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadSubsciptionPeriodDTO
        (
              byte Id,
              string? Name,
              decimal? Price

        );

    public record CreateSubsciptionPeriodDTO
       (
              string? Name,

              [Required]
              decimal? Price

       );

    public record UpdateSubsciptionPeriodDTO
      (
            [Required]
            byte Id,

            string? Name,

            [Required]
            decimal? Price


      );
}
