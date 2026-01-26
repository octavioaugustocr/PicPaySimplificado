namespace PicPaySimplificado.Communication.Requests.User.Register
{
    public class RequestRegisterUserMerchantJson
    {
        public string FullName { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
