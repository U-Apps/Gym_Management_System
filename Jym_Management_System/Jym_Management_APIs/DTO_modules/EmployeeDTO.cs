using Jym_Management_BussinessLayer.Modules;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jym_Management_APIs.DTO_modules
{
    public record ReadEmployeeDTO
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public decimal Salary { get; set; }

        public ReadPersonDTO person { get; set; }

    }
    public record UpdateEmployeeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        [Required]

        public decimal Salary { get; set; }


    }

    public record CreateEmployeeDTO
    {
        [Required]

        public int PersonId { get; set; }
       

        public DateTime HireDate { get; set; }
        public DateTime ResignationDate { get; set; }
        [Required]

        public decimal Salary { get; set; }


    }
}
