using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace TemplateNetCoreApiAndMongoSimple.Models
{
    /// <summary>
    /// model mẫu
    /// </summary>
    public class Book
    {
        [BsonId] // thuộc tính đánh dấu khóa chính của document
        [BsonRepresentation(BsonType.ObjectId)] // thuộc tính cho phép truyền tham số dưới dạng string thay vì cáu trúc ObjectId, Mongo sẽ xử lý việc chuyển đổi 
        public string? Id { get; set; }

        [BsonElement("Name")] // thuộc tính thể hiện giá trị của thuộc tính Name sẽ đại diện cho tham số BookName trong collection Mongo
        [JsonPropertyName("Name")] // thể hiện thuộc tính qua Json serialiazation
        public string BookName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;
    }
}
