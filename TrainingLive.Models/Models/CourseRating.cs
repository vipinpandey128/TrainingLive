using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLive.Models
{
    public class CourseRating : EntityModel
    {
        public int CourseRatingId { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course? Course { get; set; }
        public int Rating { get; set; }
        public bool IsDeleted { get; set; }
    }
}
