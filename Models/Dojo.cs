using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dojodhachi.Models
{
    public class Dojo
    {
         [Required]
        [MinLength(3 ,ErrorMessage="Field must be 3 characters or more")]
        [Display(Name = "Your Name:")] 
        public string Name { get; set; }

        [Display(Name = "Dojo Location:")] 
public string Location {get; set; }

// another way--------
// public List<SelectListItem> Locationlists { get; } = new List<SelectListItem>  
//         {  
//             new SelectListItem { Value = "Bellevue", Text = "Bellevue" },  
//             new SelectListItem { Value = "San Hose", Text = "San Hose" },  
//         };  

        [Display(Name = "Favourite Language:")] 
        public string Language { get; set; }

        [Required]
        [Display(Name = "Comment:" )]
        public string Comment{ get; set; }

        public Dojo(string name,string location,string language,string comment)
        {
            Name = name;
            Location=location;
            Language=language;
            Comment=comment;
        }
        public Dojo()
        {
            
        }

    }
}