using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaTecnica.Models
{
    public class CustomerModel : BaseModel
    {
        public CustomerModel() { }

        [Display(Name = "name")]
        public string Name { get; set; }

        [Display(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(Name = "email")]
        public string Email { get; set; }

        [Display(Name = "notes")]
        public string Notes { get; set; }
    }
}
