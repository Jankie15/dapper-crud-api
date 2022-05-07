using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaTecnica.Models
{
    public class BaseModel
    {
        [Display(Name = "id")]
        public Guid Id { get; set; }

        [Display(Name = "state")]
        public bool State { get; set; }
    }
}
