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

        [Required]
        [StringLength(250)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        [StringLength(14)]
        public string Cpf { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(9)]
        public string Cep { get; set; }

        [Required]
        [StringLength(250)]
        public string Street { get; set; }
    }
}
