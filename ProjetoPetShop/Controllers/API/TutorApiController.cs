using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using ProjetoPetShop.Models;
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
        // Listar 
        [HttpGet]
        public IActionResult ListarTutores()
        {
            var  tutores = _tutorRepositorio.ObterTodosTutor();
            return Ok(tutores);
        }
        // Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Tutor tutor)
        {
            if (tutor is null)
            {
                return BadRequest(new
                {
                    mensagem = "Os dados do tutor são obrigatórios."
                });
            }
            _tutorRepositorio.Cadastrar(tutor);

            return Ok(new
            {
                mensagem = "Cadastro realizado com sucesso.",
                tutor = tutor
            });
        }
    }
}
