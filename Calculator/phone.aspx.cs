using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
//using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class phone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("harlamovvlad@rambler.ru");
            mail.To.Add(new MailAddress("harlamowlad@gmail.com"));
            mail.Subject = TextBox2.Text;        // put subject here   
            mail.Body = TextBox1.Text+ "   "+Server.MachineName + "   "+Request.Browser.Type + "   "+Request.UserLanguages[0]+ "  "+ Request.UserHostAddress+"  "+ Request.ServerVariables["REMOTE_ADDR"];           // put body of email here

            SmtpClient smtp = new SmtpClient("smtp.rambler.ru");

            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("harlamovvlad@rambler.ru", "519vlad675");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mail);

            mail.Dispose();

            Label1.Text = "Ваше сообщение успешно отправлено!";
            Button1.Visible = false;
            Label2.Visible = false;
            TextBox2.Visible = false;
            TextBox1.Visible = false;
        }
    }
}