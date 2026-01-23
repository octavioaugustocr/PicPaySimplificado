namespace PicPaySimplificado.Domain.Entities
{
    public class Deposit : EntityBase
    {
        public decimal Value { get; set; }
        public int UserId { get; set; }
    }
}
