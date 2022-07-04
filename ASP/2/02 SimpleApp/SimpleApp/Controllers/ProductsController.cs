using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Controllers
{
    [Route("Products")]
    public class ProductsController : Controller
    {
        private ProductReader reader;

        // ВНИМАНИЕ.
        // Каждый запрос обрабатывает новый экземпляр контроллера.
        // Конструктор будет вызываться перед вызовом метода List и метода Details
        // После обработки запроса, экземпляр контроллера будет удален из памяти
        public ProductsController()
        {
            reader = new ProductReader();
        }

        //Products/List
        // Сводка: View
        // Создает объект Microsoft.AspNetCore.Mvc.ViewResult, который отображает представление для
        //     отклик.
        //
        // Возврат:
        // Созданный объект Microsoft.AspNetCore.Mvc.ViewResult для ответа.
        //public virtual ViewResult View();
        ///Home/Index

        //public class ViewResult : ActionResult, IActionResult, IStatusCodeActionResult
        [Route("~/")]
        [Route("List")]
        public IActionResult List()
        {
            List<Product> products = reader.ReadFromFile();
            return View(products);
        }

        [Route("List/{category?}")]
        public IActionResult List(string category) {
            List<Product> products = reader.ReadFromFile();
            List<Product> result = new List<Product>();
			foreach (var item in products) {
                if (item.Category == category) {
                    result.Add(item);
                }
			}
            return View(result);
        }

        //Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = reader.ReadFromFile();
            Product product = products.FirstOrDefault(x => x.Id == id);

            if (product != null)
            {
                // Возврат представления с именем Details и передача представлению экземпляра product
                // В представление доступ к экземпляру можно получить через свойство представления Model
                return View(product);
            }
            else
            {
                // Возврат ошибки 404
                return NotFound();
            }
        }
    }
}