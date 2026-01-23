using PicPaySimplificado.Domain.Enums;

namespace PicPaySimplificado.Domain.Entities
{
    public class User : EntityBase
    {
        public string FullName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public TypeUser TypeUser { get; set; } = TypeUser.Common;
        public Guid UserIdentifier { get; set; } = Guid.NewGuid();
    }
}
