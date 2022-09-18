using ASP.Net6Repository.DAL;
using ASP.Net6Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net6Repository.Controllers
{
    public class RepoController : Controller
    {
        private ISathyaRepo interfaceobj;
        public RepoController()
        {
            interfaceobj = new SathyaRepo(new RepoDbContext());

        }

        public IActionResult Index()
        {
            var data=from m in interfaceobj.GetRepositorys() select m;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Repository R)
        {
            interfaceobj.InsertRepository(R);
            interfaceobj.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Repository r=interfaceobj.GetRepositoryByID(id);
            return View(r);
        }
        public IActionResult Delete(int id)
        {
            Repository r = interfaceobj.GetRepositoryByID(id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Delete(int id,Repository r)
        {
            interfaceobj.DeleteRepository(id);
            interfaceobj.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Repository r = interfaceobj.GetRepositoryByID(id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Edit(int id,Repository r)
        {
            interfaceobj.UpdateRepository(r);
            interfaceobj.Save();
            return RedirectToAction("Index");
        }

    }
    
}
