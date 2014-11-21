using System.ComponentModel.DataAnnotations;

namespace ASP.NET_5_Starter_Web_Application.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}
