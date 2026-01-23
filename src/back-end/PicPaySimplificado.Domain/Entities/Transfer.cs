namespace PicPaySimplificado.Domain.Entities
{
    public class Transfer : EntityBase
    {
        public decimal Value {  get; set; }
        public int PayerId { get; set; }
        public int PayeeId { get; set; }
    }
}
