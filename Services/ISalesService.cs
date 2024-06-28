using Microsoft.AspNetCore.Mvc;
using Project.MyProject.DAL;

namespace Project.MyProject.BLL
{
    public interface ISalesService
    {
        Task<Sales> GetSaleAsync(int id);
        Task<Sales> CreateSaleAsync(Sales sale);
        Task<Sales> UpdateSaleAsync(int id, Sales sale);
        Task DeleteSaleAsync(int id);

    }
}
