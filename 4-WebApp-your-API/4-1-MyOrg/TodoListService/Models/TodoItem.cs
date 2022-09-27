 using System.ComponentModel.DataAnnotations.Schema;
 using System.ComponentModel.DataAnnotations;

namespace TodoListService.Models
{
    /// <summary>
    /// Data object to transfer information between client/server/database
    /// </summary>
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Owner { get; set; }
    }
}
