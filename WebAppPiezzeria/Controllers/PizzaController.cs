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



        [HttpGet]
        public IActionResult ModificaPizza(int id)
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
      
        if(pizza == null)
            {
                return NotFound();
            }
        else
            {
                return View("Modifica", pizza);
            }
        }
        
        
        
        
        [HttpPost]
        public IActionResult ModificaPizza(int id, Pizza pizzaModificata)
        {
            if (!ModelState.IsValid)
            {
                return View("Modifica", pizzaModificata);
            }
        Pizza pizzaDaModificare = null;

            foreach (Pizza pizza in PizzaData.GetPizze())
            {
                if (pizza.Id == id)
                {
                    pizzaDaModificare = pizza;
                    break;
                }
            }
            if (pizzaDaModificare != null)
            {
                pizzaDaModificare.Nome = pizzaModificata.Nome;
                pizzaDaModificare.Descrizione = pizzaModificata.Descrizione;
                pizzaDaModificare.Prezzo = pizzaModificata.Prezzo;
                pizzaDaModificare.Img = pizzaModificata.Img;
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult EliminaPizza(int id)
        {
            int indiceDaTrovare = -1;
            List<Pizza> listaPizza = PizzaData.GetPizze();
            for(int i = 0; i<listaPizza.Count; i++)
            {
                if (listaPizza[i].Id == id)
                {
                    indiceDaTrovare = i;
                }
            
            
            }
        if(indiceDaTrovare == -1)
            {
                return NotFound();
            }
            else
            {
                PizzaData.GetPizze().RemoveAt(indiceDaTrovare);
            }
            return RedirectToAction("Index");
        }





    }


}
