using Controllers.Interfaces;
using Models.Interfaces;
using System;

namespace Controllers
{
    public class UserBLL : IUserBLL
    {
        public readonly IUser _user;

        public UserBLL(IUser user)
        {
            _user = user;
        }
    }
}
