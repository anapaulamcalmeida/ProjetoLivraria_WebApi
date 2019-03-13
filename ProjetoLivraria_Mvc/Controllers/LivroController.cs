using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ProjetoLivraria_Mvc.Models;

namespace ProjetoLivraria_Mvc.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            IEnumerable<MvcLivroModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Livro").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<MvcLivroModel>>().Result;
            return View(empList);
        }
    }
}