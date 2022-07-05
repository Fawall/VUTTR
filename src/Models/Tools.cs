using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class Tools
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "This Field can't null ")]
        [StringLength(32, ErrorMessage = "Limit this field exceeded: Limit is 32")]
        public string Title {get; set;}
        public string? Link { get; set; }

        public List<string>? Tags {get; set; }

        public Tools(string title, string link, List<string> tags)
        {
            Title = title;
            Link = link;
            Tags = tags;
        }
        public Tools(string title)
        {
            Title = title;
        }


    }
}