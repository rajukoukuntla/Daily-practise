using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace WebApplication1
{
    public partial class contactus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try {
                string name =txtname.Text;
                string message = txtmessge.Text;
                int phone = Convert.ToInt32(txtphone.Text);
                //exchage server
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("your mail id","password");
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage msg = new MailMessage("your mail id", txtemail.Text);
                msg.Subject = "test mail";
                msg.Body = "Hi"+ name +"/n this message for u to test and ur message is"+ message +"an will contact this phone number"+ phone +"/n Thank you buddy";
                smtp.Send(msg);
                
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}