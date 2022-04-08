namespace Application.Classes
{
    public class Usuario
    {
        public string name { get; set; } = null!;
        public string user { get; set; } = null!;
        public int id { get; set; } 
        public string email { get; set; } = null!;
        public  string password { get ; set; } = null!;
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
