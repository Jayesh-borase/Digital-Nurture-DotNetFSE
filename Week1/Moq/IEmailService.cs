namespace CustomerCommLib
{
    public interface IEmailService
    {
        void SendEmail(string to, string message);
    }
}