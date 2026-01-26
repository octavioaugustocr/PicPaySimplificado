namespace PicPaySimplificado.Communication.Requests.User.Register
{
    public class RequestRegisterUserCommonJson
    {
        public string FullName { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
