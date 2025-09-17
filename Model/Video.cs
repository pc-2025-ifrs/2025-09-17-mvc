namespace _2025_09_17_mvc.Model
{
    public record class Video
    {
        public string? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Likes { get; set; } = 0;
    }

}