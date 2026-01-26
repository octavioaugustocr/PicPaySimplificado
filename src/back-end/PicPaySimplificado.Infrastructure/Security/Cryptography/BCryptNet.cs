using PicPaySimplificado.Domain.Security.Cryptography;

namespace PicPaySimplificado.Infrastructure.Security.Cryptography
{
    public class BCryptNet : IPasswordEncryptor
    {
        public string Encrypt(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public bool IsValid(string password, string passwordHash) => BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }
}
