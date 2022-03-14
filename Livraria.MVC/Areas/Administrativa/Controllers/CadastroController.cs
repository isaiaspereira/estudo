using System.Web.Mvc;

namespace Livraria.MVC.Areas.Administrativa.Controllers
{
    public class CadastroController : Controller
    {
        //private readonly LivroRepository ;
        // GET: Administrativa/Cadastro
        public ActionResult Index()
        {
            return View();
        }
    }
}