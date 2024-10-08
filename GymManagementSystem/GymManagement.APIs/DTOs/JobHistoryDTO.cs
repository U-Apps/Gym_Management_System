using System.ComponentModel.DataAnnotations;

namespace GymManagement.APIs.DTOs
{
    public record ReadJobHistoryDTO 
        (
             int Id ,
             int EmpoyeeId ,
          
             DateTime? StartDate,
        
             DateTime? EndDate ,

             ReadJobDTO Job 
                  
        );

    public record CreateJobHistoryDTO
       (
             [Required]
             int EmpoyeeId,

             [Required]
             byte JobId,
             [DataType(DataType.Date)]
             DateTime StartDate,
             [DataType(DataType.Date)]
             DateTime EndDate

       );

    public record UpdateJobHistoryDTO
      (
            [Required]
            int Id,

            [Required]
            int EmpoyeeId,

            [Required]
            byte JobId,
            [DataType(DataType.Date)]
            DateTime StartDate,
            [DataType(DataType.Date)]
            DateTime EndDate

      );
}
