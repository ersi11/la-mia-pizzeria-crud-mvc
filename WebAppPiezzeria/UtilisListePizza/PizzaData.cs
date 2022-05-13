using WebAppPiezzeria.Models;

namespace WebAppPiezzeria.UtilisListePizza
{
    public class PizzaData
    {
        private static List<Pizza> PizzaLista;
        public static List<Pizza> GetPizze()
        {
            if (PizzaData.PizzaLista != null)
            {
                return PizzaData.PizzaLista;
            }else
            {
                List<Pizza> lista = new List<Pizza>();
                Pizza pizzaMargherita = new Pizza(0,"Margherita", "Pomodoro, mozzarella, basilico fresco, sale e olio",
                    "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaMargherita);

                Pizza pizzaBoscaiola = new Pizza(1, "Boscaiola", "descrizione",
                   "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaBoscaiola);

                Pizza pizzaCampInTheSnow = new Pizza(2, "camp in the snow", "descrizione",
                  "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaCampInTheSnow);

                Pizza pizzaDiavola = new Pizza(3, "Diavola", "descrizione",
                  "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaDiavola);

                Pizza pizzaMarinara = new Pizza(4, "Marinara", "descrizione",
                  "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaMarinara);

                Pizza pizzaBurrata = new Pizza(5, "Burrata", "descrizione",
                  "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg", 8.00);
                lista.Add(pizzaBurrata);
                
                PizzaData.PizzaLista = lista;
                
                return PizzaData.PizzaLista;

            }
        }
    
    }
}
