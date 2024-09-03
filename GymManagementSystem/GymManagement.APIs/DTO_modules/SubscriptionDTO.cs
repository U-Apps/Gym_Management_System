using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadSubscriptionDTO
        (
             int SubscriptionId,
             DateTime? StartDate ,
             DateTime? EndDate ,

             ReadJobHistoryDTO Coach ,
             ReadJobHistoryDTO CreatedByReceptionist ,
             ReadExerciseTypeDTO ExcerciseType ,
             ReadMemberDTO Member ,
             ReadPeriodDTO Period ,
             ReadSubscriptionPeriodDTO SubscriptionPeriod 
        
        );

    public record CreateSubscriptionDTO
       (
            [Required]
            int MemberId,
            [Required]
            int CoachId,
            [Required]
            int CreatedByReceptionistId,
            [Required]
            byte ExcerciseTypeId,
            [Required]
            byte PeriodId,
            [Required]
            [DataType(DataType.DateTime)]
            DateTime? StartDate,
            [DataType(DataType.DateTime)]
            DateTime? EndDate,

            [Required]
            byte SubscriptionPeriodId

       );

    public record UpdateSubscriptionDTO
      (
            [Required]
            int SubscriptionId,
            [Required]
            int MemberId,
            [Required]
            int CoachId,
            [Required]
            int CreatedByReceptionistId,
            [Required]
            byte ExcerciseTypeId,
            [Required]
            byte PeriodId,
            
            [Required]
            [DataType(DataType.DateTime)]
            DateTime? StartDate,
            DateTime? EndDate,

            [Required]
            byte SubscriptionPeriodId

      );
}
