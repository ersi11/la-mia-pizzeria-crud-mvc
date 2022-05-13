using System.ComponentModel.DataAnnotations;

namespace WebAppPiezzeria.Models
{
    public class Pizza
    {
       
        [Required(ErrorMessage = "Campo Nome obbligatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo descrizione obbligatorio")]
        public string Descrizione { get; set; }
        



        public int Id { get; set; }

       
        
        [Required(ErrorMessage = "Campo Immagine obbligatorio")]
        public string Img { get; set; }


        [Required(ErrorMessage = "Campo Prezzo obbligatorio")]
        [Range(6,20,ErrorMessage = "Prezzo sbagliato")]
        public double Prezzo { get; set; }
       
        
        
        
        
        
        public Pizza() { }

        public Pizza(int Id, string nome, string descrizione, string img, double prezzo)
        {
            this.Id = Id;
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Img = img;
            this.Prezzo = prezzo;
            
        }
    }
}
