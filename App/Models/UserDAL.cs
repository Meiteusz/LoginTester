using System;
using System.Linq;

namespace Models
{
    public class UserDAL : BusinessEntity
    {
        public Response InsertUser(User user)
        {
            try
            {
                AddUser(user);
                return BusinessResponses.AddUserSuccess("User Registerd Succefully");
            }
            catch (Exception ex)
            {
                return BusinessResponses.AddUserFailed(ex.Message);
            }
        }

        public Response LoginUser(User user)
        {
            try
            {
                using (var context = new LoginTesterContext())
                {
                    if (context.Users.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password) != null)
                    {
                        return BusinessResponses.AddUserSuccess("Login succefully");
                    }
                    else
                    {
                        return BusinessResponses.AddUserFailed("User not finded");
                    }
                }
            }
            catch (Exception ex)
            {
                return BusinessResponses.AddUserFailed(ex.Message);
            }
        }
    }
}
