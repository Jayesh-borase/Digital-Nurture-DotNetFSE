using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    public class MailSenderTests
    {
        [Test]
        public void SendNotification_ShouldCallSendEmail()
        {
            var mockEmailService = new Mock<IEmailService>();

            var mailSender =
                new MailSender(mockEmailService.Object);

            mailSender.SendNotification(
                "test@gmail.com",
                "Hello");

            mockEmailService.Verify(
                x => x.SendEmail(
                    "test@gmail.com",
                    "Hello"),
                Times.Once);
        }
    }
}