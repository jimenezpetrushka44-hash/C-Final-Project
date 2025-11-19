namespace C_FinallPROJECT.Models
{
    public class Bookings
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int RoomsID { get; set; }
        public int BillingID { get; set; }
        public DateOnly DateOfBooking { get; set; }
        public DateOnly EndOfBooking { get; set; }


    }
}
