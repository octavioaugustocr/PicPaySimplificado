namespace PicPaySimplificado.Communication.Responses.User
{
    public class ResponseRegisteredUserJson
    {
        public string FullName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }
}
