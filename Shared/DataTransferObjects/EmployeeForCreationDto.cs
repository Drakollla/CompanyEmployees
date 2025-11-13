using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record EmployeeForCreationDto(
    
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage ="Maximum length for the Name is 30 characters.")]
        string? Name,

        [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower than 18")]
        int Age,

        [Required(ErrorMessage ="Position is a required field.")]
        [MaxLength(20, ErrorMessage = "maximum length for the Position is 20 characters.")]
        string? Position
    );
}