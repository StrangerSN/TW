using MusicShop.BusinessLogic.Core;
using MusicShop.BusinessLogic.Interfaces;
using System.Web;   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Domain.Entities.User;

namespace MusicShop.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return new ULoginResp();    //UserLoginAction(data);
        }
    }
}
