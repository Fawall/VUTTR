using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace src.Models
{
    public class Tools
    {
        [Key]
        public int ToolsId {get; set;}

        [Required(ErrorMessage = "This Field can't null ")]
        [StringLength(32, ErrorMessage = "Limit this field exceeded: Limit is 32")]
        private string Title {get; set;}
        private string? Link { get; set; }      
   
        public List<Tags>? Tags {get; set;}

        public Tools(string title, string link, List<Tags> tags)
        {
            Title = title;
            Link = link;
            Tags = tags;
        }
        public Tools(string title, string link)
        {
            Title = title;
            Link = link;
        }

        public Tools(string title)
        {
            Title = title;
        }



    }
}