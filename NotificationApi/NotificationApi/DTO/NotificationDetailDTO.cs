namespace NotificationApi.DTO
{
    public class NotificationDetailDTO
    {
       
            public string whatsAppNumber { get; set; }
            public string? invalidWhatsappNumbers { get; set; }
            public string? error { get; set; }
            public int? NotificationMasterId { get; set; }
            public string status { get; set; }
            public DateTime Date { get; set; }

       
    }
}
