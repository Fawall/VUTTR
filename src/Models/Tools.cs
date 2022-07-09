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
        public string? Title {get; set;}
        public string? Link { get; set; }      

        public string[]? Tags {get; set;}


    }
}