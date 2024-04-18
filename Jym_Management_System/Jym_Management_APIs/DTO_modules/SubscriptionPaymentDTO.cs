using System.ComponentModel.DataAnnotations;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadSubscriptionPaymentDTO
        (
             int PaymentId ,
             DateTime? PaymentDate,
             decimal? PaymentAmount,

            ReadUserDTO CreatedByUser ,
            ReadSubscriptionDTO Subscription


        
        );

    public record CreateSubscriptionPaymentDTO
       (

             [Required]
             int SubscriptionId,

             [Required]
             [DataType(DataType.DateTime)]
             DateTime? PaymentDate,
             [Required]
             decimal? PaymentAmount,
             [Required]
             short? CreatedByUserId

       );

    public record UpdateSubscriptionPaymentDTO
      (
             [Required]
             int PaymentId,

             [Required]
             int? SubscriptionId,

             [Required]
             [DataType(DataType.DateTime)]
             DateTime? PaymentDate,
             [Required]
             decimal? PaymentAmount,
             [Required]
             short? CreatedByUserId

      );
}
