using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;


public partial class QueryCorner : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string userID = txtUserID.Text;
        int value = Convert.ToInt32(ddQueryDomain.SelectedValue);
        string Query = txtQuery.Text;
        sendEmail("karthik910@gmail.com", "Query From " + userID, Query);


    }

    public void sendEmail(String aemailaddress, String asubject, String abody)
    {
        try
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("karthik910@gmail.com", "123");
            MailAddress to = new MailAddress(aemailaddress, "Sas");
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = "Gmail test email with SSL and Credentials";
            NetworkCredential myCreds = new NetworkCredential("uday_ramayanam@gmail.com", "", "");
            client.Credentials = myCreds;

            client.Send(message);
            Label1.Text = "Mail Delivery Successful";
        }
        catch (Exception e)
        {
            Label1.Text = "Mail Delivery Unsucessful";
        }
        finally
        {
            txtUserID.Text = "";
            txtQuery.Text = "";
        }


    }
}
