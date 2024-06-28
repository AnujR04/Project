using Project.MyProject.DAL;

namespace Project.MyProject.BLL
{
    public interface IProductService
    {

        Task<Product> GetProductAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(int id, Product product);
        Task DeleteProductAsync(int id);
    }

}

