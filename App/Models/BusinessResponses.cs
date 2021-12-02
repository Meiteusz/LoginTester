namespace Models
{
    public static class BusinessResponses
    {
        public static Response SuccessResponse()
            => new Response { Success = true, Message = BusinessConst.DefaultSuccessMessage };
        public static Response SuccessResponse(string message)
            => new Response { Success = true, Message = message };
        public static Response FailedResponse()
            => new Response { Success = false, Message = BusinessConst.DefaultFailedMessage };
        public static Response FailedResponse(string message)
            => new Response { Success = false, Message = message };
    }
}
