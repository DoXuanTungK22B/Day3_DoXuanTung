using System.ComponentModel.DataAnnotations;

namespace Day3_DoXuanTung.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100,MinimumLength = 2,ErrorMessage = "Ten danh muc phai tu 2-100 ky tu")]
        public string? Name { get; set; }
        //navigation property to Products
        public List<Product>? Products { get; set; }
    }
}
