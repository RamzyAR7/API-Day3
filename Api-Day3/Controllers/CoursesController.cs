using Api_Day3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Day3.Controllers
{
    public class CoursesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7119/api/Course");
            if (response.IsSuccessStatusCode)
            {
                var Data = await response.Content.ReadFromJsonAsync<List<CoursesDto>>();
                return View(Data);
            }
            return BadRequest();
        }
    }
}
