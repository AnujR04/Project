
using Microsoft.EntityFrameworkCore;
using Project.MyProject.DAL;
using Project.ProjectService;
using System;

namespace Project.MyProject.BLL
{

    public class SalesService : ISalesService
    {
        private readonly MyDbContext _context;

        public SalesService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Sales> GetSaleAsync(int id)
        {
            return await _context.sales.FindAsync(id);
        }

        public async Task<Sales> CreateSaleAsync(Sales sale)
        {
            _context.sales.Add(sale);
            await _context.SaveChangesAsync();
            return sale;
        }

        public async Task<Sales> UpdateSaleAsync(int id, Sales sale)
        {
            if (id != sale.SalesId)
            {
                throw new ArgumentException("Sale ID mismatch");
            }

            _context.Entry(sale).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return sale;
        }

        public async Task DeleteSaleAsync(int id)
        {
            var sale = await _context.sales.FindAsync(id);
            if (sale != null)
            {
                _context.sales.Remove(sale);
                await _context.SaveChangesAsync();
            }
        }
    }
}
