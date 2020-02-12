using RetailDataManager.Library.Internal.DataAccess;
using System.Collections.Generic;

namespace RetailDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetAllProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();
            return sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "RetailData");
        }
    }

}
