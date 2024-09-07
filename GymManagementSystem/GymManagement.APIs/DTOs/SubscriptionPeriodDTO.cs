using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
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
