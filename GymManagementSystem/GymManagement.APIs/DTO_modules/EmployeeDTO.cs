using Jym_Management_BussinessLayer.Modules;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadPaymnetsForEmployee
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; } 

    }
    public record ReadEmployeeDTO
    {

        public int EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public decimal Salary { get; set; }
        public virtual ReadJobDTO CurrentJob { get; set; }

        public ReadPersonDTO person { get; set; }

       
       public List<ReadPaymnetsForEmployee> payments { get; set; }
    }
    public record UpdateEmployeeDTO
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        [DataType(DataType.CreditCard)]
        public string? Idcard { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ResignationDate { get; set; }
        public byte? CurrentJop { get; set; }
        [Required]

        public decimal Salary { get; set; }


    }

    public record CreateEmployeeDTO
    {
        [Required]
        [DataType(DataType.CreditCard)]
        public string? Idcard { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public DateTime HireDate { get; set; }
        //public DateTime ResignationDate { get; set; }

        public byte? CurrentJop { get; set; }
        [Required]


        public decimal Salary { get; set; }


    }
}
