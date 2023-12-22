using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskManager.Entities
{
    public class Tasks
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Required]
        [StringLength(300)]
        public string TaskDescription { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskStatus { get; set; }
        public int TaskPriority { get; set; }
        public int UserId { get; set; }


    }
}
