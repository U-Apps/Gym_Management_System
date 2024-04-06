using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadExerciseTypeDTO 
        (
              byte ExerciseTypeId,
              string? Name
        
        );

    public record CreateExerciseTypeDTO (string? Name);

    public record UpdateExerciseTypeDTO([Required] byte ExerciseTypeId, string? Name);
}
