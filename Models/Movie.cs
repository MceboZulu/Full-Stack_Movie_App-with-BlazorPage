using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(60, MinimumLength =3, ErrorMessage = "Title must be between 3 and 60 characters")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Date is required")]
    [DataType(DataType.Date)]
    public DateOnly ReleaseDate { get; set; }

    [Required(ErrorMessage = "Genre is required")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Genre must be between 3 and 30 characters")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$", ErrorMessage = "Genre must start with a capital letter and can only contain letters, parenthesis, space, and hyphen")]
    public string? Genre { get; set; } = string.Empty;

    [Range(50, 1000, ErrorMessage = "Price must be between 50 and 1000")]
    [Required(ErrorMessage = "Price is required")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Rating is required")]
    [RegularExpression(@"^(G|PG|PG-13|R|NC-17)$")]
    public string? Rating { get; set; }
}