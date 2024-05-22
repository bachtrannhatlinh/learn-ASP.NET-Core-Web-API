using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
// using api.Dtos.Comment;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
      private readonly ApplicationDBContext _context;

      public StockRepository(ApplicationDBContext context, IStockRepository stockRepository)
      {
        _context = context;
      }

      public Task<List<Stock>> GetAllAsync()
      {
        return _context.Stocks.ToListAsync();
      }
    }
}