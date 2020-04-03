using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.BusinessLogic.Interfaces
{
    public interface ISession
    {
        System.Web.HttpCookie GenCookie(object credential);
        object UserLogin(object data);
    }
}
