using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLive.Models
{
    
    public class Course : EntityModel
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(20)]
        public string CourseName { get; set; }
        [Required]
        public int Price { get; set; }
        public string Duration { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual CourseRating CourseRating { get; set; }
    }

}
