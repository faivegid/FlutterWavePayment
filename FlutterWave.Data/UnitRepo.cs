using FlutterWave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Data
{
    public class UnitRepo
    {
        private readonly AppDbContext _context;

        public UnitRepo(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async void AddEntity<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public  void UpdateEntity<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
