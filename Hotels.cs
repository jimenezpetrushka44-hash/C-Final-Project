namespace C_FinallPROJECT.Models
{
    public class Hotels
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; } = null!;
        public string HotelLocation { get; set; } = null!;
        public string HotelStatus { get; set; } = "Open";

        public List<Floors>? Floor { get; set; }


    }
}
