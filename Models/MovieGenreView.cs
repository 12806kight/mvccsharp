using Microsoft.AspNetCore.Mvc.Rendering;
using ModelViewController.Models;

namespace ModelViewController.Models;

public class MovieGenreView
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}
