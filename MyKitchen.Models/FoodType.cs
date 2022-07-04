using System.ComponentModel.DataAnnotations;

namespace MyKitchen.Models
{
#pragma warning disable
    public class FoodType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
