using MusicShop.BusinessLogic.Core;
using MusicShop.BusinessLogic.Interfaces;
using System.Web;
using System;
using MusicShop.Domain.Entities.User;

namespace MusicShop.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return ULoginAction(data);
        }
        public URegisterResp UserRegister(URegisterData data)
        {
            return URegisterAction(data);
        }

        [Obsolete]
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }

        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

       
    }
}
