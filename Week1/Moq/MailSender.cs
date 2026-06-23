namespace CustomerCommLib
{
    public class MailSender
    {
        private readonly IEmailService _emailService;

        public MailSender(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void SendNotification(string to, string message)
        {
            _emailService.SendEmail(to, message);
        }
    }
}