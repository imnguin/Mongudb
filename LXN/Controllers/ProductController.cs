using LXN.BLL;
using LXN.ML;
using Microsoft.AspNetCore.Mvc;

namespace LXN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost("Search")]
        public async Task<IEnumerable<Product>> Search(string key)
        {
            return await BLL_Product.Search(key);
        }
        [HttpPost("LoadInfo")]
        public async Task<IEnumerable<Product>> LoadInfo(string ProductID)
        {
            return await BLL_Product.LoadInfo(ProductID);
        }
        [HttpPost("Add")]
        public async Task Add(Product objProduct)
        {
            await BLL_Product.Add(objProduct);
        }
        [HttpPost("Update")]
        public async Task Update(Product objProduct)
        {
            await BLL_Product.Update(objProduct);
        }
        [HttpPost("Delete")]
        public async Task Delete(string lstProductId)
        {
            await BLL_Product.Delete(lstProductId);
        }
    }
}
