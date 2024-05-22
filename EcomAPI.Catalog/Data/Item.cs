using MongoDB.Bson.Serialization.Attributes;

namespace EcomAPI.Catalog.Data
{
    public class Item(int Id, string Name, string Description, string ItemgroupId, string Imgurl)
    {

        public int Id { get; set; } = Id;
        public string Name { get; set; } = Name;

        public string Description { get; set; } = Description;

        public string ItemGroupId { get; set; } = ItemgroupId;
        public string Imgurl { get; set; } = Imgurl;
    }
}
