using RagnaTours.Services;
using System.ComponentModel.DataAnnotations;

namespace RagnaTours.Models
{
    public class Exhibition
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public string ThemeName { get; set; }

    }
}
