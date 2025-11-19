namespace C_FinallPROJECT.Models
{
    public class Floors
    {
        public int FloorID { get; set; }
        public int HotelID { get; set; }
        public Hotels Hotel { get; set; } = null!;
        public string FloorStatus { get; set; } = "Available";
    }
}
