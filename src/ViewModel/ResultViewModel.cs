using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.ViewModel
{
    public class ResultViewModel
    {
        public int Id {get; set;}
        public string? Title { get; set;}
        public string? Link {get; set;}
        public string[]? Tags { get; set; }


    }
}