using System;

namespace Models
{
    public class UserDAL
    {
        public Response InsertUser(User user)
        {
            Response response = new Response();

            try
            {
                using (var context = new LoginTesterContext())
                {
                    context.AddAsync(user);
                    context.SaveChangesAsync();

                    response.Success = true;
                    response.Message = "User Registered";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
