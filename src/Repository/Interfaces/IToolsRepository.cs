using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models;
using src.ViewModel;

namespace src.Repository.Interfaces
{
    public interface IToolsRepository
    {
        public Task<List<Tools>> GetAllTools();
        Task<Tools> GetToolsWithId(int id);
        Task<Tools> AddTool(Tools tools);
        
    }
}