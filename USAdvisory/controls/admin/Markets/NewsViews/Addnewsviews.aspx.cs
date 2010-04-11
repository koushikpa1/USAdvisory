﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DStreet.USAdvisory.Business.Admin.Markets.NewsViews;

public partial class admin_Markets_NewsViews_Addnewsviews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["admin"].ToString()))
            Response.Redirect ("~/LogMeIn.aspx");
            
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        bool _isActive = false;

        bool _isPaid = false;

        if (isActive.Checked)
            _isActive = true;

        if (isPaid.Checked)
            _isPaid = true;

        newsviewsadd _newsviewsAdd = new newsviewsadd(txtheader.Text, fckcontent.Value, DateTime.Now, _isActive,_isPaid,txtTicker.Text);
        _newsviewsAdd.AddNewsViews();
        Response.Redirect("newsviewslisting.aspx");
    }
}
