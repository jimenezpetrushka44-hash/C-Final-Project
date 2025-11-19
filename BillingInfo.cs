namespace C_FinallPROJECT.Models
{
    public class BillingInfo
    {
        public int BillingID { get; set; }
        public int UserID { get; set; }
        public Users User { get; set; } = null!;
        public string CardNumber { get; set; } = null!;


    }
}
