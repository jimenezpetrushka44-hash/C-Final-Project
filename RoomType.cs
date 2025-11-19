namespace C_FinallPROJECT.Models
{
    public class RoomType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; } = null!;
        public decimal TypePrice { get; set; }

        public List<Rooms>? Room { get; set; }
    }
}
