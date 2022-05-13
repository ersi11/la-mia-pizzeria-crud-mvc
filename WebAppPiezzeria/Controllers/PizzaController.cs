using Microsoft.AspNetCore.Mvc;
using WebAppPiezzeria.Models;
using WebAppPiezzeria.UtilisListePizza;

namespace WebAppPiezzeria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzaList = PizzaData.GetPizze();
            return View("Index", pizzaList);
        }
        
        // /Pizza/Details
        [HttpGet]
        public IActionResult Details(int id)
        {
            Pizza pizza = null;

            foreach (Pizza OgniPizza in PizzaData.GetPizze())
            {
                if (OgniPizza.Id == id)
                {
                    pizza = OgniPizza;
                    break;

                }
            }   
                if (pizza == null)
                {
                    return NotFound("Errore");
                }else
                {
                    return View("Details", pizza);
                }

            
            
        }
        [HttpGet]
        public IActionResult CreaPaginaPizza()
        {
            return View("NuovoForm");
        }
   
    
    
    [HttpPost]
    public IActionResult CreaPaginaPizza(Pizza pizzaNuovaAggiunta)
        {
            if (!ModelState.IsValid)
            {
                return View("NuovoForm", pizzaNuovaAggiunta);
            }
            Pizza nuovaPizza = new Pizza(PizzaData.GetPizze().Count + 1, pizzaNuovaAggiunta.Nome, pizzaNuovaAggiunta.Descrizione, pizzaNuovaAggiunta.Img,
                pizzaNuovaAggiunta.Prezzo);
            PizzaData.GetPizze().Add(nuovaPizza);
            return RedirectToAction("Index");
        }
    
    }





}
