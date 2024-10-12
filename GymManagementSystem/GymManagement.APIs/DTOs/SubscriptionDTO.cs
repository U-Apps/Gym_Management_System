using GymManagement.BusinessCore.DTOs;
using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadSubscriptionDTO
        (
             int SubscriptionId,
             DateTime StartDate ,
             DateTime EndDate ,

             ReadJobHistoryDTO Coach ,
             ReadJobHistoryDTO CreatedByReceptionist ,
             ReadExerciseTypeDTO ExcerciseType ,
             MemberResponse Member ,
             ReadPeriodDTO Period ,
             ReadSubscriptionPeriodDTO SubscriptionPeriod 
        
        );

    public record CreateSubscriptionInfo
    {

        public int? CoachId { get; init; }

        [Required]
        public byte ExcerciseTypeId { get; init; }
        [Required]
        public byte PeriodId { get; init; }
        [Required]
        public byte SubscriptionPeriodId { get; init; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; init; }

        public CreateSubscriptionInfo()
        {
            
        }
    }
    public record CreateSubscriptionDTO: CreateSubscriptionInfo
    {
        [Required]
        public int MemberId { get; init; }
        
        public CreateSubscriptionDTO()
        {
            
        }
    }
    
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
            DateTime StartDate,
            DateTime EndDate,

            [Required]
            byte SubscriptionPeriodId

      );
}
