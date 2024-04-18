using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadExerciseTypeDTO 
        (
              byte ExerciseTypeId,
              string? Name
        
        );

    public record CreateExerciseTypeDTO (

        [Required]
        [StringLength(20, MinimumLength = 4)]
        string? Name
        
        
        );

    public record UpdateExerciseTypeDTO(
        [Required]
    
    byte ExerciseTypeId,
            [Required]
         [StringLength(20, MinimumLength = 4)]
        string? Name);
}
