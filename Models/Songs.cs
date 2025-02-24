namespace moment4v2.Models
{
    public class Song
    {
        public int Id { get; set; }
        public required string Artist { get; set; }
        public required string Title { get; set; }
        public required int Length { get; set; }
        public required string Category { get; set; }
    }
}




/*

Artist
Låt-titel
Spel-längd (i sekunder)
Kategori/Kategorier (exempelvis "rock", "pop", "trance", "dragspel")

{
        "artist" : "Metallica",
        "title" : "Master of puppets",
        "length" : 507 ,
        "category" : "Metal"
    }, 

*/