namespace NotificationApi.Models
{
    public class MyErrorModel
    {
        public string Error { get; set; }
        public List<string> InvalidWhatsappNumbers { get; set; }
        public List<string> InvalidCustomParameters { get; set; }
    }
}
