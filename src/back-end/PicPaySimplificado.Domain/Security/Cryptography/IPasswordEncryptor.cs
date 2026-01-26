namespace PicPaySimplificado.Domain.Security.Cryptography
{
    public interface IPasswordEncryptor
    {
        public string Encrypt(string password);
        public bool IsValid(string password, string passwordHash);
    }
}
