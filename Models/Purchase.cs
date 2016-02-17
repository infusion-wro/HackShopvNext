using System.ComponentModel.DataAnnotations;

namespace HackShopvNext.Models
{

    public class Purchase
    {
        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter VodkaCount value bigger than {1}")]
        [Display(Name = "Vodka Count")]
        public int VodkaCount { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter VodkaPrice value bigger than {1}")]
        [Display(Name = "Vodka Price")]
        public double VodkaPrice { get; set; }
        //public float VodkaCount { get; set; }
    }
}