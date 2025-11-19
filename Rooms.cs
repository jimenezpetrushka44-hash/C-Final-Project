namespace C_FinallPROJECT.Models
{
    public class Rooms
    {
        public int RoomID { get; set; }
        public int FloorID { get; set; } 
        public int TypeID { get; set; }

        public Floors Floor { get; set; } = null!;
        public RoomType RoomTypes { get; set; } = null!;
    }
}
 
