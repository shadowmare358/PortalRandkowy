namespace portalrandkowy.API.Models
{
    public class Message
    {
         public int Id { get; set; }
         public int AuthorId {get;set;}
         public int ReceieverId {get;set;}
        public string AuthorUsername { get; set; }
        public string ReceieverUsername { get; set; }
        public string Content { get; set; }
        public int Like {get;set;}

    }
}