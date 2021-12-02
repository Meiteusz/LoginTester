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
                return BusinessResponses.SuccessResponse("User Registerd Succefully");
            }
            catch (Exception ex)
            {
                return BusinessResponses.FailedResponse(ex.Message);
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
                        return BusinessResponses.SuccessResponse("Login succefully");
                    }
                    else
                    {
                        return BusinessResponses.FailedResponse("User not finded");
                    }
                }
            }
            catch (Exception ex)
            {
                return BusinessResponses.FailedResponse(ex.Message);
            }
        }
    }
}
