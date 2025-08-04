using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiExterna.Models;

public class BookApiResModel
{
    public int Id { get; set; }
    public string? Title { get; set; } 
    public string? Authors { get; set; } 
    public string? Description { get; set; } 
    
    [JsonProperty("num_pages")]
    public int? NumPages { get; set; } 

    public double? Rating { get; set; } 
    public string? Genres { get; set; }
    
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }
}