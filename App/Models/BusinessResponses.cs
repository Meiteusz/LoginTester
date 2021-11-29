namespace Models
{
    public static class BusinessResponses
    {
        private static string DefaultSuccessMessage = "";
        private static string DefaultFailedMessage = "";
        public static Response AddUserSuccess() //---------------CHANGE THE NAME OF THESE METHODS
            => new Response { Success = true, Message = BusinessConst.DefaultSuccessMessage };
        public static Response AddUserSuccess(string message)
            => new Response { Success = true, Message = message };
        public static Response AddUserFailed()
            => new Response { Success = false, Message = BusinessConst.DefaultFailedMessage };
        public static Response AddUserFailed(string message)
            => new Response { Success = false, Message = message };
    }
}
