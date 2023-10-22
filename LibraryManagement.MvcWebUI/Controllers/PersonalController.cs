using LibraryManagement.Business.Abstract;
using LibraryManagement.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LibraryManagement.MvcWebUI.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _personalService;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetPersonalList()
        {
            var list = _personalService.GetAll();
            return JsonConvert.SerializeObject(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        //var errors = ModelState.Values.SelectMany(v => v.Errors); -- ModelState hatalarını gösterir.

        [HttpPost]
        public IActionResult Add(Personal personal)
        {
            if(ModelState.IsValid)
            {
                var addedPersonal = _personalService.Add(personal);
                if(addedPersonal != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(personal);
                }
            }
            return View(personal);
        }
    }
}
