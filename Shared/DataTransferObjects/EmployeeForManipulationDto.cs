using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public abstract record EmployeeForManipulationDto
    {
        [Required(ErrorMessage = "Employee name is a required field.")]
        string? Name { get; init; }

        [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower than 18.")]
        int Age { get; init; }

        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "maximum length for the Position is 20 characters.")]
        string? Position { get; init; }
    }
}