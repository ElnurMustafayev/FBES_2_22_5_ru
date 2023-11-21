using System.Net;
using System.Net.Mail;

var username = Environment.GetEnvironmentVariable("SMTP_USERNAME");
var password = Environment.GetEnvironmentVariable("SMTP_PASSWORD");

var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525) {
    Credentials = new NetworkCredential(username, password),
    EnableSsl = true
};

const string receiver = "jafar@example.com";

MailMessage mailMessage = new MailMessage(
    from: new MailAddress("elnur@example.com"),
    to: new MailAddress(receiver)
) {
    IsBodyHtml = true,
    Body = $@"
    <div>
        <h1 style=""text-align: center;"">Hello, {receiver}!</h1>

        <button style=""background-color: green; color: white;"">Click this button!</button>
    </div>",
};

client.Send(mailMessage);