using System.ComponentModel.DataAnnotations;

namespace PromotigoMVC.Models
{
    public class DrawViewModel
    {
        public DrawViewModel()
        {
            NumberOfEntrants = 0;
        }
        [Range(1, 10, ErrorMessage = "Number of entrants should be between 1 and 10")]
        public int NumberOfEntrants { get; set; }
        public List<Entrant>? Winners { get;set;}
    }
}
