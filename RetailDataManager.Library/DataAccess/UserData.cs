using RetailDataManager.Library.DataAccess.Internal.Models;
using RetailDataManager.Library.Internal.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            return sql.LoadData<UserModel, dynamic>("dbo.spUserData", new { Id }, "RetailData");
        }
    }
}
