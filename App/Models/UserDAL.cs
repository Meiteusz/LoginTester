using System;

namespace Models
{
    public class UserDAL : SavingHelper
    {
        public Response InsertUser(User user)
        {
            Response response = new Response();

            try
            {
                Add(user);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }

    public class SavingHelper // improving
    {
        public void Add(User user)
        {
            try
            {
                using (var context = new LoginTesterContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
    
            }
        }
    }
}
