namespace New_JWT_Api.Models
{
    public class Record
    {
        public record AuthenticateRequest (string UserName, string Password);
    }
}
