using System.ComponentModel.DataAnnotations;
namespace portalrandkowy.API.Dtos

{
    public class MessageForSendDto
    {

        [Required(ErrorMessage="Receiever must be selected!")]
        public string ReceieverUsername {get;set;}
        public string AuthorUsername { get; set; }
        
        [Required(ErrorMessage="Content field cannot be empty!")]
        public string Content { get; set; }
        public int Like {get;set;}
    }
}