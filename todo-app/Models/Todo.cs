using System.ComponentModel.DataAnnotations
namespace todo_app.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a description")]
        public string Description { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

    }

}
