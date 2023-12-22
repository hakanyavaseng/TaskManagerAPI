using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TaskManager.Entities
{
    public class Users
    {
   
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserPassword { get; set; }



    }
}