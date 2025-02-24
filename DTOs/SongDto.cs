namespace moment4v2.DTOs
{
    public class SongDto
    {
        public required string Artist { get; set; }
        public required string Title { get; set; }
        public required int Length { get; set; }
        public required string Category { get; set; }
        
        // Lägg till required
        public required string AlbumTitle { get; set; }
    }
}
