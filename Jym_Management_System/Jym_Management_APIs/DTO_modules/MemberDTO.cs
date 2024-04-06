using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadMemberDTO 
        (
              int MemberId,
              int PersonId ,
              decimal? MemberWeight ,
              bool? IsActive ,

              ReadPersonDTO Person
        
        );

    public record CreateMemberDTO
       (
             [Required]
             int PersonId,
             [Range(1,200)]
             decimal? MemberWeight,
             bool? IsActive

       );

    public record UpdateMemberDTO
      (
            [Required]
             int MemberId,
            [Required]
             int PersonId,
            [Range(1,200)]
             decimal? MemberWeight,
            bool? IsActive

      );
}
