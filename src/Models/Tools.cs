using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace src.Models
{
    public class Tools
    {
        [Key]
        [JsonIgnore]
        public int ToolsId {get; set;}

        [Required(ErrorMessage = "This Field can't null ")]
        [StringLength(32, ErrorMessage = "Limit this field exceeded: Limit is 32")]
        public string? Title {get; set;}
        public string? Link { get; set; }  

        [StringLength(290, ErrorMessage = "Limit this field exceed: Limit is 290")]
        public string? Description {get; set;}    

        public string[]? Tags {get; set;}


    }
}