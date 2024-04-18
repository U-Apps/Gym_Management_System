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
        [Required]
        [StringLength(30, MinimumLength = 6)]
              string? Name,

              [Required]
              [DataType(DataType.Currency)]
              decimal? Price

       );

    public record UpdateSubscriptionPeriodDTO
      (
            [Required]
            byte Id,
            [Required]
        [StringLength(30, MinimumLength = 6)]
            string? Name,

            [Required]
            [DataType(DataType.Currency)]
            decimal? Price


      );
}
