namespace C_FinallPROJECT.Models
{
    public class ExtraAssets
    {
        public int ExtraAssetID { get; set; }
        public string ExtraAssetName { get; set; } = null!;
        public string ExtraAssetType { get; set; } = "Working";

        public List<BookingExtraAssets>? BookingExtraAsset { get; set; }

    }
}
