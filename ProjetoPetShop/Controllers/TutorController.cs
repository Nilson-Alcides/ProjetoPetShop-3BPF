using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using ProjetoPetShop.Models;
using ProjetoPetShop.Models.Repositorio.Contrato;

namespace ProjetoPetShop.Controllers
{
    
    public class TutorController : Controller
    {
        private ITutorRepositorio _tutorRepositorio;

        public TutorController(ITutorRepositorio tutorRepositorio)
        {
            _tutorRepositorio = tutorRepositorio;
        }
        public IActionResult Index()
        {
            return View(_tutorRepositorio.ObterTodosTutor());
        }
        //Monta pagina com o formario
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Tutor tutor)
        {
            _tutorRepositorio.Cadastrar(tutor);
            return View();
        }
    }
}
