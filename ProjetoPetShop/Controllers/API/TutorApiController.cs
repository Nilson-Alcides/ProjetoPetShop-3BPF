using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using ProjetoPetShop.Models.Repositorio.Contrato;

namespace ProjetoPetShop.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class TutorApiController : Controller
    {
        private ITutorRepositorio _tutorRepositorio;

        public TutorApiController(ITutorRepositorio tutorRepositorio)
        {
            _tutorRepositorio = tutorRepositorio;
        }

        [HttpGet]
        public IActionResult ListarTutores()
        {
            var  tutores = _tutorRepositorio.ObterTodosTutor();
            return Ok(tutores);
        }
    }
}
