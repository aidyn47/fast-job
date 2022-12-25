using System.ComponentModel.DataAnnotations;

namespace FastJob.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
