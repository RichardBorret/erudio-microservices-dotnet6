using GeekShooping.ProductAPI.Data.ValueObjects;

namespace GeekShooping.ProductAPI.Repository
{
   public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO Vo);
        Task<ProductVO> Update(ProductVO vO);
        Task<bool> Delete(long id);
    }
}
