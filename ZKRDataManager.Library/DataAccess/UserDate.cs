using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZKRDataManager.Library.Internal.DataAccess;
using ZKRDataManager.Library.Models;

namespace ZKRDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

         var output = sql.LoadData<UserModel, dynamic >("dbo.spUserLookUp", p, "ZKRData");

            return output;
        }
    }
}
