using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text;
using WebAPIPractice.Contracts;
using WebAPIPractice.Models;

namespace WebAPIPractice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IOptions<HomeOptions> options;
        private IMapper mapper;

        public HomeController(IOptions<HomeOptions> options, IMapper mapper)
        {
            this.options = options;
            this.mapper = mapper;
        }

        [HttpGet] // Для обслуживания Get-запросов
        [Route("info")] // Настройка маршрута с помощью атрибутов
        public IActionResult Info()
        {
            var infoResponse = mapper.Map<HomeOptions, InfoResponse>(options.Value);

            // Преобразуем результат в строку и выводим, как обычную веб-страницу
            return StatusCode(200, infoResponse);
        }
    }
}
