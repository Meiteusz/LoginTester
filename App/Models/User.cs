using Microsoft.EntityFrameworkCore;
using Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Login), IsUnique = true)]
    [Index(nameof(Cpf), IsUnique = true)]
    public class User : IUser
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage ="Email is required!")]
        [StringLength(250)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Login is required!")]
        [StringLength(100)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required!")]
        public int Gender { get; set; }

        [Required(ErrorMessage = "Cpf is required!")]
        [StringLength(14)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Birthday is required!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Cep is required!")]
        [StringLength(9)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Street is required!")]
        [StringLength(250)]
        public string Street { get; set; }
    }
}
