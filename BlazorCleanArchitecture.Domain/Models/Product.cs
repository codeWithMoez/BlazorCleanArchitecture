using System.ComponentModel.DataAnnotations;
namespace BlazorCleanArchitecture.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
    }
}
