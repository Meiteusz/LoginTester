using System;

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
    }
}
