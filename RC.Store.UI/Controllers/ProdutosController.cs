using RC.Store.UI.Data;
using RC.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;

namespace RC.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly RCStoreDataContext _ctx = new RCStoreDataContext();

        public ViewResult Index()
        {
            var produtos = _ctx.Produtos.ToList();
            return View(produtos);
        }

        [HttpGet]
        public ActionResult AddEdit(int? id)
        {
            Produto produto = new Produto();

            if (id != null)
            {
                produto = _ctx.Produtos.Find(id);
            }
            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(Produto produto)
        {
            if (produto.Id == 0)
            {
                _ctx.Produtos.Add(produto);
            }
            else
            {
                _ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            }
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var produto = _ctx.Produtos.Find(id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            _ctx.Produtos.Remove(produto);
            _ctx.SaveChanges();

            return null;
        }               

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}