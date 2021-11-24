using System;

namespace Models
{
    public abstract class BusinessEntity : IBusinessEntity
    {
        public void AddUser(User user) //change this to add any entity
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
                throw new Exception(ex.Message);
            }
        }
    }
}
