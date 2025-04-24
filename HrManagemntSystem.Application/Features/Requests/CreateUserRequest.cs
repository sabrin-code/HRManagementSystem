using HrManagemntSystem.Application.Features.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HrManagemntSystem.Application.Dtos
{
    public class CreateUserRequest : IRequest<CreateUserResult>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Şifrələr uyğun deyil.")]
        public string ConfirmPassword { get; set; }

        // Əgər user müəyyən işçiyə bağlı olacaqsa
        public int? EmployeeId { get; set; }
    }
}
