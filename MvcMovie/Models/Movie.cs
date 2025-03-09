using System.componentModel.DataAnnotations;

namespace MvsMovie.Modenl;

public class Movie
{
    public int Id { get; set; }  
    public string? Title { get; set; }
    public DateTime releaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }

}