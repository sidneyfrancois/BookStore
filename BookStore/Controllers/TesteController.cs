using BookStore.Domain;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("teste")]
    [Route("{Action=Principal}")]
    public class TesteController : Controller
    {
        public string Principal()
        {
            return "Ok! Da action principal ao invés de index";
        }

        public ViewResult Dados(int Id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Sidney"
            };

            ViewBag.Categoria = "Produtos de Limpeza";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Escritório";
            Session["Categoria"] = "Móveis";

            return View(autor);
        }

        public string Index()
        {
            return "teste dois";
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }

        [Route("minharota/{id:int?}")]
        public string MinhaAction(int? id)
        {
            return "Ok! Route arrived";
        }

        [Route("~/rotaignorada")]
        public string MinhaAction2()
        {
            return "Ok! Action2";
        }

        [Route("rota/{categoria:alpha:minlength(3)}")]
        public string MinhaAction3(string categoria)
        {
            return "Rota 3: " + categoria;
        }

        [Route("rota/estacao/{estacao:ValuesConstraint(primavera|verao|outono|inverno)}")]
        public string MinhaAction4(string estacao)
        {
            return "Ok! rota 4: " + estacao;
        }
    }
}