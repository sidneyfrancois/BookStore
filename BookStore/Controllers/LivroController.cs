using BookStore.Context;
using BookStore.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class LivroController : Controller
    {
        BookStoreDataContext _db = new BookStoreDataContext();

        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _db.Categorias.ToList();
            var model = new EditarLivroViewModel()
            {
                Nome = "",
                ISBN = "",
                CategoriaId = 3,
                CategoriaOptions = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(EditarLivroViewModel model)
        {
            return View();
        }
    }
}