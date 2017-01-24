using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StMnSystem.Models
{

    public class EvaluationModel
    {
            [Required]
            [Display(Name = "User ID")]
            public string Email
            {
                get; set;
            }

            [Required]
            [Display(Name = "Mark")]
            public int Marks
            {
                get; set;
            }

            [Required]
            [Display(Name = "Level")]
            public string Level
            {
                get; set;
            }

            [Required]
            [Display(Name = "Subject")]
            public string Subject
            {
                get; set;
            }
        
    }
}