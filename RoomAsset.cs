namespace C_FinallPROJECT.Models
{
    public class RoomAssets
    {
        public int AssetID { get; set; }

        public string AssetName { get; set; } = null!;
        public string AssetStatus { get; set; } = "Working";

        public List<AssetsInRooms>? AssetsInRoom { get; set; }

    }
}
