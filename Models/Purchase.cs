using System.ComponentModel.DataAnnotations;

namespace HackShopvNext.Models
{

    public class Purchase
    {
        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter a value bigger than {1}")]
        [Display(Name = "Vodka Count")]
        public double VodkaCount { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        [Display(Name = "Vodka Price")]
        public double VodkaPrice { get; set; }
        //public float VodkaCount { get; set; }
    }
}