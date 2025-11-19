namespace C_FinallPROJECT.Models
{
    public class BillingInfo
    {
        public int BillingID { get; set; }
        public int UserID { get; set; }
        public string CardNumber { get; set; } = null!;
        public Users User { get; set; } = null!;

    }
}
