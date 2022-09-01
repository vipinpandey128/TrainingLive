using System.ComponentModel.DataAnnotations;

namespace TrainingLive.Common
{
    public enum Gender
    {
        [Display(Name = "Male")]
        Male = 0,
        [Display(Name = "Female")]
        Female = 1,
        [Display(Name = "Other")]
        Other = 2
    }
}