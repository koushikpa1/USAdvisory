using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;

/// <summary>
/// Summary description for MessageBox
/// </summary>
public class MessageBox
{
    public static void ShowMessageBox(string message, Page currentPage)
    {
        if (!string.IsNullOrEmpty(message))
        {
            if (message.EndsWith("."))
                message = message.Substring(0, message.Length - 1);
        }

        StringBuilder sbScript = new StringBuilder(50);
        //Java Script header
        sbScript.Append("<script type='text/javascript'>" + Environment.NewLine);
        sbScript.Append("// Show messagebox" + Environment.NewLine);
        message = message.Replace("\n", "\\n").Replace("\"", "'");
        sbScript.Append(@"alert( """ + message + @""" );");
        sbScript.Append(@"</script>");
        // Gets the executing web page
        //currentPage = HttpContext.Current.CurrentHandler as Page;
        // Checks if the handler is a Page and that the script isn't already on the Page
        if (currentPage != null && !currentPage.ClientScript.IsStartupScriptRegistered("ShowMessageBox"))
        {
            currentPage.ClientScript.RegisterStartupScript(typeof(string), "ShowMessageBox", sbScript.ToString());
        }
    }
}

