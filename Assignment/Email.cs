using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace Assignment
{
    public class Email  // Declaring a new class called 'Email' with Public as protection level.
    {
        private string userEmail; // Declaring the variables inside the class, and setting it's protection level to Private.

        public string UserEmail // This is the encapsulation of the property (UserEmail).
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public SmtpClient client = new SmtpClient(); // Declaring a new client to send an email.

        public MailMessage message = new MailMessage(); // The message that is going to be sent in the email. 

        public System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("2ED5mcast@gmail.com", "mcast2014"); 

        public void SendEmail(string sendTo, string sendFrom, string subject, string body) // The methos that sends the email, has 4 inputs.
        {
            try
            {
                client.Host = "smtp.gmail.com"; // Declraring Host.

                client.Port = 587; // Declaring port. 

                client.UseDefaultCredentials = false; // Setting credentials to false.

                client.Credentials = credentials; // Setting credentials. 

                client.EnableSsl = true; // Setting enableSs1 to true.

                MailAddress to = new MailAddress(sendTo); // To whom

                MailAddress from = new MailAddress(sendFrom); // From

                //Writing the message
                message.Subject = subject; 

                message.Body = body;

                message.From = from;

                message.To.Add(to); // Adding to whom you're sending it to.

                client.Send(message); // Sending the message.
            }

            catch (Exception ex) // The error if the message s not sent. 
            {
                MessageBox.Show(ex.Message, "Error With sending Email");
            }
        }
    }
}
