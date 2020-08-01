using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ZKRDataManager.Library.DataAccess;
using ZKRDataManager.Library.Models;

namespace ZKRDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController 
    {
        // GET: User/Details/5
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId);
        }
    }
}
