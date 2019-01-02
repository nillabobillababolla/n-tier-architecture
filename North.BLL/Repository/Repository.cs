using System;
using North.Models.Entities;
using System;
using North.Models.ViewModels;

namespace North.BLL.Repository
{
    public class ProductRepo:RepositoryBase<Product,Guid>
    {
        public int AddOrder(OrderViewModel model)
        {
            try
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    return 1;
                }
            }
            catch
            {
                throw;
            }
        }
    }

    public class CategoryRepo
    {

    }
}
