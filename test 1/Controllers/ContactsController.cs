using Microsoft.AspNetCore.Mvc;
using test_1.Models;

namespace test_1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]// указываю что принимаю данные через post запрос, входной параметр метода это класс модели
        public IActionResult Cheack(Contact contact)
        {
            // получаю из модели Contact обьект  contact содержащий в себе данные формы
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
