using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "Documento de identidad")]
        [Required(ErrorMessage = "The document field is required.")]
        [MaxLength(20, ErrorMessage = "The document field cannot more than 20 characters.")]
        public string Document { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "The document field is required.")]
        [MaxLength(50, ErrorMessage = "The Name field cannot more than 20 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "The document field is required.")]
        [MaxLength(50, ErrorMessage = "The lastname field cannot more than 20 characters.")]
        public string LastName { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(20, ErrorMessage = "The phone field cannot more than 20 characters.")]
        public string FixedPhone { get; set; }
        [Display(Name = "Movil")]
        [Required(ErrorMessage = "The Cellphone field is required.")]
        [MaxLength(20, ErrorMessage = "The Cellphone field cannot more than 20 characters.")]
        public string CellPhone { get; set; }

        [Display(Name = "Direccion residencia")]
        [Required(ErrorMessage = "The Address field is required.")]
        [MaxLength(80, ErrorMessage = "The Address field cannot more than 20 characters.")]
        public string Address { get; set; }
        public string FullName => $"{FirstName} {LastName}".TrimEnd(); 

    }
}
