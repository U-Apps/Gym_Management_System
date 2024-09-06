using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
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
        [Required]
        [StringLength(10, MinimumLength = 2)]
              string PeriodName,
              [DataType(DataType.Date)]
              DateTime StartTime,
              [DataType(DataType.Date)]
              DateTime EndTime

       );

    public record UpdatePeriodDTO
      (
            [Required]
            byte PeriodId,
            [StringLength(10, MinimumLength = 2)]
            string PeriodName,
            [DataType(DataType.Date)]
            TimeSpan StartTime,
            [DataType(DataType.Date)]
            TimeSpan EndTime

      );
}
