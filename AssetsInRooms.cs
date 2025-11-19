namespace C_FinallPROJECT.Models
{
    public class AssetsInRooms
    {
        public int RoomID { get; set; }
        public Rooms Room { get; set; } = null!;

        public int AssetID { get; set; }
        public RoomAssets RoomAsset { get; set; } = null!;
    }
}
