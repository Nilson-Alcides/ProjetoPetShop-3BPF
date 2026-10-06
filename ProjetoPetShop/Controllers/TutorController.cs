using Microsoft.AspNetCore.Mvc;
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
    }
}
