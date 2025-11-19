namespace C_FinallPROJECT.Models
{
    public class Floors
    {
        public int FloorID { get; set; }
        public int HotelID { get; set; }
        public string FloorStatus { get; set; } = "Available";
        public string FloorStatus { get; set; } = "Available";

        public List<Rooms>? Room { get; set; }
    }
}
