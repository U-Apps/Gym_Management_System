using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadSubscriptionPeriodDTO
        (
              byte Id,
              string? Name,
              decimal? Price

        );

    public record CreateSubscriptionPeriodDTO
       (
              string? Name,

              [Required]
              decimal? Price

       );

    public record UpdateSubscriptionPeriodDTO
      (
            [Required]
            byte Id,

            string? Name,

            [Required]
            decimal? Price


      );
}
