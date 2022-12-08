using EntityDatabase.Models;
using EntityDatabase.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntityTry.Controllers
{
    public class DataController : Controller
    {
        private InterfaceDataRepo dataRepo;
        public DataController(InterfaceDataRepo repo)
        {
            dataRepo = repo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Data data)
        {
            dataRepo.AddData(data);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var Data = dataRepo.GetAllDatas();
            return View(Data);
        }
        public IActionResult GetDetail(int id)
        {
            var Data = dataRepo.GetDataDetail(id);
            return View(Data);
        }
        public IActionResult Update(int id)
        {
            var Data = dataRepo.GetDataDetail(id);
            return View(Data);
        }
        [HttpPost]
        public IActionResult Update(Data data)
        {
            var Data = dataRepo.EditData(data);
            if (Data != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            var Data = dataRepo.GetDataDetail(id);
            return View(Data);
        }
        [HttpPost]
        public IActionResult Delete(Data data)
        {
            dataRepo.DeleteData(data.Id);
            return RedirectToAction("Index");
        }
    }
}
