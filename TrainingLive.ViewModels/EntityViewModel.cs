using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLive.ViewModels
{
    public class EntityViewModel
    {
        public int? CreatedBy { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
