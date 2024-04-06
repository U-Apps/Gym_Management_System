using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadPeriodDTO 
        (
              byte PeriodId,
              string PeriodName,

              TimeSpan StartTime,
              TimeSpan EndTime

        );

    public record CreatePeriodDTO
       (
              string PeriodName,

              TimeSpan StartTime,
              TimeSpan EndTime

       );

    public record UpdatePeriodDTO
      (
            [Required]
            byte PeriodId,

            string PeriodName,

            TimeSpan StartTime,
            TimeSpan EndTime

      );
}
