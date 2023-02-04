using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autor")]
    [Route("{Action=listar}")]
    public class AutorController : Controller
    {
        [Route("listar")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}