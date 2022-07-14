using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models;
using src.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using src.Context;

namespace src.Repository
{
    public class ToolsRepository : IToolsRepository
    {
        private readonly ApplicationDbContext _context ;
        public ToolsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tools> AddTool(Tools tools)
        {
            await _context.Tools.AddAsync(tools);
            await _context.SaveChangesAsync();

            return tools;
        }

        public async Task<List<Tools>> GetAllTools()
        {
            var toolsList = await _context.Tools.AsNoTracking().ToListAsync();
            
            return toolsList;

        }

        public async Task<Tools> GetToolsWithId(int id)
        {
            var tool = await _context.Tools.FindAsync(id);

            return tool;
     
        }
    }
}