using System.Net.Http.Headers;
using ApiExterna.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiExterna.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<BookApiResModel>> getAllBooks()
    {
        string url = "https://example-data.draftbit.com/books?_limit=10";
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // conv resp json a string
                var responseContent = await response.Content.ReadAsStringAsync();
                // conv string a clase
                List<BookApiResModel> result = JsonConvert.DeserializeObject<List<BookApiResModel>>(responseContent);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}