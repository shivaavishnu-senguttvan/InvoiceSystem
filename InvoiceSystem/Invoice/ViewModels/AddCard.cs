using System.ComponentModel.DataAnnotations;

namespace Invoice.ViewModels
{
    public class AddCard
    {
        public int Id { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}
