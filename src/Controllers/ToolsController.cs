using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Context;
using src.Models;
using src.Repository.Interfaces;

namespace src.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToolsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IToolsRepository _toolsRepository;
        public ToolsController(ApplicationDbContext context, IToolsRepository toolsRepository)
        {
            _context = context;
            _toolsRepository = toolsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Tools(Tools tools)
        {
            var addTool = await _toolsRepository.AddTool(tools);
            return Ok(addTool);
        }

        [HttpGet]
        public async Task<List<Tools>> Tools()
        {
            var listTools =  await _toolsRepository.GetAllTools();

            return listTools;
        }


        [HttpGet("id")]
        public async Task<IActionResult> Tools(int id)
        {
            var tool = await _toolsRepository.GetToolsWithId(id);
            if(tool != null)
                return Ok(tool);
            return NotFound();
        }
    }
}