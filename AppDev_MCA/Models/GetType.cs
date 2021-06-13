using System.ComponentModel.DataAnnotations;

namespace AppDev_MCA.Models
{
    public partial class TrainerUser
    {
        public enum GetType
        {
            [Display(Name = "Selecte Type")]
            Selectetype = 0,
            Internal = 1,
            External = 2
        }
    }
}