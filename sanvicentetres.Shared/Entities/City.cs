﻿using System.ComponentModel.DataAnnotations;

namespace sanvicentetres.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;
        public int StateId { get; set; }
        public State? State { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
