using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using src.Context;
using src.Models;
using src.ViewModel;

namespace src.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToolsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ToolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Tags(Tools tools)
        {

            await _context.Tools.AddAsync(tools);
            await _context.SaveChangesAsync();

            ResultViewModel resultVM = new ResultViewModel{
                Id = tools.ToolsId,
                Title = tools.Title,
                Link = tools.Link,
                Description = tools.Description,
                Tags = tools.Tags
            };

            return Ok(resultVM);


        }
    }
}