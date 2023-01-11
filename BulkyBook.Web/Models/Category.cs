using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Web.Models;
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "عدد باید بین 1 و1 00 باشد")]
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}
